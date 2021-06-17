using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using MLSystem.Class;

namespace MLSystem.DAO
{
    class TransacaoDAO
    {
        static String myconnstring = ConfigurationManager.ConnectionStrings["connstring"].ConnectionString;
        #region selecionar dados do database
        public DataTable Select()
        {
            SqlConnection conn = new SqlConnection(myconnstring);
            DataTable dt = new DataTable();
            try
            {
                String sql = "SELECT * FROM tbTransacao";
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
        public bool InsertTransacao(TransacaoClass transacao, out int transacaoID)
        {

            bool isSuccess = false;
            transacaoID = -1;
            SqlConnection conn = new SqlConnection(myconnstring);
            try
            {
                String sql = "INSERT INTO tbTransacao(id_transacao, tipo, cliente_id, subtotal, transacao_dia, taxa, desconto, criado_por)" +
                    "VALUES(@id_transacao, @tipo, @cliente_id, @subtotal, @transacao_dia, @taxa, @desconto, @criado_por)";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@id_transacao", transacao.id_transacao);
                cmd.Parameters.AddWithValue("@tipo", transacao.tipo);
                cmd.Parameters.AddWithValue("@cliente_id", transacao.cliente_id);
                cmd.Parameters.AddWithValue("@subtotal", transacao.subtotal);
                cmd.Parameters.AddWithValue("@transacao_dia", transacao.data_trasacao);
                cmd.Parameters.AddWithValue("@taxa", transacao.taxa);
                cmd.Parameters.AddWithValue("@desconto", transacao.desconto);
                cmd.Parameters.AddWithValue("@criado_por", transacao.criado_por);
                // seria para salvar a imagem mas ta com erro
                // cmd.Parameters.AddWithValue("@image", produto.imagem);

                conn.Open();

                // pegar a id do usuario logado creio eu
                object o = cmd.ExecuteScalar();
                
                if (o != null)
                {
                    transacaoID = int.Parse(o.ToString());
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
        public bool Update(TransacaoClass transacao)
        {
            bool isSuccess = false;
            SqlConnection conn = new SqlConnection(myconnstring);
            try
            {
                string sql = "UPDATE tbProduto SET id_transacao = @id_transacao, tipo = @tipo, cliente_id = @cliente_id, subtotal = @subtotal, " +
                    " transacao_dia = @transacao_dia, taxa = @taxa, desconto = @desconto, criado_por = @criado_por WHERE id_transacao = @id_transacao";
                SqlCommand cmd = new SqlCommand(sql, conn);              
                cmd.Parameters.AddWithValue("@tipo", transacao.tipo);
                cmd.Parameters.AddWithValue("@cliente_id", transacao.cliente_id);
                cmd.Parameters.AddWithValue("@subtotal", transacao.subtotal);
                cmd.Parameters.AddWithValue("@transacao_dia", transacao.data_trasacao);
                cmd.Parameters.AddWithValue("@taxa", transacao.taxa);
                cmd.Parameters.AddWithValue("@desconto", transacao.desconto);
                cmd.Parameters.AddWithValue("@criado_por", transacao.criado_por);
                cmd.Parameters.AddWithValue("@id_transacao", transacao.id_transacao);

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
        public bool Delete(TransacaoClass transacao)
        {
            bool isSuccess = false;
            SqlConnection conn = new SqlConnection(myconnstring);
            try
            {
                string sql = "DELETE FROM tbTransacao WHERE id_transacao = @id_transacao";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@id_transacao", transacao.id_transacao);

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

        

    }
}
