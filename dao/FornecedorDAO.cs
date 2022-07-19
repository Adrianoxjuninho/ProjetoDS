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
    public class FornecedorDAO
    {
        MySqlConnection conexao = ConnectionFactory.getConnection();

        public FornecedorDAO()
        {
            //abre a conexao     
            conexao.Open();
        }

        #region Método Casdastrar Fornecedor
        public void cadastrar(Fornecedor obj)
        {
            try
            {
                string sql = @"insert into fornecedor (nome, cnpj, endereco, bairro, cidade, numero, telefone, email)
                             values (@nome,@cnpj,@endereco,@bairro,@cidade,@numero,@telefone,@email)";

                //2 passo - organizar o sql
                MySqlCommand executacmdsql = new MySqlCommand(sql, conexao);

                executacmdsql.Parameters.AddWithValue("@nome", obj.nome);
                executacmdsql.Parameters.AddWithValue("@cnpj", obj.cnpj);
                executacmdsql.Parameters.AddWithValue("@endereco", obj.endereco);
                executacmdsql.Parameters.AddWithValue("@bairro", obj.bairro);
                executacmdsql.Parameters.AddWithValue("@cidade", obj.cidade);
                executacmdsql.Parameters.AddWithValue("@numero", obj.numero);
                executacmdsql.Parameters.AddWithValue("@telefone", obj.telefone);
                executacmdsql.Parameters.AddWithValue("@email", obj.email);

                executacmdsql.ExecuteNonQuery();
                //4 passo - fechar a conexao
                conexao.Close();
            }
            catch (Exception error)
            {

                MessageBox.Show("Aconteceu o erro" + error);
            }
        }
        #endregion

        #region Método Alterar Fornecedor
        public void Alterar(Fornecedor obj)
        {
            try
            {
                string sql = @"update fornecedor set nome= @nome,cnpj= @cnpj,endereco= @endereco,
                            bairro= @bairro,cidade= @cidade,numero= @numero,telefone= @telefone,email= @email
                            
                            where id_fornecedor = @id";

                //2 passo - organizar o sql
                MySqlCommand executacmdsql = new MySqlCommand(sql, conexao);
                executacmdsql.Parameters.AddWithValue("@nome", obj.nome);
                executacmdsql.Parameters.AddWithValue("@cnpj", obj.cnpj);
                executacmdsql.Parameters.AddWithValue("@endereco", obj.endereco);
                executacmdsql.Parameters.AddWithValue("@bairro", obj.bairro);
                executacmdsql.Parameters.AddWithValue("@cidade", obj.cidade);
                executacmdsql.Parameters.AddWithValue("@numero", obj.numero);
                executacmdsql.Parameters.AddWithValue("@telefone", obj.telefone);
                executacmdsql.Parameters.AddWithValue("@email", obj.email);



                executacmdsql.ExecuteNonQuery();
                //4 passo - fechar a conexao
                conexao.Close();

                MessageBox.Show("Dados Alterados com Sucesso!");
            }
            catch (Exception error)
            {

                MessageBox.Show("Aconteceu o erro" + error);
            }
        }

        #endregion

        #region Método Excluir Fornecedor
        public void Excluir(Fornecedor obj)
        {
            try
            {
                string sql = @"delete from fornecedor where id_fornecedor = @id";

                //2 passo - organizar o sql
                MySqlCommand executacmdsql = new MySqlCommand(sql, conexao);

                executacmdsql.Parameters.AddWithValue("@id", obj.id);



                executacmdsql.ExecuteNonQuery();
                //4 passo - fechar a conexao
                conexao.Close();

                MessageBox.Show("Excluido com Sucesso!");
            }
            catch (Exception error)
            {

                MessageBox.Show("Aconteceu o erro" + error);
            }
        }

        #endregion

        #region Método de Listar Todos os Fornecedores
        public DataTable ListarTodosFornecedor()
        {

            //1 passo - comando sql
            string sql = @"SELECT * FROM fornecedor;";

            //2 passo - organizar o sql
            MySqlCommand executacmdsql = new MySqlCommand(sql, conexao);

            //3 passo - abrir a conexao e executar o comando                
            executacmdsql.ExecuteNonQuery();

            //4 passo - criar o MySQLDataAdapter

            MySqlDataAdapter da = new MySqlDataAdapter(executacmdsql);
            //5 passo - criar o DataTable

            DataTable tabelaFornecedor = new DataTable();
            da.Fill(tabelaFornecedor);

            //fechar conexão
            conexao.Close();

            //Retornar o DataTable com os dados
            return tabelaFornecedor;
        }
        #endregion

        #region Método de Listar Todos os Fornecedores
        public DataTable fornecedorlist()
        {

            //1 passo - comando sql
            string sql = @"select column_name from information_schema.columns where table_name = 'produto'";

            //2 passo - organizar o sql
            MySqlCommand executacmdsql = new MySqlCommand(sql, conexao);

            //3 passo - abrir a conexao e executar o comando                
            executacmdsql.ExecuteNonQuery();

            //4 passo - criar o MySQLDataAdapter

            MySqlDataAdapter da = new MySqlDataAdapter(executacmdsql);
            //5 passo - criar o DataTable

            DataTable tabelaFornecedor = new DataTable();
            da.Fill(tabelaFornecedor);

            //fechar conexão
            conexao.Close();

            //Retornar o DataTable com os dados
            return tabelaFornecedor;
        }
        #endregion
    }
}

