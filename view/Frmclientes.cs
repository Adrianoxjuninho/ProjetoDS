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
    public partial class Frmclientes : Form
    {
        public Frmclientes()
        {
            InitializeComponent();
        }
        #region Cadastrar 
        private void btncadastrar_Click(object sender, EventArgs e)
        {
            try{
                Cliente obj = new Cliente();

                //Receber os dados dos campos 
                obj.nome = txtnome.Text;
                obj.email = txtemail.Text;
                obj.senha = txtsenha.Text;
                obj.sexo = cbsexo.Text;

                //Criar obejto da classe ClienteDAO
                ClienteDAO dao = new ClienteDAO();
                dao.cadastrar(obj);

                MessageBox.Show("Cadastrado com sucesso!");

            }
            catch(Exception erro)

        {
                MessageBox.Show("Aconteceu um erro" + erro);
        }
            
        }
        #endregion
        private void Frmclientes_Activated(object sender, EventArgs e)
        {
            ClienteDAO dao = new ClienteDAO();
            dgCliente.DataSource = dao.ListarTodosClientes();
        }

        #region Alterar cadastro 
        private void btnAlterar_Click(object sender, EventArgs e)
        {
            try
            {
                Cliente obj = new Cliente();

                //Receber os dados dos campos 
                obj.nome = txtnome.Text;
                obj.email = txtemail.Text;
                obj.senha = txtsenha.Text;
                obj.sexo = cbsexo.Text;

                obj.id = int.Parse(txtid.Text);

                //Criar obejto da classe ClienteDAO
                ClienteDAO dao = new ClienteDAO();
                dao.alterar(obj);

            }
            catch (Exception erro)

            {
                MessageBox.Show("Aconteceu um erro" + erro);
            }
        }
        #endregion
        #region Excluir cadastro
        private void btnExcluir_Click(object sender, EventArgs e)
        {
            Cliente obj = new Cliente();

            obj.id = int.Parse(txtid.Text);

            ClienteDAO dAO = new ClienteDAO();
            dAO.excluir(obj);

            dgCliente.DataSource = dAO.ListarTodosClientes();
        }
        #endregion
        private void dgCliente_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtid.Text = dgCliente.CurrentRow.Cells[0].Value.ToString();
            txtnome.Text = dgCliente.CurrentRow.Cells[1].Value.ToString();
            txtemail.Text = dgCliente.CurrentRow.Cells[2].Value.ToString();
            txtsenha.Text = dgCliente.CurrentRow.Cells[3].Value.ToString();
            cbsexo.Text = dgCliente.CurrentRow.Cells[4].Value.ToString();
        }

        private void Frmclientes_Load(object sender, EventArgs e)
        {
            txtid.Text = dgCliente.CurrentRow.Cells[0].Value.ToString();
            txtnome.Text = dgCliente.CurrentRow.Cells[1].Value.ToString();
            txtemail.Text = dgCliente.CurrentRow.Cells[2].Value.ToString();
            txtsenha.Text = dgCliente.CurrentRow.Cells[3].Value.ToString();
            cbsexo.Text = dgCliente.CurrentRow.Cells[4].Value.ToString();
        }
    }
}
