using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppFarmacia.View
{
    public partial class TelaPDV : Form
    {
        public int totalfinal = 0;
        public TelaPDV()
        {
            InitializeComponent();
        }

        private void btn_Neosaldina_Click(object sender, EventArgs e)
        {
            string registroNeosaldina = "0";
            txb_Codigo.Text = registroNeosaldina;
        }

        private void btn_Doril_Click(object sender, EventArgs e)
        {
            string registroDoril = "1";
            txb_Codigo.Text = registroDoril;
        }

        private void btn_Engov_Click(object sender, EventArgs e)
        {
            string registroEngov = "2";
            txb_Codigo.Text = registroEngov;
        }

        private void btn_Novalgina_Click(object sender, EventArgs e)
        {
            string registroNovalgina = "3";
            txb_Codigo.Text = registroNovalgina;
        }

        private void btn_Dipirona_Click(object sender, EventArgs e)
        {
            string registroDipirona = "4";
            txb_Codigo.Text = registroDipirona;
        }

        private void btn_Dorflex_Click(object sender, EventArgs e)
        {
            string registroDorflex = "5";
            txb_Codigo.Text = registroDorflex;
        }

        private void btn_Rivotril_Click(object sender, EventArgs e)
        {
            string registroRivotril = "6";
            txb_Codigo.Text = registroRivotril;
        }

        private void btn_Ducolax_Click(object sender, EventArgs e)
        {
            string registroDucolax = "7";
            txb_Codigo.Text = registroDucolax;
        }

        private void btn_Minilax_Click(object sender, EventArgs e)
        {
            string registroMinilax = "8";
            txb_Codigo.Text = registroMinilax;
        }

        private void btn_Adicionar_Click(object sender, EventArgs e)
        {
            int codigo = Convert.ToInt32(txb_Codigo.Text);
            int qtd = ((int)nud_Qtde.Value);

            string[] itens = { "Neosaldina", "Doril", "Engov", "Novalgina", "Dipirona", "Dorflex", "Rivotril", "Ducolax", "Minilax" };
            int[] array = { 20, 33, 20, 18, 5, 8, 28, 17, 50 };

            int total = qtd * array[codigo];
            totalfinal += total;

            dgv_Tabela.Rows.Add(itens[codigo], qtd, array[codigo], total);
            lbl_ValorTotalFinal.Text = "R$" + totalfinal.ToString() + ",00";
        }

        private void btn_Limpar_Click(object sender, EventArgs e)
        {
            txb_Codigo.Text = string.Empty;
            nud_Qtde.Value = 0;
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            lbl_ValorTotalFinal.Text = "R$ 00,00";
            txb_Codigo.Text = string.Empty;
            nud_Qtde.Value = 0;
            dgv_Tabela.Rows.Clear();
        }

        private void btn_ReceberFinalizar_Click(object sender, EventArgs e)
        {
            this.Hide();
            TelaNotaFiscal telaNotaFiscal = new TelaNotaFiscal(this);
            telaNotaFiscal.FormClosed += (s, args) => this.Close();
            telaNotaFiscal.Show();
        }
    }
}
