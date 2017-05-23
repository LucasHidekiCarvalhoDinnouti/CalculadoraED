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
            //adicionar Radio group
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
            string [] visited = new string [listaCidades.ToArray().Length];

            for (int i = 0; i<visited.Length; i++)
                visited[i] = "";

            int start = listaCidades.IndexOf(cbSaida.Text);
            int end   = listaCidades.IndexOf(cbDestino.Text);
            
            if (start < 0 || end < 0 )
            {
                MessageBox.Show("Selecione uma Cidade dentro da lista das válidas");
                return;
            }

            path = new int[NUM_CIDADES];
            bestPath = new int[NUM_CIDADES];

            for (int i = 0; i < bestPath.Length; i++)
                bestPath[i] = -1;

            path[start] = -1;

            best = DFS(adjAtual, visited, start, end, path, 0);

            if (best != int.MaxValue)
            {
                lsbCaminho.Items.Add("Menor " + escolha + ": " + best);
                Stack<string> percurso = new Stack<string>();
                string destino = listaCidades[end] + ;
                while (bestPath[end] != -1)
                {
                    percurso.Push(listaCidades[bestPath[end]]);
                    end = bestPath[end];
                }
                while (percurso.Count != 0)
                {
                    lsbCaminho.Items.Add(percurso.Pop());
                    lsbCaminho.Items.Add("V");
                }
                lsbCaminho.Items.Add(destino);
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

        public double DFS(double [,] adj, string[] visited, int start, int end, int [] path, int level)
        {
            string str = "";

            for (int i=0; i<level; i++)
                str += "-";

            if (start == end)
            {
                Console.Out.WriteLine(str + start + " ");
                return 0;
            }
            else
            {
                Console.Out.WriteLine(str + start);
            }

            visited[start] = "visiting";
            for (int i=0; i<adj.GetLength(0); i++)
            {
                double result;
                if ((adj[start, i] != double.MaxValue)&&(!visited[i].Equals("visiting")))
                {
                    path[i] = start;
                    result = DFS(adj, visited, i, end, path, level + 1) + adj[start,i];
                    if (i == end)
                    {
                        if (result < best)
                        {
                            best = result;
                            Array.Copy(path, bestPath, NUM_CIDADES);
                        }
                    }
                }
            }
            visited[start] = "visited";
            return best;
        }
    }
}
