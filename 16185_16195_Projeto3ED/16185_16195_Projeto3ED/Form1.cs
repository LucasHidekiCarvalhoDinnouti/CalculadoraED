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

        private double[,] adjPreco       = new double[39, 39];
        private double[,] adjVelocidade  = new double[39, 39];
        private double[,] adjDistancia   = new double[39, 39];
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
                    adjVelocidade[l, c] = velMedia;
                    adjPreco[l, c] = preco;
                }
            }
            for (int i = 0; i < listaCidades.Count; i++)
            {
                cbSaida.Items.Add(listaCidades[i]);
                cbDestino.Items.Add(listaCidades[i]);
            }
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            string [] visited = new string [listaCidades.ToArray().Length];

            for (int i = 0; i<visited.Length; i++)
                visited[i] = "";

            int start = listaCidades.IndexOf(cbSaida.SelectedText);
            int end   = listaCidades.IndexOf(cbDestino.SelectedText);

            //shit

            path = new int[40];
            bestPath = new int[path.Length];

            for (int i = 0; i < bestPath.Length; i++)
                bestPath[i] = -1;

            path[start] = -1;

            if (best != int.MaxValue)
            {
                best = DFS(adjDistancia, visited, start, end, path, 0);
                lsbCaminho.Items.Add("Best path: " + best);
                lsbCaminho.Items.Add("Path: " + end);
                while (bestPath[end] != -1)
                {
                    lsbCaminho.Items.Add("<--" + bestPath[end]);
                    end = bestPath[end];
                }
                lsbCaminho.Items.Add(" ");
            }
            else
            {
                MessageBox.Show("Não há caminho entre as cidades");
            }



        }

        public double DFS(double [,] adj, string[] visited, int start, int end, int [] path, int level)
        {
            string str = "";

            for (int i=0; i<level; i++)
                str += "-";

            if (start == end)
            {
                Console.Out.Write(str + start + " ");
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
                if ((adj[start, i] != 0)&&(!visited[i].Equals("visiting")))
                {
                    path[i] = start;
                    result = DFS(adj, visited, i, end, path, level + 1) + adj[start,i];
                    if (i == end)
                    {
                        if (result < best)
                        {
                            best = result;
                            for (int j = 0; j<path.ToArray().Length; j++)
                                bestPath[j] = path[j];
                        }
                        lsbCaminho.Items.Add("result: " + result);
                    }
                }
            }
            visited[start] = "visited";
            return best;
        }

    }
}
