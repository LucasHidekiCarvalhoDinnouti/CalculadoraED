using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16185_16195_Projeto4ED
{
    class Movimento
    {
        private int cidade, saida; // onde estou, para onde vou

        public Movimento()
        {
            cidade = 0;
            saida = 0;
        }

        public int Cidade
        {
            get { return cidade;  }
            set { cidade = value; }
        }

        public int Saida
        {
            get { return saida;  }
            set { saida = value; }
        }

        public override string ToString()
        {
            return cidade + " " + saida;
        }
    }
}
