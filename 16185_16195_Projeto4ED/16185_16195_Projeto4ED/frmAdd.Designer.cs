namespace _16185_16195_Projeto4ED
{
    partial class frmAdd
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tpAdicionar = new System.Windows.Forms.TabPage();
            this.btnSalvarCidades = new System.Windows.Forms.Button();
            this.btnSalvarCaminhos = new System.Windows.Forms.Button();
            this.gbAddRotas = new System.Windows.Forms.GroupBox();
            this.btnAddCaminho = new System.Windows.Forms.Button();
            this.txtPeso = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cbAddDestino = new System.Windows.Forms.ComboBox();
            this.cbAddOrigem = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.gbAddCidades = new System.Windows.Forms.GroupBox();
            this.btnAdicionarCidade = new System.Windows.Forms.Button();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pnlArvore = new System.Windows.Forms.Panel();
            this.tabControl1.SuspendLayout();
            this.tpAdicionar.SuspendLayout();
            this.gbAddRotas.SuspendLayout();
            this.gbAddCidades.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tpAdicionar);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(884, 562);
            this.tabControl1.TabIndex = 0;
            // 
            // tpAdicionar
            // 
            this.tpAdicionar.Controls.Add(this.btnSalvarCidades);
            this.tpAdicionar.Controls.Add(this.btnSalvarCaminhos);
            this.tpAdicionar.Controls.Add(this.gbAddRotas);
            this.tpAdicionar.Controls.Add(this.gbAddCidades);
            this.tpAdicionar.Location = new System.Drawing.Point(4, 22);
            this.tpAdicionar.Name = "tpAdicionar";
            this.tpAdicionar.Padding = new System.Windows.Forms.Padding(3);
            this.tpAdicionar.Size = new System.Drawing.Size(876, 536);
            this.tpAdicionar.TabIndex = 1;
            this.tpAdicionar.Text = "Adicionar Cidades/Rotas";
            this.tpAdicionar.UseVisualStyleBackColor = true;
            // 
            // btnSalvarCidades
            // 
            this.btnSalvarCidades.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSalvarCidades.Location = new System.Drawing.Point(462, 452);
            this.btnSalvarCidades.Name = "btnSalvarCidades";
            this.btnSalvarCidades.Size = new System.Drawing.Size(164, 65);
            this.btnSalvarCidades.TabIndex = 14;
            this.btnSalvarCidades.Text = "Salvar Arquivo Cidades";
            this.btnSalvarCidades.UseVisualStyleBackColor = true;
            this.btnSalvarCidades.Click += new System.EventHandler(this.btnSalvarCidades_Click);
            // 
            // btnSalvarCaminhos
            // 
            this.btnSalvarCaminhos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSalvarCaminhos.Location = new System.Drawing.Point(704, 452);
            this.btnSalvarCaminhos.Name = "btnSalvarCaminhos";
            this.btnSalvarCaminhos.Size = new System.Drawing.Size(164, 65);
            this.btnSalvarCaminhos.TabIndex = 12;
            this.btnSalvarCaminhos.Text = "Salvar Arquivo Caminhos";
            this.btnSalvarCaminhos.UseVisualStyleBackColor = true;
            this.btnSalvarCaminhos.Click += new System.EventHandler(this.btnSalvarCaminhos_Click);
            // 
            // gbAddRotas
            // 
            this.gbAddRotas.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbAddRotas.Controls.Add(this.btnAddCaminho);
            this.gbAddRotas.Controls.Add(this.txtPeso);
            this.gbAddRotas.Controls.Add(this.label9);
            this.gbAddRotas.Controls.Add(this.cbAddDestino);
            this.gbAddRotas.Controls.Add(this.cbAddOrigem);
            this.gbAddRotas.Controls.Add(this.label8);
            this.gbAddRotas.Controls.Add(this.label7);
            this.gbAddRotas.Location = new System.Drawing.Point(462, 6);
            this.gbAddRotas.Name = "gbAddRotas";
            this.gbAddRotas.Size = new System.Drawing.Size(406, 422);
            this.gbAddRotas.TabIndex = 1;
            this.gbAddRotas.TabStop = false;
            this.gbAddRotas.Text = "Adicionar Rotas";
            // 
            // btnAddCaminho
            // 
            this.btnAddCaminho.Location = new System.Drawing.Point(275, 136);
            this.btnAddCaminho.Name = "btnAddCaminho";
            this.btnAddCaminho.Size = new System.Drawing.Size(125, 28);
            this.btnAddCaminho.TabIndex = 10;
            this.btnAddCaminho.Text = "Adicionar Caminho";
            this.btnAddCaminho.UseVisualStyleBackColor = true;
            this.btnAddCaminho.Click += new System.EventHandler(this.btnAddRota_Click);
            // 
            // txtPeso
            // 
            this.txtPeso.Location = new System.Drawing.Point(100, 141);
            this.txtPeso.Name = "txtPeso";
            this.txtPeso.Size = new System.Drawing.Size(163, 20);
            this.txtPeso.TabIndex = 7;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(15, 144);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(31, 13);
            this.label9.TabIndex = 4;
            this.label9.Text = "Peso";
            // 
            // cbAddDestino
            // 
            this.cbAddDestino.FormattingEnabled = true;
            this.cbAddDestino.Location = new System.Drawing.Point(100, 75);
            this.cbAddDestino.Name = "cbAddDestino";
            this.cbAddDestino.Size = new System.Drawing.Size(300, 21);
            this.cbAddDestino.TabIndex = 3;
            // 
            // cbAddOrigem
            // 
            this.cbAddOrigem.FormattingEnabled = true;
            this.cbAddOrigem.Location = new System.Drawing.Point(100, 44);
            this.cbAddOrigem.Name = "cbAddOrigem";
            this.cbAddOrigem.Size = new System.Drawing.Size(300, 21);
            this.cbAddOrigem.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(15, 78);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "Cidade Destino";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 47);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Cidade Origem";
            // 
            // gbAddCidades
            // 
            this.gbAddCidades.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbAddCidades.Controls.Add(this.pnlArvore);
            this.gbAddCidades.Controls.Add(this.btnAdicionarCidade);
            this.gbAddCidades.Controls.Add(this.txtNome);
            this.gbAddCidades.Controls.Add(this.label4);
            this.gbAddCidades.Location = new System.Drawing.Point(8, 6);
            this.gbAddCidades.Name = "gbAddCidades";
            this.gbAddCidades.Size = new System.Drawing.Size(433, 522);
            this.gbAddCidades.TabIndex = 0;
            this.gbAddCidades.TabStop = false;
            this.gbAddCidades.Text = "Adicionar Cidades";
            // 
            // btnAdicionarCidade
            // 
            this.btnAdicionarCidade.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdicionarCidade.Location = new System.Drawing.Point(256, 40);
            this.btnAdicionarCidade.Name = "btnAdicionarCidade";
            this.btnAdicionarCidade.Size = new System.Drawing.Size(129, 26);
            this.btnAdicionarCidade.TabIndex = 6;
            this.btnAdicionarCidade.Text = "Adicionar cidade";
            this.btnAdicionarCidade.UseVisualStyleBackColor = true;
            this.btnAdicionarCidade.Click += new System.EventHandler(this.btnAdicionarCidade_Click);
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(63, 44);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(155, 20);
            this.txtNome.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Nome";
            // 
            // pnlArvore
            // 
            this.pnlArvore.Location = new System.Drawing.Point(9, 78);
            this.pnlArvore.Name = "pnlArvore";
            this.pnlArvore.Size = new System.Drawing.Size(418, 433);
            this.pnlArvore.TabIndex = 7;
            this.pnlArvore.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlArvore_Paint);
            // 
            // frmAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 562);
            this.Controls.Add(this.tabControl1);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(900, 601);
            this.Name = "frmAdd";
            this.Text = "Caminhos de Trem";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmAdd_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tpAdicionar.ResumeLayout(false);
            this.gbAddRotas.ResumeLayout(false);
            this.gbAddRotas.PerformLayout();
            this.gbAddCidades.ResumeLayout(false);
            this.gbAddCidades.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tpAdicionar;
        private System.Windows.Forms.GroupBox gbAddRotas;
        private System.Windows.Forms.Button btnAddCaminho;
        private System.Windows.Forms.TextBox txtPeso;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cbAddDestino;
        private System.Windows.Forms.ComboBox cbAddOrigem;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox gbAddCidades;
        private System.Windows.Forms.Button btnAdicionarCidade;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSalvarCaminhos;
        private System.Windows.Forms.Button btnSalvarCidades;
        private System.Windows.Forms.Panel pnlArvore;
    }
}

