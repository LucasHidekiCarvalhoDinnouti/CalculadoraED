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

namespace _16185_16195_Projeto3ED
{
    public partial class frmCaminhosDeTrem : Form
    {
        private int[] bestPath;
        private int[] path;
        private double best = int.MaxValue;

        private static int NUM_CIDADES = 39; 

        private double[,] adjPreco       = new double[NUM_CIDADES, NUM_CIDADES];
        private double[,] adjTempo       = new double[NUM_CIDADES, NUM_CIDADES];
        private double[,] adjDistancia   = new double[NUM_CIDADES, NUM_CIDADES];
        private List<string> listaCidades  = new List<string> ();

        public frmCaminhosDeTrem()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            StreamReader leitor = new StreamReader("Cidades.txt");
         
            string linha       = "";
            int    contadorAux = 0; 

            while ((linha = leitor.ReadLine()) != null)
            {
                string nomeCidade = linha.Trim();

                listaCidades.Insert(contadorAux,nomeCidade);
                contadorAux++;
            }

            leitor.Close();

            EncherMatriz(adjDistancia, double.MaxValue);
            EncherMatriz(adjPreco, double.MaxValue);
            EncherMatriz(adjTempo, double.MaxValue);

            leitor = new StreamReader("Caminhos.txt");
            while ((linha = leitor.ReadLine()) != null)
            {
                string nomeCidadeOrigem  = linha.Substring(0, 15).Trim();
                string nomeCidadeDestino = linha.Substring(15, 15).Trim();

                double distancia = Convert.ToDouble(linha.Substring(30, 5));
                double velMedia  = Convert.ToDouble(linha.Substring(35, 5));
                double preco     = Convert.ToDouble(linha.Substring(40));

                int l = listaCidades.IndexOf(nomeCidadeOrigem);
                int c = listaCidades.IndexOf(nomeCidadeDestino);

                
                if (l >= 0 && c >= 0)
                {
                    adjDistancia[l, c] = distancia;
                    adjTempo[l, c] = (distancia / velMedia)*60;
                    adjPreco[l, c] = preco;
                }
            }
            for (int i = 0; i < listaCidades.Count; i++)
            {
                cbSaida.Items.Add(listaCidades[i]);
                cbDestino.Items.Add(listaCidades[i]);
                cbAddOrigem.Items.Add(listaCidades[i]);
                cbAddDestino.Items.Add(listaCidades[i]);
            }
        }

        private void EncherMatriz (double [,] mat, double doQue)
        {
            for (int i = 0; i < NUM_CIDADES; i++)
            {
                for (int j = 0; j < NUM_CIDADES; j++)
                {
                    mat[i, j] = doQue;
                }
            }
        }

