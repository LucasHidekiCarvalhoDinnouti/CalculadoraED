using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace _16185_16195_Projeto4ED
{
    class ArvoreDeBusca<Tipo> : IComparable<NoArvore<Tipo>>
                                                where Tipo : IComparable<Tipo>
    {
        public NoArvore<Tipo> raiz,
                                 atual,
                                 antecessor;

        public Panel painelArvore;

        public Panel OndeExibir
        {
            get { return painelArvore; }
            set { painelArvore = value; }
        }

        public ArvoreDeBusca()
        {
            raiz = null;
            atual = null;
            antecessor = null;
        }

        public NoArvore<Tipo> Raiz
        {
            get { return raiz; }
        }

        public String InOrdem  // propriedade que gera a string do percurso in-ordem da �rvore
        {
            get { return FazInOrdem(raiz); }
        }

        public String PreOrdem  // propriedade que gera a string do percurso pre-ordem da �rvore
        {
            get { return FazPreOrdem(raiz); }
        }

        public String PosOrdem  // propriedade que gera a string do percurso pos-ordem da �rvore
        {
            get { return FazPosOrdem(raiz); }
        }

        private String FazInOrdem(NoArvore<Tipo> r)
        {
            if (r == null)
                return "";  // retorna cadeia vazia
            else
            {
                return FazInOrdem(r.esquerdo) +
                           " " + r.Info.ToString() + " " +
                           FazInOrdem(r.direito);
            }
        }

        private String FazPreOrdem(NoArvore<Tipo> r)
        {
            if (r == null)
                return "";  // retorna cadeia vazia
            else
            {
                return
                          r.Info.ToString() +
                          " " + FazPreOrdem(r.esquerdo) + " " +
                           FazPreOrdem(r.direito);
            }
        }

        private String FazPosOrdem(NoArvore<Tipo> r)
        {
            if (r == null)
                return "";  // retorna cadeia vazia
            else
            {
                return FazPosOrdem(r.esquerdo) + " " +
                           FazPosOrdem(r.direito) +
                           " " + r.Info.ToString();
            }
        }

        public int CompareTo(NoArvore<Tipo> o)
        {
            return atual.Info.CompareTo(o.Info);
        }

        public void inserir(Tipo novosDados)
        {
            bool achou = false, fim = false;
            NoArvore<Tipo> novoNo = new NoArvore<Tipo>(novosDados);
            if (raiz == null)         // �rvore vazia
                raiz = novoNo;
            else                         // �rvore n�o-vazia
            {
                antecessor = null;
                atual = raiz;
                while (!achou && !fim)
                {
                    antecessor = atual;
                    if (novosDados.CompareTo(atual.Info) < 0)
                    {
                        atual = atual.esquerdo;
                        if (atual == null)
                        {
                            antecessor.esquerdo = novoNo;
                            fim = true;
                        }
                    }
                    else
                        if (novosDados.CompareTo(atual.Info) == 0)
                            achou = true;  // pode-se disparar uma exce��o neste caso
                        else
                        {
                            atual = atual.direito;
                            if (atual == null)
                            {
                                antecessor.direito = novoNo;
                                fim = true;
                            }
                        }
                }
            }
        }

        public bool ApagarNo(Tipo chaveARemover)
        {
            atual = raiz;
            antecessor = null;
            bool ehFilhoEsquerdo = true;
            while (atual.Info.CompareTo(chaveARemover) != 0)  // enqto n�o acha a chave a remover
            {
                antecessor = atual;
                if (atual.Info.CompareTo(chaveARemover) > 0)
                {
                    ehFilhoEsquerdo = true;
                    atual = atual.esquerdo;
                }
                else
                {
                    ehFilhoEsquerdo = false;
                    atual = atual.direito;
                }

                if (atual == null)  // neste caso, a chave a remover n�o existe e n�o pode
                    return false;   // ser exclu�da, dai retornamos falso indicando isso
            }  // fim do while

            // se fluxo de execu��o vem para este ponto, a chave a remover foi encontrada
            // e o ponteiro atual indica o n� que cont�m essa chave

            if ((atual.esquerdo == null) && (atual.direito == null))  // � folha, n� com 0 filhos
            {
                if (atual == raiz)
                    raiz = null;   // exclui a raiz e a �rvore fica vazia
                else
                    if (ehFilhoEsquerdo)        // se for filho esquerdo, o antecessor deixar� 
                        antecessor.esquerdo = null;  // de ter um descendente esquerdo
                    else                               // se for filho direito, o antecessor deixar� de 
                        antecessor.direito = null;  // apontar para esse filho

                atual = antecessor;  // feito para atual apontar um n� v�lido ao sairmos do m�todo
            }
            else   // verificar� as duas outras possibilidades, exclus�o de n� com 1 ou 2 filhos
                if (atual.direito == null)   // neste caso, s� tem o filho esquerdo
                {
                    if (atual == raiz)
                        raiz = atual.esquerdo;
                    else
                        if (ehFilhoEsquerdo)
                            antecessor.esquerdo = atual.esquerdo;
                        else
                            antecessor.direito = atual.esquerdo;
                    atual = antecessor;
                }
                else
                    if (atual.esquerdo == null)  // neste caso, s� tem o filho direito
                    {
                        if (atual == raiz)
                            raiz = atual.direito;
                        else
                            if (ehFilhoEsquerdo)
                                antecessor.esquerdo = atual.direito;
                            else
                                antecessor.direito = atual.direito;
                        atual = antecessor;
                    }
                    else // tem os dois descendentes
                    {
                        NoArvore<Tipo> menorDosMaiores = ProcuraMenorDosMaioresDescendentes(atual);
                        atual.Info = menorDosMaiores.Info;
                        menorDosMaiores = null; // para liberar o n� trocado da mem�ria
                    }
            return true;
        }

        public NoArvore<Tipo> ProcuraMenorDosMaioresDescendentes(NoArvore<Tipo> noAExcluir)
        {
            NoArvore<Tipo> paiDoSucessor = noAExcluir;
            NoArvore<Tipo> sucessor = noAExcluir;
            NoArvore<Tipo> atual = noAExcluir.direito;   // vai ao ramo direito do n� a ser exclu�do, pois este ramo cont�m
            // os descendentes que s�o maiores que o n� a ser exclu�do 
            while (atual != null)
            {
                if (atual.esquerdo != null)
                    paiDoSucessor = atual;
                sucessor = atual;
                atual = atual.esquerdo;
            }

            if (sucessor != noAExcluir.direito)
            {
                paiDoSucessor.esquerdo = sucessor.direito;
                sucessor.direito = noAExcluir.direito;
            }
            return sucessor;
        }

        public int alturaArvore(NoArvore<Tipo> atual, ref bool balanceada)
        {
            int alturaDireita, alturaEsquerda, result;
            if (atual != null && balanceada)
            {
              alturaEsquerda = 1 + alturaArvore(atual.esquerdo, ref balanceada);
              alturaDireita = 1 + alturaArvore(atual.direito, ref balanceada);
              result = Math.Max(alturaEsquerda, alturaDireita);
              
              //if (alturaDireita > alturaEsquerda)
              //    result = alturaDireita;
              //else
              //  result = alturaEsquerda;
              
              if (Math.Abs(alturaDireita - alturaEsquerda) > 1)
                 balanceada = false;
            }
            else
                result = 0;
            return result;
        }

        public int getAltura(NoArvore<Tipo> no)
        {
            if (no != null)
                return no.Altura;
            else
                return -1;
        }

        public NoArvore<Tipo> Insert(Tipo item, NoArvore<Tipo> n) 
        {
          if (n == null)
          {
            n = new NoArvore<Tipo>(item);
            OndeExibir.Invalidate();
            Application.DoEvents();
            MessageBox.Show("Inclusao sem rotacao " + n.Info.ToString());
            OndeExibir.Invalidate();
            Application.DoEvents();
          }
          else
          {
            if (item.CompareTo(n.Info) < 0)
            {
              n.esquerdo = Insert(item, n.esquerdo);
              if (getAltura(n.esquerdo) - getAltura(n.direito) == 2)  // a propriedade Altura testa nulo!
                if (item.CompareTo(n.esquerdo.Info) < 0)
                  n = RotateWithLeftChild(n);
                else
                  n = DoubleWithLeftChild(n);
            }
            else
              if (item.CompareTo(n.Info) > 0)
              {
                n.direito = Insert(item, n.direito);
                if (getAltura(n.direito) - getAltura(n.esquerdo) == 2)  // a propriedade Altura testa nulo!
                  if (item.CompareTo(n.direito.Info) > 0)
                    n = RotateWithRightChild(n);
                  else
                    n = DoubleWithRightChild(n);
              }
            //else ; - do nothing, duplicate value

            n.Altura = Math.Max(getAltura(n.esquerdo), getAltura(n.direito)) + 1;
            OndeExibir.Invalidate();
            Application.DoEvents();
          }
            return n;
    }

        private NoArvore<Tipo> RotateWithLeftChild(NoArvore<Tipo> no)
        {
            NoArvore<Tipo> temp = no;  // apenas para declarar

           temp = no.esquerdo;
           no.esquerdo = temp.direito;
           temp.direito = no;
           no.Altura = Math.Max(getAltura(no.esquerdo), getAltura(no.direito)) + 1;
           temp.Altura = Math.Max(getAltura(temp.esquerdo), getAltura(no)) + 1;
           // System.Threading.Thread.Sleep(2000);
           OndeExibir.Invalidate();
           Application.DoEvents();
           MessageBox.Show("Rota��o � direito do n� " + temp.Info.ToString());
           OndeExibir.Invalidate();
           Application.DoEvents();
           return temp;
        }

        private NoArvore<Tipo> RotateWithRightChild(NoArvore<Tipo> no)
        {
            NoArvore<Tipo> temp = no;  // apenas para declarar

            temp = no.direito;
            no.direito = temp.esquerdo;
            temp.esquerdo = no;
            no.Altura = Math.Max(getAltura(no.esquerdo), getAltura(no.direito)) + 1;
            temp.Altura = Math.Max(getAltura(temp.direito), getAltura(no)) + 1;
            //System.Threading.Thread.Sleep(2000);
            OndeExibir.Invalidate();
            Application.DoEvents();
            MessageBox.Show("Rota��o � esquerda do n� "+temp.Info.ToString());
            OndeExibir.Invalidate();
            Application.DoEvents();
            return temp;
        }

        private NoArvore<Tipo> DoubleWithLeftChild(NoArvore<Tipo> no) 
        {
            OndeExibir.Invalidate();
            Application.DoEvents();
            MessageBox.Show("Rota��o dupla � direito do n� "+no.Info.ToString());
            no.esquerdo = RotateWithRightChild( no.esquerdo );
            OndeExibir.Invalidate();
            Application.DoEvents();
            return RotateWithLeftChild(no);
        }
        
        private NoArvore<Tipo> DoubleWithRightChild(NoArvore<Tipo> no) 
        {
            OndeExibir.Invalidate();
            Application.DoEvents();
            MessageBox.Show("Rota��o dupla � esquerda do n� " + no.Info.ToString());
            no.direito = RotateWithLeftChild( no.direito );
            OndeExibir.Invalidate();
            Application.DoEvents();
            return RotateWithRightChild( no );
        }
        
    }   
}
