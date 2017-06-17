namespace _16185_16195_Projeto4ED
{
    partial class frmCaminhos
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
            this.rbRecursao = new System.Windows.Forms.RadioButton();
            this.rbBacktracking = new System.Windows.Forms.RadioButton();
            this.rbDjikstra = new System.Windows.Forms.RadioButton();
            this.lsbCaminhos = new System.Windows.Forms.ListBox();
            this.btnAcharCaminhos = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbCidadeOrigem = new System.Windows.Forms.ComboBox();
            this.cbCidadeDestino = new System.Windows.Forms.ComboBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.dgvAdj = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdj)).BeginInit();
            this.SuspendLayout();
            // 
            // rbRecursao
            // 
            this.rbRecursao.AutoSize = true;
            this.rbRecursao.Location = new System.Drawing.Point(16, 8);
            this.rbRecursao.Margin = new System.Windows.Forms.Padding(4);
            this.rbRecursao.Name = "rbRecursao";
            this.rbRecursao.Size = new System.Drawing.Size(87, 21);
            this.rbRecursao.TabIndex = 1;
            this.rbRecursao.TabStop = true;
            this.rbRecursao.Text = "Recursão";
            this.rbRecursao.UseVisualStyleBackColor = true;
            this.rbRecursao.Click += new System.EventHandler(this.rbRecursao_Click);
            // 
            // rbBacktracking
            // 
            this.rbBacktracking.AutoSize = true;
            this.rbBacktracking.Location = new System.Drawing.Point(111, 8);
            this.rbBacktracking.Margin = new System.Windows.Forms.Padding(4);
            this.rbBacktracking.Name = "rbBacktracking";
            this.rbBacktracking.Size = new System.Drawing.Size(107, 21);
            this.rbBacktracking.TabIndex = 2;
            this.rbBacktracking.TabStop = true;
            this.rbBacktracking.Text = "Backtracking";
            this.rbBacktracking.UseVisualStyleBackColor = true;
            this.rbBacktracking.Click += new System.EventHandler(this.rbBacktracking_Click);
            // 
            // rbDjikstra
            // 
            this.rbDjikstra.AutoSize = true;
            this.rbDjikstra.Location = new System.Drawing.Point(226, 8);
            this.rbDjikstra.Margin = new System.Windows.Forms.Padding(4);
            this.rbDjikstra.Name = "rbDjikstra";
            this.rbDjikstra.Size = new System.Drawing.Size(73, 21);
            this.rbDjikstra.TabIndex = 3;
            this.rbDjikstra.TabStop = true;
            this.rbDjikstra.Text = "Djikstra";
            this.rbDjikstra.UseVisualStyleBackColor = true;
            this.rbDjikstra.Click += new System.EventHandler(this.rbDjikstra_Click);
            // 
            // lsbCaminhos
            // 
            this.lsbCaminhos.FormattingEnabled = true;
            this.lsbCaminhos.ItemHeight = 16;
            this.lsbCaminhos.Location = new System.Drawing.Point(510, 158);
            this.lsbCaminhos.Name = "lsbCaminhos";
            this.lsbCaminhos.Size = new System.Drawing.Size(260, 212);
            this.lsbCaminhos.TabIndex = 4;
            // 
            // btnAcharCaminhos
            // 
            this.btnAcharCaminhos.Location = new System.Drawing.Point(510, 128);
            this.btnAcharCaminhos.Name = "btnAcharCaminhos";
            this.btnAcharCaminhos.Size = new System.Drawing.Size(260, 24);
            this.btnAcharCaminhos.TabIndex = 5;
            this.btnAcharCaminhos.Text = "Achar caminhos";
            this.btnAcharCaminhos.UseVisualStyleBackColor = true;
            this.btnAcharCaminhos.Click += new System.EventHandler(this.btnAcharCaminhos_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(510, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Cidade de origem:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(510, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Cidade de destino:";
            // 
            // cbCidadeOrigem
            // 
            this.cbCidadeOrigem.FormattingEnabled = true;
            this.cbCidadeOrigem.Location = new System.Drawing.Point(649, 56);
            this.cbCidadeOrigem.Name = "cbCidadeOrigem";
            this.cbCidadeOrigem.Size = new System.Drawing.Size(121, 24);
            this.cbCidadeOrigem.TabIndex = 8;
            // 
            // cbCidadeDestino
            // 
            this.cbCidadeDestino.FormattingEnabled = true;
            this.cbCidadeDestino.Location = new System.Drawing.Point(649, 91);
            this.cbCidadeDestino.Name = "cbCidadeDestino";
            this.cbCidadeDestino.Size = new System.Drawing.Size(121, 24);
            this.cbCidadeDestino.TabIndex = 9;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(649, 8);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(121, 42);
            this.btnAdd.TabIndex = 11;
            this.btnAdd.Text = "Adicionar Cidades / Rotas";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.button1_Click);
            // 
            // dgvAdj
            // 
            this.dgvAdj.AllowUserToAddRows = false;
            this.dgvAdj.AllowUserToDeleteRows = false;
            this.dgvAdj.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAdj.Location = new System.Drawing.Point(12, 36);
            this.dgvAdj.Name = "dgvAdj";
            this.dgvAdj.ReadOnly = true;
            this.dgvAdj.Size = new System.Drawing.Size(491, 334);
            this.dgvAdj.TabIndex = 12;
            // 
            // frmCaminhos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 385);
            this.Controls.Add(this.dgvAdj);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.cbCidadeDestino);
            this.Controls.Add(this.cbCidadeOrigem);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAcharCaminhos);
            this.Controls.Add(this.lsbCaminhos);
            this.Controls.Add(this.rbDjikstra);
            this.Controls.Add(this.rbBacktracking);
            this.Controls.Add(this.rbRecursao);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmCaminhos";
            this.Text = "Achar caminhos entre cidades";
            this.Load += new System.EventHandler(this.frmCaminhos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdj)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RadioButton rbRecursao;
        private System.Windows.Forms.RadioButton rbBacktracking;
        private System.Windows.Forms.RadioButton rbDjikstra;
        private System.Windows.Forms.ListBox lsbCaminhos;
        private System.Windows.Forms.Button btnAcharCaminhos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbCidadeOrigem;
        private System.Windows.Forms.ComboBox cbCidadeDestino;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridView dgvAdj;
    }
}

