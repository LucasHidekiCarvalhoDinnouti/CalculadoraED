using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _16185_16195_Projeto4ED
{
    public partial class frmCaminhos : Form
    {
        enum Metodos { RECURSAO, BACKTRACKING, DJIKSTRA };
        Metodos metodoAtual = Metodos.RECURSAO;

        private double best = int.MaxValue;
        private int[] bestPath;
        private int[] path;
        private List<string> listaCidades = new List<string>();

        frmAdd frmAdd = new frmAdd();

        public static Grafo grafoCaminhos = new Grafo();

        public frmCaminhos()
        {
            InitializeComponent();
        }

        private void btnAcharCaminhos_Click(object sender, EventArgs e)
        {
            int origem = cbCidadeOrigem.SelectedIndex;
            int destino = cbCidadeDestino.SelectedIndex;

            lsbCaminhos.Items.Clear();

            switch (metodoAtual)
            {
                case Metodos.RECURSAO:
                    PreparacaoParaRecursao();
                    break;
                case Metodos.BACKTRACKING:
                    PilhaVetor<Movimento> saida = new PilhaVetor<Movimento>();
                    Backtracking(origem, destino, 10, saida);
                    break;
                case Metodos.DJIKSTRA:
                    Djikstra();
                    break;
            }
        }

        public void PreparacaoParaRecursao()
        {
            lsbCaminhos.Items.Clear();
            string[] visited = new string[103];

            for (int i = 0; i < visited.Length; i++)
                visited[i] = "";

            int origem = listaCidades.IndexOf(cbCidadeOrigem.Text);
            int destino = listaCidades.IndexOf(cbCidadeDestino.Text);

            if (origem < 0 || destino < 0 || origem == destino)
            {
                MessageBox.Show("Selecione duas cidades diferentes dentro da lista das válidas");
                return;
            }

            path = new int[103];
            bestPath = new int[103];

            for (int i = 0; i < bestPath.Length; i++)
                bestPath[i] = -1;

            path[origem] = -1;

            Recursao(grafoCaminhos.MatAdj, visited, origem, destino, path, 0);

            if (best != int.MaxValue)
            {
                Stack<int> percurso = new Stack<int>();

                string fim = listaCidades[destino];

                percurso.Push(listaCidades.IndexOf(fim));

                while (bestPath[destino] != -1)
                {
                    percurso.Push(bestPath[destino]);
                    destino = bestPath[destino];
                }

                int peso = ValorDoCaminho(percurso.ToArray(), grafoCaminhos.MatAdj);

                lsbCaminhos.Items.Add(peso.ToString());


                while (percurso.Count != 1)
                {
                    lsbCaminhos.Items.Add(listaCidades[percurso.Pop()]);
                    lsbCaminhos.Items.Add("V");
                }
                lsbCaminhos.Items.Add(fim);
            }
            else
            {
                MessageBox.Show("Não há caminho entre as cidades");
                return;
            }

            for (int i = 0; i < visited.Length; i++)
                visited[i] = "";

            for (int i = 0; i < bestPath.Length; i++)
                bestPath[i] = -1;

            for (int i = 0; i < path.Length; i++)
                path[i] = default(int);

            best = int.MaxValue;
        }

        private void Recursao(int[,] adj, string[] visited, int origem, int destino, int[] path, double dist)
        {
            if (origem == destino)
            {
                if (dist < best)
                {
                    best = dist;
                    bestPath = new int[path.Length];
                    Array.Copy(path, 0, bestPath, 0, path.Length);
                }
                return;
            }
            visited[origem] = "visiting";
            for (int i = 0; i < adj.GetLength(0); i++)
            {
                if (adj[origem, i] != int.MaxValue && visited[i] != "visiting")
                {
                    path[i] = origem;
                    Recursao(adj, visited, i, destino, path, dist + adj[origem, i]);
                }
            }
            visited[origem] = "visited";
        }

        public int ValorDoCaminho(int[] caminho, int[,] matriz)
        {
            int temp = 0;

            for (int i = 1; i < caminho.Length; i++)
            {
                temp += matriz[caminho[i - 1], caminho[i]];
            }
            return temp;
        }

        private bool Backtracking(int origem, int destino, int col, PilhaVetor<Movimento> saida)
        {
            PilhaVetor<Movimento> p = new PilhaVetor<Movimento>();
            bool[] passou = new bool[col];
            int cidade_atual,
            saida_atual, ind;
            bool achou = false;
            for (ind = 0; ind < col; ind++) // inicia os valores de “passou”
                passou[ind] = false; // pois ainda não foi em nenhuma cidade
            cidade_atual = origem;
            saida_atual = 0;
            while (!achou &&
            !(cidade_atual == origem && saida_atual == col && p.EstaVazia()))
            {
                while ((saida_atual < col) && !achou)
                {
                    // se não há saida pela cidade testada, verifica a próxima
                    if (grafoCaminhos.MatAdj[cidade_atual, saida_atual] == int.MaxValue)
                        saida_atual++;
                    else
                    // se já passou pela cidade testada, verifica se a próxima
                    // cidade permite saida
                    if (passou[saida_atual])
                        saida_atual++;
                    else
                    // se chegou na cidade desejada, empilha o local
                    // e termina o processo de procura de caminho
                    if (saida_atual == destino)
                    {
                        Movimento movim = new Movimento();
                        movim.Cidade = cidade_atual;
                        movim.Saida = saida_atual;
                        lsbCaminhos.Items.Add("Saiu de " + cidade_atual + " para " + saida_atual + ", que é o destino.");
                        p.Empilhar(movim);
                        achou = true;
                    }
                    else
                    {
                        Movimento movim = new Movimento();
                        movim.Cidade = cidade_atual;
                        movim.Saida = saida_atual;
                        p.Empilhar(movim);
                        passou[cidade_atual] = true;
                        Console.WriteLine("Saiu de " + cidade_atual + " para " + saida_atual);
                        lsbCaminhos.Items.Add("Saiu de " + cidade_atual + " para " + saida_atual);
                        cidade_atual = saida_atual;
                        saida_atual = 0;
                    }
                }
                if (!achou)
                    if (!p.EstaVazia())
                    {
                        Movimento movim = (Movimento)p.Desempilhar();
                        saida_atual = movim.Saida;
                        cidade_atual = movim.Cidade;
                        movim = null;
                        lsbCaminhos.Items.Add("voltando de " + saida_atual + " para " + cidade_atual);
                        Console.WriteLine("voltando de " + saida_atual + " para " + cidade_atual);
                        saida_atual++;
                    }
            }
            if (achou)
            { // desempilha a configuração atual da pilha
              // para a pilha da lista de parâmetros
                while (!p.EstaVazia())
                {
                    Movimento movim = (Movimento)p.Desempilhar();
                    saida.Empilhar(movim);
                }
            }
            return achou;
        }

        private void Djikstra()
        {
            throw new NotImplementedException();
        }

        private void rbBacktracking_Click(object sender, EventArgs e)
        {
            metodoAtual = Metodos.BACKTRACKING;
        }

        private void rbDjikstra_Click(object sender, EventArgs e)
        {
            metodoAtual = Metodos.DJIKSTRA;
        }

        private void rbRecursao_Click(object sender, EventArgs e)
        {
            metodoAtual = Metodos.RECURSAO;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmAdd.Show();
        }

        public void atualizaCbx (string novaCidade)
        {
            cbCidadeOrigem.Items.Add(novaCidade);
            cbCidadeDestino.Items.Add(novaCidade);
        }

        public void atualizaDgv ()
        {
            for (int i = 0; i < grafoCaminhos.NumVerts; i++)
            {
                string novoVertice = grafoCaminhos.Vertices[i].rotulo;
                dgvAdj.Columns.Add("col" + novoVertice, novoVertice);
                dgvAdj.Rows.Add();
            }


            for (int l = 0; l < grafoCaminhos.NumVerts; l++)
                for (int c = 0; c < grafoCaminhos.NumVerts; c++)
                    if(grafoCaminhos.MatAdj[l, c] != int.MaxValue)
                        dgvAdj[c, l].Value = grafoCaminhos.MatAdj[l, c].ToString();
                    else
                        dgvAdj[c, l].Value = "0";
            frmAdd = new frmAdd();
        }

        private void frmCaminhos_Load(object sender, EventArgs e)
        {
            frmAdd.setFrmCaminhos(this);
            frmAdd.Ler();
        }
    }
}
