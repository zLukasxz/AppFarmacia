namespace AppFarmacia.View
{
    partial class TelaPDV
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaPDV));
            btn_Neosaldina = new Button();
            btn_Doril = new Button();
            btn_Engov = new Button();
            btn_Novalgina = new Button();
            dgv_Tabela = new DataGridView();
            Produto = new DataGridViewTextBoxColumn();
            Qtde = new DataGridViewTextBoxColumn();
            Unitário = new DataGridViewTextBoxColumn();
            Total = new DataGridViewTextBoxColumn();
            btn_Dipirona = new Button();
            btn_Dorflex = new Button();
            btn_Rivotril = new Button();
            btn_Ducolax = new Button();
            btn_Minilax = new Button();
            btn_Adicionar = new Button();
            btn_Limpar = new Button();
            pictureBox1 = new PictureBox();
            btn_Cancelar = new Button();
            btn_ReceberFinalizar = new Button();
            txb_Codigo = new TextBox();
            nud_Qtde = new NumericUpDown();
            lbl_Codigo = new Label();
            lbl_Qtde = new Label();
            lbl_ValorTotalTexto = new Label();
            lbl_ValorTotalFinal = new Label();
            ((System.ComponentModel.ISupportInitialize)dgv_Tabela).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nud_Qtde).BeginInit();
            SuspendLayout();
            // 
            // btn_Neosaldina
            // 
            btn_Neosaldina.Font = new Font("Louis George Cafe", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Neosaldina.Location = new Point(12, 126);
            btn_Neosaldina.Name = "btn_Neosaldina";
            btn_Neosaldina.Size = new Size(75, 75);
            btn_Neosaldina.TabIndex = 0;
            btn_Neosaldina.Text = "Neosaldina";
            btn_Neosaldina.UseVisualStyleBackColor = true;
            btn_Neosaldina.Click += btn_Neosaldina_Click;
            // 
            // btn_Doril
            // 
            btn_Doril.Font = new Font("Louis George Cafe", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Doril.Location = new Point(93, 126);
            btn_Doril.Name = "btn_Doril";
            btn_Doril.Size = new Size(75, 75);
            btn_Doril.TabIndex = 1;
            btn_Doril.Text = "Doril";
            btn_Doril.UseVisualStyleBackColor = true;
            btn_Doril.Click += btn_Doril_Click;
            // 
            // btn_Engov
            // 
            btn_Engov.Font = new Font("Louis George Cafe", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Engov.Location = new Point(174, 126);
            btn_Engov.Name = "btn_Engov";
            btn_Engov.Size = new Size(75, 75);
            btn_Engov.TabIndex = 2;
            btn_Engov.Text = "Engov";
            btn_Engov.UseVisualStyleBackColor = true;
            btn_Engov.Click += btn_Engov_Click;
            // 
            // btn_Novalgina
            // 
            btn_Novalgina.Font = new Font("Louis George Cafe", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Novalgina.Location = new Point(12, 207);
            btn_Novalgina.Name = "btn_Novalgina";
            btn_Novalgina.Size = new Size(75, 75);
            btn_Novalgina.TabIndex = 3;
            btn_Novalgina.Text = "Novalgina";
            btn_Novalgina.UseVisualStyleBackColor = true;
            btn_Novalgina.Click += btn_Novalgina_Click;
            // 
            // dgv_Tabela
            // 
            dgv_Tabela.BackgroundColor = SystemColors.Control;
            dgv_Tabela.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_Tabela.Columns.AddRange(new DataGridViewColumn[] { Produto, Qtde, Unitário, Total });
            dgv_Tabela.Location = new Point(337, 164);
            dgv_Tabela.Name = "dgv_Tabela";
            dgv_Tabela.RowHeadersVisible = false;
            dgv_Tabela.RowTemplate.Height = 25;
            dgv_Tabela.Size = new Size(403, 150);
            dgv_Tabela.TabIndex = 4;
            // 
            // Produto
            // 
            Produto.HeaderText = "Produto";
            Produto.Name = "Produto";
            // 
            // Qtde
            // 
            Qtde.HeaderText = "Qtde";
            Qtde.Name = "Qtde";
            // 
            // Unitário
            // 
            Unitário.HeaderText = "Unitário";
            Unitário.Name = "Unitário";
            // 
            // Total
            // 
            Total.HeaderText = "Total";
            Total.Name = "Total";
            // 
            // btn_Dipirona
            // 
            btn_Dipirona.Font = new Font("Louis George Cafe", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Dipirona.Location = new Point(93, 207);
            btn_Dipirona.Name = "btn_Dipirona";
            btn_Dipirona.Size = new Size(75, 75);
            btn_Dipirona.TabIndex = 5;
            btn_Dipirona.Text = "Dipirona";
            btn_Dipirona.UseVisualStyleBackColor = true;
            btn_Dipirona.Click += btn_Dipirona_Click;
            // 
            // btn_Dorflex
            // 
            btn_Dorflex.Font = new Font("Louis George Cafe", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Dorflex.Location = new Point(174, 207);
            btn_Dorflex.Name = "btn_Dorflex";
            btn_Dorflex.Size = new Size(75, 75);
            btn_Dorflex.TabIndex = 6;
            btn_Dorflex.Text = "Dorflex";
            btn_Dorflex.UseVisualStyleBackColor = true;
            btn_Dorflex.Click += btn_Dorflex_Click;
            // 
            // btn_Rivotril
            // 
            btn_Rivotril.Font = new Font("Louis George Cafe", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Rivotril.Location = new Point(12, 288);
            btn_Rivotril.Name = "btn_Rivotril";
            btn_Rivotril.Size = new Size(75, 75);
            btn_Rivotril.TabIndex = 7;
            btn_Rivotril.Text = "Rivotril";
            btn_Rivotril.UseVisualStyleBackColor = true;
            btn_Rivotril.Click += btn_Rivotril_Click;
            // 
            // btn_Ducolax
            // 
            btn_Ducolax.Font = new Font("Louis George Cafe", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Ducolax.Location = new Point(93, 288);
            btn_Ducolax.Name = "btn_Ducolax";
            btn_Ducolax.Size = new Size(75, 75);
            btn_Ducolax.TabIndex = 8;
            btn_Ducolax.Text = "Ducolax";
            btn_Ducolax.UseVisualStyleBackColor = true;
            btn_Ducolax.Click += btn_Ducolax_Click;
            // 
            // btn_Minilax
            // 
            btn_Minilax.Font = new Font("Louis George Cafe", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Minilax.Location = new Point(174, 288);
            btn_Minilax.Name = "btn_Minilax";
            btn_Minilax.Size = new Size(75, 75);
            btn_Minilax.TabIndex = 9;
            btn_Minilax.Text = "Minilax";
            btn_Minilax.UseVisualStyleBackColor = true;
            btn_Minilax.Click += btn_Minilax_Click;
            // 
            // btn_Adicionar
            // 
            btn_Adicionar.Font = new Font("Louis George Cafe", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Adicionar.Location = new Point(337, 126);
            btn_Adicionar.Name = "btn_Adicionar";
            btn_Adicionar.Size = new Size(110, 32);
            btn_Adicionar.TabIndex = 10;
            btn_Adicionar.Text = "Adicionar";
            btn_Adicionar.UseVisualStyleBackColor = true;
            btn_Adicionar.Click += btn_Adicionar_Click;
            // 
            // btn_Limpar
            // 
            btn_Limpar.Font = new Font("Louis George Cafe", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Limpar.Location = new Point(630, 126);
            btn_Limpar.Name = "btn_Limpar";
            btn_Limpar.Size = new Size(110, 32);
            btn_Limpar.TabIndex = 11;
            btn_Limpar.Text = "Limpar";
            btn_Limpar.UseVisualStyleBackColor = true;
            btn_Limpar.Click += btn_Limpar_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(237, 74);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 12;
            pictureBox1.TabStop = false;
            // 
            // btn_Cancelar
            // 
            btn_Cancelar.Font = new Font("Louis George Cafe", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Cancelar.Location = new Point(337, 320);
            btn_Cancelar.Name = "btn_Cancelar";
            btn_Cancelar.Size = new Size(103, 56);
            btn_Cancelar.TabIndex = 13;
            btn_Cancelar.Text = "Cancelar";
            btn_Cancelar.UseVisualStyleBackColor = true;
            btn_Cancelar.Click += btn_Cancelar_Click;
            // 
            // btn_ReceberFinalizar
            // 
            btn_ReceberFinalizar.Font = new Font("Louis George Cafe", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btn_ReceberFinalizar.Location = new Point(637, 320);
            btn_ReceberFinalizar.Name = "btn_ReceberFinalizar";
            btn_ReceberFinalizar.Size = new Size(103, 56);
            btn_ReceberFinalizar.TabIndex = 14;
            btn_ReceberFinalizar.Text = "Receber e Finalizar";
            btn_ReceberFinalizar.UseVisualStyleBackColor = true;
            btn_ReceberFinalizar.Click += btn_ReceberFinalizar_Click;
            // 
            // txb_Codigo
            // 
            txb_Codigo.Font = new Font("Louis George Cafe", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txb_Codigo.Location = new Point(337, 91);
            txb_Codigo.Name = "txb_Codigo";
            txb_Codigo.Size = new Size(110, 29);
            txb_Codigo.TabIndex = 15;
            // 
            // nud_Qtde
            // 
            nud_Qtde.Font = new Font("Louis George Cafe", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            nud_Qtde.Location = new Point(630, 91);
            nud_Qtde.Name = "nud_Qtde";
            nud_Qtde.Size = new Size(110, 29);
            nud_Qtde.TabIndex = 16;
            // 
            // lbl_Codigo
            // 
            lbl_Codigo.AutoSize = true;
            lbl_Codigo.BackColor = Color.Transparent;
            lbl_Codigo.Font = new Font("Louis George Cafe", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_Codigo.ForeColor = Color.WhiteSmoke;
            lbl_Codigo.Location = new Point(359, 69);
            lbl_Codigo.Name = "lbl_Codigo";
            lbl_Codigo.Size = new Size(60, 17);
            lbl_Codigo.TabIndex = 17;
            lbl_Codigo.Text = "Código";
            // 
            // lbl_Qtde
            // 
            lbl_Qtde.AutoSize = true;
            lbl_Qtde.BackColor = Color.Transparent;
            lbl_Qtde.Font = new Font("Louis George Cafe", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_Qtde.ForeColor = Color.WhiteSmoke;
            lbl_Qtde.Location = new Point(660, 69);
            lbl_Qtde.Name = "lbl_Qtde";
            lbl_Qtde.Size = new Size(44, 17);
            lbl_Qtde.TabIndex = 18;
            lbl_Qtde.Text = "Qtde";
            // 
            // lbl_ValorTotalTexto
            // 
            lbl_ValorTotalTexto.AutoSize = true;
            lbl_ValorTotalTexto.BackColor = Color.Transparent;
            lbl_ValorTotalTexto.Font = new Font("Louis George Cafe", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_ValorTotalTexto.ForeColor = Color.WhiteSmoke;
            lbl_ValorTotalTexto.Location = new Point(471, 31);
            lbl_ValorTotalTexto.Name = "lbl_ValorTotalTexto";
            lbl_ValorTotalTexto.Size = new Size(131, 27);
            lbl_ValorTotalTexto.TabIndex = 19;
            lbl_ValorTotalTexto.Text = "Valor Total";
            // 
            // lbl_ValorTotalFinal
            // 
            lbl_ValorTotalFinal.AutoSize = true;
            lbl_ValorTotalFinal.BackColor = Color.Transparent;
            lbl_ValorTotalFinal.Font = new Font("Louis George Cafe", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_ValorTotalFinal.ForeColor = Color.WhiteSmoke;
            lbl_ValorTotalFinal.Location = new Point(476, 57);
            lbl_ValorTotalFinal.Name = "lbl_ValorTotalFinal";
            lbl_ValorTotalFinal.Size = new Size(120, 27);
            lbl_ValorTotalFinal.TabIndex = 20;
            lbl_ValorTotalFinal.Text = "R$ 00,00";
            // 
            // TelaPDV
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(lbl_ValorTotalFinal);
            Controls.Add(lbl_ValorTotalTexto);
            Controls.Add(lbl_Qtde);
            Controls.Add(lbl_Codigo);
            Controls.Add(nud_Qtde);
            Controls.Add(txb_Codigo);
            Controls.Add(btn_ReceberFinalizar);
            Controls.Add(btn_Cancelar);
            Controls.Add(pictureBox1);
            Controls.Add(btn_Limpar);
            Controls.Add(btn_Adicionar);
            Controls.Add(btn_Minilax);
            Controls.Add(btn_Ducolax);
            Controls.Add(btn_Rivotril);
            Controls.Add(btn_Dorflex);
            Controls.Add(btn_Dipirona);
            Controls.Add(dgv_Tabela);
            Controls.Add(btn_Novalgina);
            Controls.Add(btn_Engov);
            Controls.Add(btn_Doril);
            Controls.Add(btn_Neosaldina);
            DoubleBuffered = true;
            Name = "TelaPDV";
            Text = "TelaPDV";
            ((System.ComponentModel.ISupportInitialize)dgv_Tabela).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)nud_Qtde).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_Neosaldina;
        private Button btn_Doril;
        private Button btn_Engov;
        private Button btn_Novalgina;
        private DataGridViewTextBoxColumn Produto;
        private DataGridViewTextBoxColumn Qtde;
        private DataGridViewTextBoxColumn Unitário;
        private DataGridViewTextBoxColumn Total;
        private Button btn_Dipirona;
        private Button btn_Dorflex;
        private Button btn_Rivotril;
        private Button btn_Ducolax;
        private Button btn_Minilax;
        private Button btn_Adicionar;
        private Button btn_Limpar;
        private PictureBox pictureBox1;
        private Button btn_Cancelar;
        private Button btn_ReceberFinalizar;
        private TextBox txb_Codigo;
        private NumericUpDown nud_Qtde;
        private Label lbl_Codigo;
        private Label lbl_Qtde;
        private Label lbl_ValorTotalTexto;
        private Label lbl_ValorTotalFinal;
        public DataGridView dgv_Tabela;
    }
}