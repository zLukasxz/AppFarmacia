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
    public partial class TelaNotaFiscal : Form
    {
        TelaPDV tela;
        public TelaNotaFiscal(TelaPDV telaPDV)
        {
            InitializeComponent();
            tela = telaPDV;
        }

        private void TelaNotaFiscal_Load(object sender, EventArgs e)
        {
            lbl_TotalFinalFiscal.Text = "R$" + Convert.ToString(tela.totalfinal) + ",00";
            lbl_Data.Text = DateTime.Now.ToString();

            for (int i = 0; i < tela.dgv_Tabela.Rows.Count - 1; i++)
            {
                lbl_Texto.Text += "\nProduto: " + tela.dgv_Tabela.Rows[i].Cells[0].Value.ToString() +
                    " - Quantidade: " + tela.dgv_Tabela.Rows[i].Cells[1].Value.ToString() +
                    " - Valor Unitário: R$" + tela.dgv_Tabela.Rows[i].Cells[2].Value.ToString() +
                    ",00 - Valor Total: R$" + tela.dgv_Tabela.Rows[i].Cells[3].Value.ToString() + ",00";
            }
        }
    }
}
