﻿using ProjetoDS.dao;
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
    public partial class FrmProduto : Form
    {
        public FrmProduto()
        {
            InitializeComponent();
        }

        private void BtnCadastrar_Click(object sender, EventArgs e)
        {
            Produto obj = new Produto();

            obj.descricao = txtDescricaoDoProduto.Text;
            obj.qtd = int.Parse(txtqtd.Text);
            obj.preco = double.Parse(CampoPreco.Text);

            //Pegando a chave estrangeira do combobox de fornecedor
            obj.fk_fornecedor = int.Parse(tbFornecedor.SelectedValue.ToString());

            ProdutoDAO dao = new ProdutoDAO();
            dao.Cadastrar(obj);

            dgProduto.DataSource = dao.ListarTodosProdutos();
        }

        private void BtnAlterar_Click(object sender, EventArgs e)
        {
            Produto obj = new Produto();

            obj.descricao = txtDescricaoDoProduto.Text;
            obj.id_produto = int.Parse(txtid.Text);
            obj.qtd = int.Parse(txtqtd.Text);
            obj.preco = double.Parse(CampoPreco.Text);
            obj.fk_fornecedor = int.Parse(tbFornecedor.SelectedValue.ToString());

            ProdutoDAO dAO = new ProdutoDAO();
            dAO.EditarProduto(obj);

            //CARREGAR O DATAGRIDVIEW
            ProdutoDAO produtoDAO = new ProdutoDAO();
            dgProduto.DataSource = produtoDAO.ListarTodosProdutos();
        }

        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            Produto obj = new Produto();

            obj.id_produto = int.Parse(txtid.Text);

            ProdutoDAO dAO = new ProdutoDAO();
            dAO.ExcluirProduto(obj);

            //CARREGAR O DATAGRIDVIEW
            ProdutoDAO produtoDAO = new ProdutoDAO();
            dgProduto.DataSource = produtoDAO.ListarTodosProdutos();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            FornecedorDAO dao = new FornecedorDAO();
            tbFornecedor.DataSource = dao.ListarTodosFornecedor();

            //Pegando o Nome do fornecedor
            tbFornecedor.DisplayMember = "nome";
            // Trocando o nome do fornecedor para o id do fornecedor
            tbFornecedor.ValueMember = "id_fornecedor";

            //CARREGAR O DATAGRIDVIEW
            ProdutoDAO produtoDAO = new ProdutoDAO();
            dgProduto.DataSource = produtoDAO.ListarTodosProdutos();
        }

        private void dgProduto_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtid.Text = dgProduto.CurrentRow.Cells[0].Value.ToString();
            txtDescricaoDoProduto.Text = dgProduto.CurrentRow.Cells[1].Value.ToString();
            txtqtd.Text = dgProduto.CurrentRow.Cells[2].Value.ToString();
            CampoPreco.Text = dgProduto.CurrentRow.Cells[2].Value.ToString();
            tbFornecedor.Text = dgProduto.CurrentRow.Cells[4].Value.ToString();

            TabPrdouto.SelectedTab = TabCadastro;
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {

        }
    }
}
