using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16185_16195_Projeto4ED
{
    interface StackChico<Dado>
    {
        int Tamanho();
        bool EstaVazia();
        void Empilhar(Dado elemento);
        Dado Desempilhar();
        Dado OTopo();

    }
}