        private void CopiarMatriz (double[,] a1, double[,] a2)
        {
            for (int i = 0; i<NUM_CIDADES; i++)
            {
                for (int j = 0; j < NUM_CIDADES; j++)
                {
                    a1[i, j] = a2[i, j];
                }
            }
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double[,] adjAtual = new double[NUM_CIDADES, NUM_CIDADES];

            string escolha;

            if (rbDistancia.Checked)
            {
                CopiarMatriz(adjAtual, adjDistancia);
                escolha = "Distância";
            }
            else if (rbPreco.Checked)
            {
                CopiarMatriz(adjAtual, adjPreco);
                escolha = "Preço";
            }
            else if (rbTempo.Checked)
            {
                CopiarMatriz(adjAtual, adjTempo);
                escolha = "Tempo";
            }
            else
            {
                CopiarMatriz(adjAtual, adjDistancia);
                escolha = "Distância";
            }
                

            lsbCaminho.Items.Clear();
            string [] visited = new string [NUM_CIDADES];

            for (int i = 0; i<visited.Length; i++)
                visited[i] = "";

            int origem  = listaCidades.IndexOf(cbSaida.Text);
            int destino = listaCidades.IndexOf(cbDestino.Text);
            
            if (origem < 0 || destino < 0 )
            {
                MessageBox.Show("Selecione uma Cidade dentro da lista das válidas");
                return;
            }

            path = new int[NUM_CIDADES];
            bestPath = new int[NUM_CIDADES];

            for (int i = 0; i < bestPath.Length; i++)
                bestPath[i] = -1;

            path[origem] = -1;

            DFS(adjAtual, visited, origem, destino, path, 0);

            if (best != int.MaxValue)
            {
                Stack<int> percurso = new Stack<int>();

                string fim = listaCidades[destino];
                while (bestPath[destino] != -1)
                {
                    percurso.Push(bestPath[destino]);
                    destino = bestPath[destino];
                }

                double distancia = ValorDoCaminho(percurso.ToArray(), adjDistancia);
                double preco = ValorDoCaminho(percurso.ToArray(), adjPreco);
                double tempo = ValorDoCaminho(percurso.ToArray(), adjTempo);

                txtDistancia.Text = distancia.ToString() + "Km";
                txtPreco.Text = "€" + preco.ToString();

                int h = (int)tempo / 60;
                int m = (int)tempo % 60;
                txtTempo.Text = h.ToString() + "h" + m.ToString() + "min";

                while (percurso.Count != 0)
                {
                    lsbCaminho.Items.Add(listaCidades[percurso.Pop()]);
                    lsbCaminho.Items.Add("V");
                }
                lsbCaminho.Items.Add(fim);
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

        public double ValorDoCaminho (int [] caminho, double[,] matriz)
        {
            double temp = 0;
            
            for (int i = 1; i < caminho.Length; i++)
            {
                temp += matriz[caminho[i-1],caminho[i]];
            }
            return temp;
        }
        
        public void DFS(double[,] adj, string[] visited, int origem, int destino, int[] path, double dist)
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
                if (adj[origem, i] != double.MaxValue && visited[i] != "visiting")
                {
                    path[i] = origem;
                    DFS(adj, visited, i, destino, path, dist + adj[origem, i]);
                }
            }
            visited[origem] = "visited";
        }

        private void btnAdicionarCidade_Click(object sender, EventArgs e)
        {
            StreamWriter escritor = new StreamWriter("Cidades.txt");
            string espacos = "                                 ";
            string novoNome = txtNome.Text;
            listaCidades.Add(novoNome);

            escritor.WriteLine(novoNome + espacos.Substring(0, 30-novoNome.Length));
            escritor.Close();
        }

        private void rbDistancia_Click(object sender, EventArgs e)
        {
            txtDistancia.BackColor = Color.LightGreen;
            txtPreco.BackColor = Color.White;
            txtTempo.BackColor = Color.White;
        }

        private void rbTempo_Click(object sender, EventArgs e)
        {
            txtDistancia.BackColor = Color.White;
            txtPreco.BackColor = Color.White;
            txtTempo.BackColor = Color.LightGreen;
        }

        private void rbPreco_Click(object sender, EventArgs e)
        {
            txtDistancia.BackColor = Color.White;
            txtPreco.BackColor = Color.LightGreen;
            txtTempo.BackColor = Color.White;
        }


        //public double DFS(double[,] adj, string[] visited, int origem, int destino, int[] path, int level)
        //{
        //    string str = "";

        //    for (int i = 0; i < level; i++)
        //        str += "-";

        //    if (origem == destino)
        //    {
        //        Console.Out.WriteLine(str + origem + " ");
        //        return 0;
        //    }
        //    else
        //    {
        //        Console.Out.WriteLine(str + origem);
        //    }

        //    visited[origem] = "visiting";
        //    for (int i = 0; i < adj.GetLength(0); i++)
        //    {
        //        double result;
        //        if ((adj[origem, i] != double.MaxValue) && (!visited[i].Equals("visiting")))
        //        {
        //            path[i] = origem;
        //            result = DFS(adj, visited, i, destino, path, level + 1) + adj[origem, i];
        //            if (i == destino)
        //            {
        //                if (result < best)
        //                {
        //                    best = result;
        //                    Array.Copy(path, bestPath, NUM_CIDADES);
        //                }
        //            }
        //        }
        //    }
        //    visited[origem] = "visited";
        //    return best;
        //}
    }
}
