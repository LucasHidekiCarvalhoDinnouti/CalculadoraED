using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16185_16195_Projeto4ED
{
    public class Vertice
    {
        public String rotulo;
        public bool foiVisitado;

        public Vertice(string nomeDoVertice)
        {
            rotulo = nomeDoVertice;
            foiVisitado = false;
        }
    }
}
