using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace _16185_16195_Projeto4ED
{
    public partial class frmAdd : Form
    {
        private int posicaoDeGravacao;

        private static int NUM_CIDADES = 39;
        
        private List<string> listaCidades = new List<string>();

        public ArvoreBinaria<string> arvoreCidades = new ArvoreBinaria<string>();

        private frmCaminhos pai;

        public frmAdd()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }
        
        private void btnAdicionarCidade_Click(object sender, EventArgs e)
        {
            string novoNome = txtNome.Text.ToUpperInvariant();
            if (arvoreCidades.haDado(novoNome))
            {
                MessageBox.Show("A Cidade já existe.");
                return;
            }

            arvoreCidades.incluirComRecursao(novoNome);
            
            cbAddOrigem.Items.Add(novoNome);
            cbAddDestino.Items.Add(novoNome);

            pai.atualizaCbx(novoNome);
            
            MessageBox.Show("Cidade " + novoNome + " inserida.");
            pnlArvore.Invalidate();
        }

        
        private void btnAddRota_Click(object sender, EventArgs e)
        {
            if ((string.IsNullOrEmpty(txtPeso.Text)) ||
                (!listaCidades.Contains(cbAddOrigem.Text))||
                (!listaCidades.Contains(cbAddDestino.Text)))
            {
                MessageBox.Show("Revise os valores inseridos. Não são permitidos campos nulos ou Cidades ainda não incluídas.");
                return;
            }

            if (cbAddOrigem.Text.Equals(cbAddDestino.Text))
            {
                MessageBox.Show("Rotas precisam ser entre cidades diferentes.");
                return;
            }

            int o = listaCidades.IndexOf(cbAddOrigem.Text);
            int d = listaCidades.IndexOf(cbAddDestino.Text);

            int p = Convert.ToInt32(txtPeso.Text);

            frmCaminhos.grafoCaminhos.NovaAresta(o, d, p);

            MessageBox.Show(cbAddOrigem.Text  + "-->" + cbAddDestino.Text + 
                            " | Peso: " + txtPeso.Text + "| .");
        }
       
        public void Ler()
        {
            FileStream fs;
            long tam;
            try
            {
                fs = new FileStream("cidades.dat", FileMode.Open);

                RegistroCidade tempCidade = new RegistroCidade();

                Cidade cid = new Cidade();

                tam = fs.Length;

                listaCidades = new List<string>();

                for (int i = 0; i < tam / Cidade.tamanhoRegistro; i++)
                {
                    tempCidade.LerRegistro(fs, (long)i, ref cid);
                    frmCaminhos.grafoCaminhos.NovoVertice(cid.NomeCidade);
                    string nome = cid.NomeCidade.Trim().ToUpperInvariant();
                    listaCidades.Add(nome);
                    cbAddDestino.Items.Add(nome);
                    cbAddOrigem.Items.Add(nome);

                    pai.atualizaCbx(nome);
                }

                //adicionar balanceadamente arvoreCidades.incluirComRecursao();
                
                particionar(ref arvoreCidades.raiz, 0, listaCidades.ToArray().Length - 1);

                fs.Close();
            }
            catch
            {
                MessageBox.Show("Obs.: Você não tem um arquivo de cidades");
            }
            
            RegistroCaminho tempCaminho = new RegistroCaminho();
            Caminho cam = new Caminho();
            try
            {
                fs = new FileStream("Caminhos.dat", FileMode.Open);
            }
            catch
            {
                MessageBox.Show("Obs.: Você não tem um arquivo de caminhos");
                return;
            }
            tam = fs.Length;

            for (int i = 0; i < tam / Caminho.tamanhoRegistro; i++)
            {
                tempCaminho.LerRegistro(fs, (long)i * Caminho.tamanhoRegistro, ref cam);

                Vertice v = new Vertice(cam.CidOrigem);
                int o = IndiceDe(cam.CidOrigem, frmCaminhos.grafoCaminhos.Vertices);
                int d = IndiceDe(cam.CidDestino, frmCaminhos.grafoCaminhos.Vertices);

                frmCaminhos.grafoCaminhos.NovaAresta(o, d, cam.Peso);
            }
            fs.Close();

            pnlArvore.Invalidate();
        }

        private int IndiceDe (string chave, Vertice[] vet)
        {
            for (int i = 0; i < frmCaminhos.grafoCaminhos.NumVerts; i++)
            {
                if (vet[i].rotulo.Equals(chave))
                    return i;
            }
            return -1;
        }

        private void particionar(ref NoArvore<string> raiz, int inicio, int fim)
        {
            if (inicio > fim)
                return;
            int onde = (int)((inicio + fim) / 2);
            if (listaCidades[onde] != null)
            {
                string dado = listaCidades[onde]; 
            raiz = new NoArvore<string>(dado);
                particionar(ref raiz.esquerdo, inicio, onde - 1);
                particionar(ref raiz.direito, onde + 1, fim);
            }
        }

        public void GravarArvore(NoArvore<string> atual, FileStream f)
        {
            if (atual != null)
            {
                GravarArvore(atual.esquerdo, f);
                Cidade umaCidade = new Cidade(atual.Info);
                RegistroCidade regCidade = new RegistroCidade();
                regCidade.GravarRegistro(f, posicaoDeGravacao++, umaCidade);
                GravarArvore(atual.direito, f);
            }
        }

        public void SalvarDados()
        {
            FileStream arqCidades = new FileStream("cidades.dat", FileMode.OpenOrCreate);
            posicaoDeGravacao = 0;
            GravarArvore(arvoreCidades.Raiz, arqCidades);
            arqCidades.Close();
            MessageBox.Show("Arquivo salvo.");
        }

        private void btnSalvarCidades_Click(object sender, EventArgs e)
        {
            SalvarDados();
        }

        public void setFrmCaminhos (frmCaminhos frmCaminhos)
        {
            pai = frmCaminhos;
        }

        private void frmAdd_FormClosed(object sender, FormClosedEventArgs e)
        {
            pai.atualizaDgv();
        }

        private void pnlArvore_Paint(object sender, PaintEventArgs e)
        {
            arvoreCidades.OndeExibir = pnlArvore;
            arvoreCidades.DesenharArvore(true, arvoreCidades.Raiz, pnlArvore.Width / 2, 0, Math.PI / 2, Math.PI / 2.5, 150);
        }

        private void btnSalvarCaminhos_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream("caminhos.dat", FileMode.OpenOrCreate);
            int nRegistro = 0;

            RegistroCaminho rCaminho = new RegistroCaminho();
            for (int l = 0; l < frmCaminhos.grafoCaminhos.Vertices.Length; l++)
                for (int c = 0; c < frmCaminhos.grafoCaminhos.Vertices.Length; c++)
                    if(frmCaminhos.grafoCaminhos.MatAdj[l, c] != int.MaxValue)
                    {
                        string cidadeOrigem = listaCidades[l];
                        string cidadeDestino = listaCidades[c];

                        Caminho novoCaminho = new Caminho(cidadeOrigem, cidadeDestino, frmCaminhos.grafoCaminhos.MatAdj[l, c]);

                        rCaminho.GravarRegistro(fs, nRegistro*Caminho.tamanhoRegistro, novoCaminho);

                        nRegistro++;
                    }

            MessageBox.Show("Arquivo de caminhos salvo.");

        }
    }
}