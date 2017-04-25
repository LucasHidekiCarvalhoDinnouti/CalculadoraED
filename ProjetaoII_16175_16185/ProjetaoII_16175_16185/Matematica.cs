using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetaoII_16175_16185
{
    class Matematica
    {
        PilhaListaHerdada<string> umaPilha;

        public Matematica(string expressao)
        {
            int i = 0;
            
          while (expressao.Substring(i))
            while (!ehOperando(expressao.Substring(i,i++))
            {
                    i++;
            }          
        }

        public bool HaPrecedencia(string a, string b)
        {
            switch (a)
            {
                case "(":
                    if (b == ")") return true;
                    else return false;

                case "^":
                    if (b == "(") return false;
                    else return true;

                case "*":
                    if ((b == "(") || (b == "^")) return false;
                    else return true;

                case "/":
                    if ((b == "(") || (b == "^")) return false;
                    else return true;

                case "+":
                    if ((b == "(") || (b == "^") || (b == "*") || (b == "/")) return false;
                    else return true;

                case "-":
                    if ((b == "(") || (b == "^") || (b == "*") || (b == "/")) return false;
                    else return true;

                case ")":
                    return false;
            }
            return false;

        }

        public string CalculaExpressaoPosfixa(string expressao)
        {
            PilhaListaHerdada<string> umaPilha = new PilhaListaHerdada<string>();
            string[] simbolos = new string[7];

            for (int i = 0; i < expressao.Length; i++)
            {
                string simbolo = expressao[i].ToString();
                if (!ehOperando(simbolo))
                    umaPilha.Empilhar(simbolo);
                else
                {
                    string operando1 = umaPilha.Desempilhar();
                    string operando2 = umaPilha.Desempilhar();
                    string valor = CalculaSubExpressao(operando1, operando2, simbolo);
                    umaPilha.Empilhar(valor);
                }
            }
            return umaPilha.Desempilhar();
        }

        private string CalculaSubExpressao(string op1, string op2, string s)
        {
            double v1, v2 = 0;

            v1 = Convert.ToDouble(op1);
            v2 = Convert.ToDouble(op2);

            switch (s)
            {
                case "+": return (v1 + v2).ToString();
                case "-": return (v1 - v2).ToString();
                case "*": return (v1 * v2).ToString();
                case "/": return (v1 / v2).ToString();
                case "^": return Math.Pow(v1, v2).ToString();
            }
            return Math.Pow(v1, v2).ToString();
        }

        private bool ehOperando(string s)
        {
            if ((s == "(") || (s == ")") || (s == "+") ||
                (s == "-") || (s == "*") || (s == "/") || (s == "^"))
                return true;
            else
                return false;
        }

        public void ConverteDeInfixaParaPosfixa()
        {
            umaPilha = new PilhaListaHerdada<string>(); 
          While Not EOF(Entrada) Do
      {

                Read(Entrada, Simbolo_Lido);
                If Not(Simbolo_Lido In["(", ")", "+", "-", "*", "/", ""]) Then
        Write(Simbolo_Lido) 				// escreve Operando na tela

        Else    // operador
        {

                Parar:= false;

                    While(not parar) and(not umaPilha.estaVazia()) and
                      (Ha_Precedencia(umaPilha.oTopo(), Simbolo_Lido)) Do
        {

                    Operador_com_Maior_Precedencia:= umaPilha.desempilhar();
                        If operador_com_Maior_Precedencia<> ‘(‘ then
               Write(Operador_com_Maior_Precedencia)
               Else
                 Parar := true;
                    }
                    If Simbolo_Lido<> ")" Then
            umaPilha.empilhar(Simbolo_Lido)

          Else      { fará isso QUANDO o Pilha[TOPO] = "(" }
                Operador_com_Maior_Precedencia:= umaPilha.desempilhar();
                }
            }   // While not EOF 

            While not umaPilha.estaVazia() Do { Descarrega a Pilha Para a Saída }
            {
            Operador_com_Maior_Precedencia:= umaPilha.desempilhar();
                If Operador_com_Maior_Precedencia<> "(" Then
                      Write(Operador_com_Maior_Precedencia);
            }
        }

    }
}
