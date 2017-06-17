using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace _16185_16195_Projeto4ED
{
    public class Caminho
    {
        public const int tamanhoCidOrigem = 20;
        public const int tamanhoCidDestino = 20;
        public static int tamanhoPeso = 1;

        public readonly static int CidOrigemEmBytes = tamanhoCidOrigem * Marshal.SizeOf(typeof(char));
        public readonly static int CidDestinoEmBytes = tamanhoCidDestino * Marshal.SizeOf(typeof(char));
        public readonly static int PesoEmBytes = tamanhoPeso * Marshal.SizeOf(typeof(int));
        public static readonly int tamanhoRegistro = CidOrigemEmBytes + CidDestinoEmBytes
                                                                        + PesoEmBytes;

        private String cidOrigem;       // máximo de 20 posições
        private String cidDestino;      // máximo de 20 posições
        private int peso;

        public string CidOrigem
        {
            get { return cidOrigem; }
            set
            {
                cidOrigem = value;

                if (CidOrigem.Length > tamanhoCidOrigem)    
                    CidOrigem = CidOrigem.Substring(0, 20);
            }
        }

        public string CidDestino
        {
            get { return cidDestino; }
            set
            {
                cidDestino = value;
                if (CidDestino.Length > tamanhoCidDestino)     // trunca caCidOrigemcteres além da 30a posição
                    CidDestino = CidDestino.Substring(0, tamanhoCidDestino);
            }
        }

        public int Peso
        {
            get { return peso; }
            set { peso = value; }
        }

        public Caminho()
        {

        }

        public Caminho(String o, String d, int p)
        {
            CidOrigem = o;
            CidDestino = d;
            peso = p;
        }

        public override String ToString()
        {
            return CidOrigem;
        }

        public int CompareTo(Caminho outro)
        {
            return CidOrigem.CompareTo(outro.CidOrigem); // compaCidOrigem strings
        }
    }
}