using MLSystem.Class;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MLSystem.DAO
{
    class TransacaoDetalheDAO
    {
        static String myconnstring = ConfigurationManager.ConnectionStrings["connstring"].ConnectionString;
        #region selecionar dados do database
        public DataTable Select()
        {
            SqlConnection conn = new SqlConnection(myconnstring);
            DataTable dt = new DataTable();
            try
            {
                String sql = "SELECT * FROM tbTransacaoDetalhes";
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                conn.Open();
                adapter.Fill(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return dt;
        }
        #endregion

        #region inserindo dados no banco de dados
        public bool InsertTransacaoDetalhe(TransacaoDetalhesClass detalhe, out int detalheID)
        {

            bool isSuccess = false;
            detalheID = -1;
            SqlConnection conn = new SqlConnection(myconnstring);
            try
            {
                String sql = "INSERT INTO tbTransacaoDetalhes(id_venda, produto_id,valor ,quantidade," +
                    " total, cliente_id, criacao_data, criado_por)" +
                    "VALUES(@id_venda, @produto_id,@valor ,@quantidade, @total, @cliente_id, @criacao_data, @criado_por)";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@id_venda", detalhe.id_venda);
                cmd.Parameters.AddWithValue("@produto_id", detalhe.produto_id);
                cmd.Parameters.AddWithValue("@valor", detalhe.valor);
                cmd.Parameters.AddWithValue("@quantidade", detalhe.quantidade);
                cmd.Parameters.AddWithValue("@total", detalhe.total);
                cmd.Parameters.AddWithValue("@cliente_id", detalhe.cliente_id);
                cmd.Parameters.AddWithValue("@criacao_data", detalhe.criacao_data);
                cmd.Parameters.AddWithValue("@criado_por", detalhe.criado_por);
                // seria para salvar a imagem mas ta com erro
                // cmd.Parameters.AddWithValue("@image", produto.imagem);

                conn.Open();
                int rows = cmd.ExecuteNonQuery();
                if (rows > 0)
                {
                    isSuccess = true;
                }
                else
                {
                    isSuccess = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return isSuccess;
        }
        #endregion

        #region atualizando dados no banco de dados
        public bool Update(ProdutoClass produto)
        {
            bool isSuccess = false;
            SqlConnection conn = new SqlConnection(myconnstring);
            try
            {
                string sql = "UPDATE tbProduto SET nome_produto = @nome_produto, categoria = @categoria, descricao = @descricao, " +
                    " valor = @valor, quantidade = @quantidade, data_criacao = @data_criacao, criado_por = @criado_por WHERE id_produto = @id_produto";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@nome_produto", produto.nome_produto);
                cmd.Parameters.AddWithValue("@categoria", produto.categoria);
                cmd.Parameters.AddWithValue("@descricao", produto.descricao);
                cmd.Parameters.AddWithValue("@valor", produto.valor);
                cmd.Parameters.AddWithValue("@quantidade", produto.quantidade);
                cmd.Parameters.AddWithValue("@data_criacao", produto.data_criacao);
                cmd.Parameters.AddWithValue("@criado_por", produto.criado_por);
                cmd.Parameters.AddWithValue("@id_produto", produto.id_produto);

                conn.Open();
                int rows = cmd.ExecuteNonQuery();

                if (rows > 0)
                {
                    isSuccess = true;
                }
                else
                {
                    isSuccess = false;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return isSuccess;
        }
        #endregion

        #region Deletar dados do banco 
        public bool Delete(TransacaoDetalhesClass detalhe)
        {
            bool isSuccess = false;
            SqlConnection conn = new SqlConnection(myconnstring);
            try
            {
                string sql = "DELETE FROM tbTransacaoDetalhes WHERE id_venda = @id_venda";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@id_venda", detalhe.id_venda);

                conn.Open();
                int rows = cmd.ExecuteNonQuery();

                if (rows > 0)
                {
                    isSuccess = true;
                }
                else
                {
                    isSuccess = false;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return isSuccess;
        }
        #endregion

        #region Metodo para pesquisar
        public DataTable Search(string keywords)
        {
            SqlConnection conn = new SqlConnection(myconnstring);
            DataTable dt = new DataTable();
            try
            {
                String sql = "SELECT * FROM tbTransacaoDetalhes WHERE id_venda LIKE '%" + keywords + "%' or produto_id LIKE '%" + keywords + "%' or cliente_id LIKE '%" + keywords + "%'";


                // String sql = "SELECT * FROM tbTransacaoDetalhes WHERE id_produto LIKE '%" + keywords + "%' or nome_produto '%" + keywords + "%' or categoria LIKE '%" + keywords + "%'";
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                conn.Open();
                adapter.Fill(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return dt;
        }

        internal DataTable Search()
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}
