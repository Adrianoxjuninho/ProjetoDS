using ProjetoDS.dao;
using ProjetoDS.model;
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
    public partial class FrmFornecedor : Form
    {
        public FrmFornecedor()
        {
            InitializeComponent();
        }

        private void btncadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                Fornecedor obj = new Fornecedor();

                //Receber os dados
                obj.nome = txtnome.Text;
                obj.cnpj = txtCNPJ.Text;
                obj.bairro = txtBairro.Text;
                obj.telefone = txtTelefone.Text;
                obj.email = txtemail.Text;
                obj.endereco = txtEndereco.Text;
                obj.numero = int.Parse(txtNumero.Text);

                //Criar o objeto da classe FornecedorDAO
                FornecedorDAO fornecedorDAO = new FornecedorDAO();
                fornecedorDAO.cadastrar(obj);

                MessageBox.Show("Cadastrado com sucesso!");
            }
            catch (Exception erro)
            {
                MessageBox.Show("Aconteceu um erro" + erro);
            }
        }

        private void dgFornecedor_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtid.Text = dgFornecedor.CurrentRow.Cells[0].Value.ToString();
            txtnome.Text = dgFornecedor.CurrentRow.Cells[1].Value.ToString();
            txtCNPJ.Text = dgFornecedor.CurrentRow.Cells[2].Value.ToString();
            txtEndereco.Text = dgFornecedor.CurrentRow.Cells[3].Value.ToString();
            txtBairro.Text = dgFornecedor.CurrentRow.Cells[4].Value.ToString();
            txtCidade.Text = dgFornecedor.CurrentRow.Cells[5].Value.ToString();
            txtNumero.Text = dgFornecedor.CurrentRow.Cells[6].Value.ToString();
            txtTelefone.Text = dgFornecedor.CurrentRow.Cells[7].Value.ToString();
            txtemail.Text = dgFornecedor.CurrentRow.Cells[8].Value.ToString();
        }
    }
}
