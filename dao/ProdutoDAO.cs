using MySql.Data.MySqlClient;
using ProjetoDS.conexao;
using ProjetoDS.model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoDS.dao
{

    public class ProdutoDAO
    {
        MySqlConnection conexao = ConnectionFactory.getConnection();

        public ProdutoDAO()
        {
            conexao.Open();
        }
        #region Botão de cadastrar 
        public void Cadastrar(Produto obj)
        {
            try
            {
                string sql = @"insert into produto (descricao, quantidade, fk_forid, preco) values (@descricao,@quantidade,@fk_forid, @preco)";

                MySqlCommand executacmdsql = new MySqlCommand(sql, conexao);
                                                                                        
                executacmdsql.Parameters.AddWithValue("@descricao", obj.descricao);
                executacmdsql.Parameters.AddWithValue("@quantidade", obj.qtd);
                executacmdsql.Parameters.AddWithValue("@fk_forid", obj.fk_fornecedor);
                executacmdsql.Parameters.AddWithValue("@preco", obj.preco);

                executacmdsql.ExecuteNonQuery();

                conexao.Clone();
                MessageBox.Show("Cadastro realizado com sucesso!");
            }
            catch (Exception erro)
            {
                MessageBox.Show("Aconteceu um erro:" + erro);
            }
        }
        #endregion

        #region Botão de Editar Produtos
        public void EditarProduto (Produto obj)
        {
            try
            {
                string sql = @"update produto set  descricao=@descricao,quantidade=@quantidade,fk_forid=@fk_forid, preco=@preco where id_produto = @id";

                MySqlCommand executacmdsql = new MySqlCommand(sql, conexao);

                executacmdsql.Parameters.AddWithValue("@descricao", obj.descricao);
                executacmdsql.Parameters.AddWithValue("@quantidade", obj.qtd);
                executacmdsql.Parameters.AddWithValue("@fk_forid", obj.fk_fornecedor);
                executacmdsql.Parameters.AddWithValue("@id", obj.id_produto);
                executacmdsql.Parameters.AddWithValue("@preco", obj.preco);

                executacmdsql.ExecuteNonQuery();

                conexao.Clone();
                MessageBox.Show("Produto alterado com sucesso!");
            }
            catch (Exception erro)
            {
                MessageBox.Show("Aconteceu um erro:" + erro);
            }
        }
        #endregion

        #region Botão de Excluir Produto

        public void ExcluirProduto (Produto obj)
        {
            try
            {
                string sql = @"delete from produto where id_produto = id";

                MySqlCommand executacmdsql = new MySqlCommand(sql, conexao);

                executacmdsql.Parameters.AddWithValue("@id", obj.id_produto);

                executacmdsql.ExecuteNonQuery();

                conexao.Clone();
                MessageBox.Show("Produto excluido com sucesso!");
            }
            catch (Exception erro)
            {
                MessageBox.Show("Aconteceu um erro:" + erro);
            }
        }
<<<<<<< HEAD
=======

>>>>>>> 07dd74b86e1a92c64cb1ebe65b6c2f24cc480416
        #endregion

        #region //Metodo lIstar clientes
        public DataTable ListarTodosProdutos()
        {

            //1 passo - comando sql
            string sql = @"SELECT p.ID_Produto as  'Código', p.Descricao as 'Descrição', +
                              p.Quantidade as 'Qtd', p.preco as 'Preço' ,f.Nome as 'Fornecedor' 
                              FROM produto as p 
                              JOIN fornecedor as f on(p.FK_forID = f.ID_Fornecedor)";

            //2 passo - organizar o sql
            MySqlCommand executacmdsql = new MySqlCommand(sql, conexao);

            //3 passo - abrir a conexao e executar o comando                
            executacmdsql.ExecuteNonQuery();

            //4 passo - criar o MySQLDataAdapter

            MySqlDataAdapter da = new MySqlDataAdapter(executacmdsql);
            //5 passo - criar o DataTable

            DataTable tabelaProduto = new DataTable();
            da.Fill(tabelaProduto);

            //fechar conexão
            conexao.Close();

            //Retornar o DataTable com os dados
            return tabelaProduto;

        }
        #endregion
<<<<<<< HEAD


=======
>>>>>>> 07dd74b86e1a92c64cb1ebe65b6c2f24cc480416
    }
}
