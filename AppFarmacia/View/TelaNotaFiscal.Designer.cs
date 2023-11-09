namespace AppFarmacia.View
{
    partial class TelaNotaFiscal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaNotaFiscal));
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            lbl_Data = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            lbl_TotalFinalFiscal = new Label();
            label10 = new Label();
            lbl_Texto = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(224, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(316, 100);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Louis George Cafe", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(255, 115);
            label1.Name = "label1";
            label1.Size = new Size(255, 21);
            label1.TabIndex = 1;
            label1.Text = "NeoQuímica Farmácia LTDA";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Louis George Cafe", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(253, 145);
            label2.Name = "label2";
            label2.Size = new Size(258, 17);
            label2.TabIndex = 2;
            label2.Text = "Rua Corinthans, 1910, Itaquera - SP ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Louis George Cafe", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(280, 172);
            label3.Name = "label3";
            label3.Size = new Size(205, 17);
            label3.TabIndex = 3;
            label3.Text = "CNPJ: 04.072.012/0001-00";
            // 
            // lbl_Data
            // 
            lbl_Data.AutoSize = true;
            lbl_Data.Font = new Font("Louis George Cafe", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_Data.Location = new Point(167, 201);
            lbl_Data.Name = "lbl_Data";
            lbl_Data.Size = new Size(160, 17);
            lbl_Data.TabIndex = 4;
            lbl_Data.Text = "00/00/0000 11:57:28";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Louis George Cafe", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(339, 201);
            label5.Name = "label5";
            label5.Size = new Size(48, 17);
            label5.TabIndex = 5;
            label5.Text = "161212";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Louis George Cafe", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(399, 201);
            label6.Name = "label6";
            label6.Size = new Size(79, 17);
            label6.TabIndex = 6;
            label6.Text = "CCF 0001";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Louis George Cafe", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(490, 201);
            label7.Name = "label7";
            label7.Size = new Size(87, 17);
            label7.TabIndex = 7;
            label7.Text = "COD: 0001";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Louis George Cafe", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(263, 383);
            label8.Name = "label8";
            label8.Size = new Size(70, 21);
            label8.TabIndex = 8;
            label8.Text = "TOTAL:";
            // 
            // lbl_TotalFinalFiscal
            // 
            lbl_TotalFinalFiscal.AutoSize = true;
            lbl_TotalFinalFiscal.Font = new Font("Louis George Cafe", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_TotalFinalFiscal.Location = new Point(414, 383);
            lbl_TotalFinalFiscal.Name = "lbl_TotalFinalFiscal";
            lbl_TotalFinalFiscal.Size = new Size(89, 21);
            lbl_TotalFinalFiscal.TabIndex = 9;
            lbl_TotalFinalFiscal.Text = "R$ 00,00";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Louis George Cafe", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(274, 404);
            label10.Name = "label10";
            label10.Size = new Size(217, 23);
            label10.TabIndex = 10;
            label10.Text = "Pagamento Realizado";
            // 
            // lbl_Texto
            // 
            lbl_Texto.Font = new Font("Louis George Cafe", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_Texto.Location = new Point(92, 218);
            lbl_Texto.Name = "lbl_Texto";
            lbl_Texto.Size = new Size(599, 144);
            lbl_Texto.TabIndex = 11;
            // 
            // TelaNotaFiscal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lbl_Texto);
            Controls.Add(label10);
            Controls.Add(lbl_TotalFinalFiscal);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(lbl_Data);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "TelaNotaFiscal";
            Text = "TelaNotaFiscal";
            Load += TelaNotaFiscal_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label lbl_Data;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label lbl_TotalFinalFiscal;
        private Label label10;
        private Label lbl_Texto;
    }
}