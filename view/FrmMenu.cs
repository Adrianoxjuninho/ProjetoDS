using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoDS.view
{
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
        }

        private void cadastroDeProdutosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmProduto produto = new FrmProduto();
            produto.ShowDialog();
        }

        private void cadastroDeFornecedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmFornecedor fornecedor = new FrmFornecedor();
            fornecedor.ShowDialog();
        }

        private void cadatsroDeClientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frmclientes frmclientes = new Frmclientes();
            frmclientes.ShowDialog();
        }
<<<<<<< HEAD

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://x3solucaoemti.webnode.page/");
        }

        private void fornecedorToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
=======
>>>>>>> 07dd74b86e1a92c64cb1ebe65b6c2f24cc480416
    }
}
