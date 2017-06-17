using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace _16185_16195_Projeto4ED
{
    class Cidade
    {
        public const int tamanhoNomeCidade = 20;

        public readonly static int NomeEmBytes = tamanhoNomeCidade * Marshal.SizeOf(typeof(char));
        public static readonly int tamanhoRegistro = NomeEmBytes;

        private String nomeCidade;

        public Cidade ()
        {
        }

        public Cidade(String nc)
        {
            nomeCidade = nc;
        }

        public string NomeCidade
        {
            get { return nomeCidade; }
            set { nomeCidade = value; }
        }

        public override String ToString()
        {
            return nomeCidade;
        }

        public int CompareTo(Cidade outra)
        {
            return nomeCidade.CompareTo(outra.nomeCidade);
        }
    }
}