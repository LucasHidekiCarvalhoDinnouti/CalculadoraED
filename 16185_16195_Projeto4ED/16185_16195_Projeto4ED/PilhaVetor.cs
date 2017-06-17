using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16185_16195_Projeto4ED
{
    class PilhaVetor<Dado> : Stack<Dado>
    {
        private int topo;   // índice da última posição usada
        private Dado[] p;   // área de armazenamento

        private static int MAXIMO = 500;  // tamanho default
        private int posicoes = MAXIMO;

        public PilhaVetor() : this(MAXIMO)
        {
        }

        public PilhaVetor(int posic)
        {
            posicoes = posic;
            p = new Dado[posicoes];
        }
        public Dado Desempilhar()
        {
            if (EstaVazia())
               throw new PilhaException("Underflow de pilha");

            Dado elementoDoTopo = p[topo];
            p[topo--] = default(Dado);
            return elementoDoTopo;
        }

        public void Empilhar(Dado elemento)
        {
            if (Tamanho() == posicoes)
               throw new PilhaException("Overflow de pilha");

            p[++topo] = elemento;
        }

        public bool EstaVazia()
        {
            return (topo < 0);
        }

        public Dado OTopo()
        {
            if (EstaVazia())
                throw new PilhaException("Underflow de pilha");

            Dado elementoDoTopo = p[topo];
           
            return elementoDoTopo;
        }

        public int Tamanho()
        {
            return topo+1;
        }
    }
}
