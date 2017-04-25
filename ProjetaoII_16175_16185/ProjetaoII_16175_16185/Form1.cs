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

        public frmCalculadora()
        {
            InitializeComponent();
        }

        private void frmCalculadora_Load(object sender, EventArgs e)
        {
            visor = "";
            Printa();
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            visor += "0";
            Printa();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            visor += "1";
            Printa();
        }       

        private void btn2_Click(object sender, EventArgs e)
        {
            visor += "2";
            Printa();
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            visor += "3";
            Printa();
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            visor += "4";
            Printa();
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            visor += "5";
            Printa();
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            visor += "6";
            Printa();
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            visor += "7";
            Printa();
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            visor += "8";
            Printa();
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            visor += "9";
            Printa();
        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            if (!visor.Equals(""))
             {
               visor = visor.Substring(0, visor.Length-1);
                Printa();
             }
        }

        private void Printa()
        {
            txtVisor.Text = visor;
        }

       

        private void btnPotencia_Click(object sender, EventArgs e)
        {

        }
    }
}
