using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16185_16195_Projeto4ED
{
    class PilhaException : Exception 
    {
        public PilhaException(string erro) : base(erro)
        {
        }
    }
}
