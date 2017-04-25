using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetaoII_16175_16185
{
    public partial class frmCalculadora : Form
    {
        string visor;
        char ultimoDigitado;
        bool temPonto;

        public frmCalculadora()
        {
            InitializeComponent();
        }

        private void frmCalculadora_Load(object sender, EventArgs e)
        {
            visor = "";
            ultimoDigitado = 'N';
            temPonto = false;
            Printa();
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            visor += "0";
            ultimoDigitado = '0';
            Printa();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            visor += "1";
            ultimoDigitado = '1';
            Printa();
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            visor += "2";
            ultimoDigitado = '1';
            Printa();
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            visor += "3";
            ultimoDigitado = '3';
            Printa();
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            visor += "4";
            ultimoDigitado = '4';
            Printa();
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            visor += "5";
            ultimoDigitado = '5';
            Printa();
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            visor += "6";
            ultimoDigitado = '6';
            Printa();
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            visor += "7";
            ultimoDigitado = '7';
            Printa();
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            visor += "8";
            ultimoDigitado = '8';
            Printa();
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            visor += "9";
            ultimoDigitado = '9';
            Printa();
        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            if (!visor.Equals(""))
            {
                visor = visor.Substring(0, visor.Length - 1);
                Printa();
            }
        }

        private void Printa()
        {
            txtVisor.Text = visor;
        }

        private void btnPotencia_Click(object sender, EventArgs e)
        {
            if ((!visor.Equals("")) && (!EhOperando(ultimoDigitado)))
            {
                visor += "^";
                ultimoDigitado = '^';
                temPonto = false;
                Printa();
            }
        }

        private void btnDivisao_Click(object sender, EventArgs e)
        {
            if ((!visor.Equals("")) && (!EhOperando(ultimoDigitado)))
            {
                visor += "/";
                ultimoDigitado = '/';
                temPonto = false;
                Printa();
            }
        }

        private bool EhOperando(char s)
        {
            if ((s == '(') || (s == ')') || (s == '+') || (s == '.') ||
                (s == '-') || (s == '*') || (s == '/') || (s == '^'))
                return true;
            else
                return false;
        }

        private void frmCalculadora_FormClosed(object sender, FormClosedEventArgs e)
        {
            MessageBox.Show(visor);
        }

        private void btnMultiplicacao_Click(object sender, EventArgs e)
        {
            if ((!visor.Equals("")) && (!EhOperando(ultimoDigitado)))
            {
                visor += "*";
                ultimoDigitado = '*';
                temPonto = false;
                Printa();
            }
        }

        private void btnSubtracao_Click(object sender, EventArgs e)
        {
            if ((!visor.Equals("")) && (!EhOperando(ultimoDigitado)))
            {
                visor += "-";
                ultimoDigitado = '-';
                temPonto = false;
                Printa();
            }
        }

        private void btnAdicao_Click(object sender, EventArgs e)
        {
            if ((!visor.Equals("")) && (!EhOperando(ultimoDigitado)))
            {
                visor += "+";
                ultimoDigitado = '+';
                temPonto = false;
                Printa();
            }
        }

        private void btnFechaParenteses_Click(object sender, EventArgs e)
        {
            if (!EhOperando(ultimoDigitado) || (ultimoDigitado == '(') || (ultimoDigitado == ')'))
            {
                visor += ")";
                ultimoDigitado = ')';
                temPonto = false;
                Printa();
            }
        }

        private void btnAbreParenteses_Click(object sender, EventArgs e)
        {
            if (!EhOperando(ultimoDigitado) || (ultimoDigitado == '(') || (ultimoDigitado == ')'))
            {
                visor += "(";
                ultimoDigitado = '(';
                temPonto = false;
                Printa();
            }
        }

        private void btnPonto_Click(object sender, EventArgs e)
        {
            if ((!EhOperando(ultimoDigitado) && (!visor.Equals("")) && (!temPonto)))
            {
                visor += ".";
                ultimoDigitado = '.';
                temPonto = true;
                Printa();
            }
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            //chama os métodos cabulosos 

            //txtResultado.Text = //metodo cabuloso
        }
    }
}
