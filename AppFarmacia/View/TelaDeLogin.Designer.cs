namespace AppFarmacia.View
{
    partial class TelaDeLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaDeLogin));
            lbl_Username = new Label();
            lbl_Password = new Label();
            pictureBox1 = new PictureBox();
            txb_Username = new TextBox();
            txb_Password = new TextBox();
            btn_Login = new Button();
            btn_Sair = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lbl_Username
            // 
            lbl_Username.AutoSize = true;
            lbl_Username.BackColor = Color.Transparent;
            lbl_Username.Font = new Font("Louis George Cafe", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_Username.ForeColor = SystemColors.Control;
            lbl_Username.Location = new Point(566, 138);
            lbl_Username.Name = "lbl_Username";
            lbl_Username.Size = new Size(109, 23);
            lbl_Username.TabIndex = 0;
            lbl_Username.Text = "Username";
            // 
            // lbl_Password
            // 
            lbl_Password.AutoSize = true;
            lbl_Password.BackColor = Color.Transparent;
            lbl_Password.Font = new Font("Louis George Cafe", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_Password.ForeColor = SystemColors.Control;
            lbl_Password.Location = new Point(566, 223);
            lbl_Password.Name = "lbl_Password";
            lbl_Password.Size = new Size(103, 23);
            lbl_Password.TabIndex = 1;
            lbl_Password.Text = "Password";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(12, 164);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(402, 130);
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // txb_Username
            // 
            txb_Username.Font = new Font("Louis George Cafe", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            txb_Username.Location = new Point(466, 176);
            txb_Username.Name = "txb_Username";
            txb_Username.Size = new Size(297, 32);
            txb_Username.TabIndex = 3;
            // 
            // txb_Password
            // 
            txb_Password.Font = new Font("Louis George Cafe", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            txb_Password.Location = new Point(466, 261);
            txb_Password.Name = "txb_Password";
            txb_Password.PasswordChar = '*';
            txb_Password.Size = new Size(297, 32);
            txb_Password.TabIndex = 4;
            // 
            // btn_Login
            // 
            btn_Login.BackColor = SystemColors.ButtonFace;
            btn_Login.Font = new Font("Louis George Cafe", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Login.Location = new Point(487, 308);
            btn_Login.Name = "btn_Login";
            btn_Login.Size = new Size(92, 36);
            btn_Login.TabIndex = 5;
            btn_Login.Text = "Login";
            btn_Login.UseVisualStyleBackColor = false;
            btn_Login.Click += btn_Login_Click;
            // 
            // btn_Sair
            // 
            btn_Sair.BackColor = SystemColors.ButtonFace;
            btn_Sair.Font = new Font("Louis George Cafe", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Sair.Location = new Point(657, 308);
            btn_Sair.Name = "btn_Sair";
            btn_Sair.Size = new Size(92, 36);
            btn_Sair.TabIndex = 6;
            btn_Sair.Text = "Sair";
            btn_Sair.UseVisualStyleBackColor = false;
            btn_Sair.Click += btn_Sair_Click;
            // 
            // TelaDeLogin
            // 
            AcceptButton = btn_Login;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_Sair);
            Controls.Add(btn_Login);
            Controls.Add(txb_Password);
            Controls.Add(txb_Username);
            Controls.Add(pictureBox1);
            Controls.Add(lbl_Password);
            Controls.Add(lbl_Username);
            DoubleBuffered = true;
            Name = "TelaDeLogin";
            Text = "TelaDeLogin";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_Username;
        private Label lbl_Password;
        private PictureBox pictureBox1;
        private TextBox txb_Username;
        private TextBox txb_Password;
        private Button btn_Login;
        private Button btn_Sair;
    }
}