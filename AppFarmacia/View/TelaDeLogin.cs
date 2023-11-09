using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppFarmacia.View
{
    public partial class TelaDeLogin : Form
    {
        public TelaDeLogin()
        {
            InitializeComponent();
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            string username = txb_Username.Text;
            string password = txb_Password.Text;

            if (username == "admin" && password == "123")
            {
                this.Hide();
                TelaDeMenu Menu = new TelaDeMenu();
                Menu.FormClosed += (s, args) => this.Close();
                Menu.Show();
            }
            else
            {
                MessageBox.Show("Credenciais incorretas.");
            }
        }

        private void btn_Sair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
