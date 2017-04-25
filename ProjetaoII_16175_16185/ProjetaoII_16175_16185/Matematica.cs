using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetaoII_16175_16185
{
    class Matematica
    {
        public double [] valores = new double [26];
        PilhaListaHerdada<char> pilhaPosfixa;

        public Matematica(string expressao)
        {

        }

        public bool HaPrecedencia(char a, char b)
        {
            switch (a)
            {
                case '(':
                    if (b == ')') return true;
                    else return false;

                case '^':
                    if (b == '(') return false;
                    else return true;

                case '*':
                    if ((b == '(') || (b == '^')) return false;
                    else return true;

                case '/':
                    if ((b == '(') || (b == '^')) return false;
                    else return true;

                case '+':
                    if ((b == '(') || (b == '^') || (b == '*') || (b == '/')) return false;
                    else return true;

                case '-':
                    if ((b == '(') || (b == '^') || (b == '*') || (b == '/')) return false;
                    else return true;

                case ')':
                    return false;
            }
            return false;

        }

        public double CalculaExpressaoPosfixa(string expressao)
        {
            PilhaListaHerdada<char> pilhaPosfixa = new PilhaListaHerdada<char>();
            string[] simbolos = new string[7];

            for (int i = 0; i < expressao.Length; i++)
            {
                char simbolo = expressao[i];
                if (!ehOperador(simbolo))
                    pilhaPosfixa.Empilhar(simbolo);
                else
                {
                    char operando1 = pilhaPosfixa.Desempilhar();
                    char operando2 = pilhaPosfixa.Desempilhar();
                    double valor = CalculaSubExpressao(operando1, operando2, simbolo);
                    char resultado = DoubleToChar(valor);
                    pilhaPosfixa.Empilhar(resultado);
                }
            }
            return valores[pilhaPosfixa.Desempilhar()];
        }

        private char DoubleToChar(double valor)
        {
            int i = 0;
            for (; i < 26; i++)
            {
                if (valores[i] == default(double))
                    break;
                if (!(valor == valores[i]))
                    continue;
                else
                    return char.ConvertFromUtf32(65 + i)[0];  
            }
            valores[i] = valor;
            return char.ConvertFromUtf32(65 + i)[0];
        }

        private double CalculaSubExpressao(char op1, char op2, char s)
        {
            double v1, v2 = 0;

            v1 = Convert.ToDouble(op1);
            v2 = Convert.ToDouble(op2);

            switch (s)
            {
                case '+': return (v1 + v2);
                case '-': return (v1 - v2);
                case '*': return (v1 * v2);
                case '/': return (v1 / v2);
                case '^': return Math.Pow(v1, v2);
            }
            return Math.Pow(v1, v2);
        }

        private bool ehOperador(char s)
        {
            if ((s == '(') || (s == ')') || (s == '+') ||
                (s == '-') || (s == '*') || (s == '/') || (s == '^'))
                return true;
            else
                return false;
        }

        private string ValoresParaLetras(string expressao)
        {
            string novaExpressao = "";
            while (expressao != null)
            {
                string valor = "";
                while (!ehOperador(expressao[0]))
                {
                    valor += expressao.Remove(1, 0);
                }
                char novoValor = DoubleToChar(Convert.ToDouble(valor));
                novaExpressao += expressao.Remove(1, 0);
            }
            return novaExpressao;
        }

        public void ConverteDeInfixaParaPosfixa(string expressao)
        {
            expressao = ValoresParaLetras(expressao);
            //      pilhaPosfixa = new PilhaListaHerdada<string>(); 
            //    While Not EOF(Entrada) Do
            //{

            //          Read(Entrada, Simbolo_Lido);
            //          If Not(Simbolo_Lido In['(', ')', '+', '-', '*', '/', '']) Then
            //  Write(Simbolo_Lido) 				// escreve Operando na tela

            //  Else    // operador
            //  {

            //          Parar:= false;

            //              While(not parar) and(not pilhaPosfixa.estaVazia()) and
            //                (HaPrecedencia(pilhaPosfixa.oTopo(), Simbolo_Lido)) Do
            //  {

            //              Operador_com_Maior_Precedencia:= pilhaPosfixa.desempilhar();
            //                  If operador_com_Maior_Precedencia<> ‘(‘ then
            //         Write(Operador_com_Maior_Precedencia)
            //         Else
            //           Parar := true;
            //              }
            //              If Simbolo_Lido<> ')' Then
            //      pilhaPosfixa.empilhar(Simbolo_Lido)

            //    Else      { fará isso QUANDO o Pilha[TOPO] = '(' }
            //          Operador_com_Maior_Precedencia:= pilhaPosfixa.desempilhar();
            //          }
            //      }   // While not EOF 

            //      While not pilhaPosfixa.estaVazia() Do { Descarrega a Pilha Para a Saída }
            //      {
            //      Operador_com_Maior_Precedencia:= pilhaPosfixa.desempilhar();
            //          If Operador_com_Maior_Precedencia<> '(' Then
            //                Write(Operador_com_Maior_Precedencia);
            //      }
            //  }

        }
    }
}
