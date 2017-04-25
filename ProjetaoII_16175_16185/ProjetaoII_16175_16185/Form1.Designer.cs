namespace ProjetaoII_16175_16185
{
    partial class frmCalculadora
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtVisor = new System.Windows.Forms.TextBox();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.lblSequencia = new System.Windows.Forms.Label();
            this.btnPotencia = new System.Windows.Forms.Button();
            this.btnDivisao = new System.Windows.Forms.Button();
            this.btnMultiplicacao = new System.Windows.Forms.Button();
            this.btnSubtracao = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btnAbreParenteses = new System.Windows.Forms.Button();
            this.btnApagar = new System.Windows.Forms.Button();
            this.btnIgual = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.btnFechaParenteses = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btnPonto = new System.Windows.Forms.Button();
            this.btnAdicao = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtVisor
            // 
            this.txtVisor.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtVisor.Enabled = false;
            this.txtVisor.Location = new System.Drawing.Point(0, 0);
            this.txtVisor.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtVisor.Name = "txtVisor";
            this.txtVisor.Size = new System.Drawing.Size(352, 27);
            this.txtVisor.TabIndex = 0;
            // 
            // txtResultado
            // 
            this.txtResultado.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtResultado.Enabled = false;
            this.txtResultado.Location = new System.Drawing.Point(0, 27);
            this.txtResultado.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.Size = new System.Drawing.Size(352, 27);
            this.txtResultado.TabIndex = 1;
            // 
            // lblSequencia
            // 
            this.lblSequencia.AutoSize = true;
            this.lblSequencia.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSequencia.Location = new System.Drawing.Point(12, 59);
            this.lblSequencia.Name = "lblSequencia";
            this.lblSequencia.Size = new System.Drawing.Size(62, 19);
            this.lblSequencia.TabIndex = 2;
            this.lblSequencia.Text = "Pósfixa";
            // 
            // btnPotencia
            // 
            this.btnPotencia.Location = new System.Drawing.Point(16, 110);
            this.btnPotencia.Name = "btnPotencia";
            this.btnPotencia.Size = new System.Drawing.Size(75, 34);
            this.btnPotencia.TabIndex = 3;
            this.btnPotencia.Text = "^";
            this.btnPotencia.UseVisualStyleBackColor = true;
            this.btnPotencia.Click += new System.EventHandler(this.btnPotencia_Click);
            // 
            // btnDivisao
            // 
            this.btnDivisao.Location = new System.Drawing.Point(97, 110);
            this.btnDivisao.Name = "btnDivisao";
            this.btnDivisao.Size = new System.Drawing.Size(75, 34);
            this.btnDivisao.TabIndex = 4;
            this.btnDivisao.Text = "/";
            this.btnDivisao.UseVisualStyleBackColor = true;
            this.btnDivisao.Click += new System.EventHandler(this.btnDivisao_Click);
            // 
            // btnMultiplicacao
            // 
            this.btnMultiplicacao.Location = new System.Drawing.Point(178, 110);
            this.btnMultiplicacao.Name = "btnMultiplicacao";
            this.btnMultiplicacao.Size = new System.Drawing.Size(75, 34);
            this.btnMultiplicacao.TabIndex = 5;
            this.btnMultiplicacao.Text = "*";
            this.btnMultiplicacao.UseVisualStyleBackColor = true;
            this.btnMultiplicacao.Click += new System.EventHandler(this.btnMultiplicacao_Click);
            // 
            // btnSubtracao
            // 
            this.btnSubtracao.Location = new System.Drawing.Point(259, 110);
            this.btnSubtracao.Name = "btnSubtracao";
            this.btnSubtracao.Size = new System.Drawing.Size(75, 34);
            this.btnSubtracao.TabIndex = 6;
            this.btnSubtracao.Text = "-";
            this.btnSubtracao.UseVisualStyleBackColor = true;
            this.btnSubtracao.Click += new System.EventHandler(this.btnSubtracao_Click);
            // 
            // btn7
            // 
            this.btn7.Location = new System.Drawing.Point(16, 150);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(75, 34);
            this.btn7.TabIndex = 7;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = true;
            this.btn7.Click += new System.EventHandler(this.btn7_Click);
            // 
            // btn8
            // 
            this.btn8.Location = new System.Drawing.Point(97, 150);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(75, 34);
            this.btn8.TabIndex = 8;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = true;
            this.btn8.Click += new System.EventHandler(this.btn8_Click);
            // 
            // btnAbreParenteses
            // 
            this.btnAbreParenteses.Location = new System.Drawing.Point(259, 270);
            this.btnAbreParenteses.Name = "btnAbreParenteses";
            this.btnAbreParenteses.Size = new System.Drawing.Size(75, 34);
            this.btnAbreParenteses.TabIndex = 9;
            this.btnAbreParenteses.Text = "(";
            this.btnAbreParenteses.UseVisualStyleBackColor = true;
            this.btnAbreParenteses.Click += new System.EventHandler(this.btnAbreParenteses_Click);
            // 
            // btnApagar
            // 
            this.btnApagar.Location = new System.Drawing.Point(178, 270);
            this.btnApagar.Name = "btnApagar";
            this.btnApagar.Size = new System.Drawing.Size(75, 34);
            this.btnApagar.TabIndex = 10;
            this.btnApagar.Text = "C";
            this.btnApagar.UseVisualStyleBackColor = true;
            this.btnApagar.Click += new System.EventHandler(this.btnApagar_Click);
            // 
            // btnIgual
            // 
            this.btnIgual.Location = new System.Drawing.Point(97, 270);
            this.btnIgual.Name = "btnIgual";
            this.btnIgual.Size = new System.Drawing.Size(75, 34);
            this.btnIgual.TabIndex = 11;
            this.btnIgual.Text = "=";
            this.btnIgual.UseVisualStyleBackColor = true;
            this.btnIgual.Click += new System.EventHandler(this.btnIgual_Click);
            // 
            // btn0
            // 
            this.btn0.Location = new System.Drawing.Point(16, 270);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(75, 34);
            this.btn0.TabIndex = 12;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = true;
            this.btn0.Click += new System.EventHandler(this.btn0_Click);
            // 
            // btnFechaParenteses
            // 
            this.btnFechaParenteses.Location = new System.Drawing.Point(259, 230);
            this.btnFechaParenteses.Name = "btnFechaParenteses";
            this.btnFechaParenteses.Size = new System.Drawing.Size(75, 34);
            this.btnFechaParenteses.TabIndex = 13;
            this.btnFechaParenteses.Text = ")";
            this.btnFechaParenteses.UseVisualStyleBackColor = true;
            this.btnFechaParenteses.Click += new System.EventHandler(this.btnFechaParenteses_Click);
            // 
            // btn3
            // 
            this.btn3.Location = new System.Drawing.Point(178, 230);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(75, 34);
            this.btn3.TabIndex = 14;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.btn3_Click);
            // 
            // btn2
            // 
            this.btn2.Location = new System.Drawing.Point(97, 230);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(75, 34);
            this.btn2.TabIndex = 15;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(16, 230);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(75, 34);
            this.btn1.TabIndex = 16;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // btn4
            // 
            this.btn4.Location = new System.Drawing.Point(16, 190);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(75, 34);
            this.btn4.TabIndex = 17;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.btn4_Click);
            // 
            // btn5
            // 
            this.btn5.Location = new System.Drawing.Point(97, 190);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(75, 34);
            this.btn5.TabIndex = 18;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = true;
            this.btn5.Click += new System.EventHandler(this.btn5_Click);
            // 
            // btn6
            // 
            this.btn6.Location = new System.Drawing.Point(178, 190);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(75, 34);
            this.btn6.TabIndex = 19;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = true;
            this.btn6.Click += new System.EventHandler(this.btn6_Click);
            // 
            // btnPonto
            // 
            this.btnPonto.Location = new System.Drawing.Point(259, 190);
            this.btnPonto.Name = "btnPonto";
            this.btnPonto.Size = new System.Drawing.Size(75, 34);
            this.btnPonto.TabIndex = 20;
            this.btnPonto.Text = ".";
            this.btnPonto.UseVisualStyleBackColor = true;
            this.btnPonto.Click += new System.EventHandler(this.btnPonto_Click);
            // 
            // btnAdicao
            // 
            this.btnAdicao.Location = new System.Drawing.Point(259, 150);
            this.btnAdicao.Name = "btnAdicao";
            this.btnAdicao.Size = new System.Drawing.Size(75, 34);
            this.btnAdicao.TabIndex = 21;
            this.btnAdicao.Text = "+";
            this.btnAdicao.UseVisualStyleBackColor = true;
            this.btnAdicao.Click += new System.EventHandler(this.btnAdicao_Click);
            // 
            // btn9
            // 
            this.btn9.Location = new System.Drawing.Point(178, 150);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(75, 34);
            this.btn9.TabIndex = 22;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = true;
            this.btn9.Click += new System.EventHandler(this.btn9_Click);
            // 
            // frmCalculadora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 315);
            this.Controls.Add(this.btn9);
            this.Controls.Add(this.btnAdicao);
            this.Controls.Add(this.btnPonto);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btnFechaParenteses);
            this.Controls.Add(this.btn0);
            this.Controls.Add(this.btnIgual);
            this.Controls.Add(this.btnApagar);
            this.Controls.Add(this.btnAbreParenteses);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.btnSubtracao);
            this.Controls.Add(this.btnMultiplicacao);
            this.Controls.Add(this.btnDivisao);
            this.Controls.Add(this.btnPotencia);
            this.Controls.Add(this.lblSequencia);
            this.Controls.Add(this.txtResultado);
            this.Controls.Add(this.txtVisor);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "frmCalculadora";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculadora Científica";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmCalculadora_FormClosed);
            this.Load += new System.EventHandler(this.frmCalculadora_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtVisor;
        private System.Windows.Forms.TextBox txtResultado;
        private System.Windows.Forms.Label lblSequencia;
        private System.Windows.Forms.Button btnPotencia;
        private System.Windows.Forms.Button btnDivisao;
        private System.Windows.Forms.Button btnMultiplicacao;
        private System.Windows.Forms.Button btnSubtracao;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btnAbreParenteses;
        private System.Windows.Forms.Button btnApagar;
        private System.Windows.Forms.Button btnIgual;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button btnFechaParenteses;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btnPonto;
        private System.Windows.Forms.Button btnAdicao;
        private System.Windows.Forms.Button btn9;
    }
}

