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
    class ProdutoDAO
    {
        static String myconnstring = ConfigurationManager.ConnectionStrings["connstring"].ConnectionString;
        #region selecionar dados do database
        public DataTable Select()
        {
            SqlConnection conn = new SqlConnection(myconnstring);
            DataTable dt = new DataTable();
            try
            {
                String sql = "SELECT * FROM tbProducts";
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
        public bool Insert(ProdutoClass produto)
        {
            bool isSuccess = false;
            SqlConnection conn = new SqlConnection(myconnstring);
            try
            {
                String sql = "INSERT INTO tbProducts(name, category, description, rate, amt, created_date, creeated_by)" +
                    "VALUES(@name, @category, @description, @rate, @amt, @created_date, @creeated_by)";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@name", produto.name);
                cmd.Parameters.AddWithValue("@category", produto.category);
                cmd.Parameters.AddWithValue("@description", produto.description);
                cmd.Parameters.AddWithValue("@rate", produto.rate);
                cmd.Parameters.AddWithValue("@amt", produto.amt);
                cmd.Parameters.AddWithValue("@created_date", produto.created_date);
                cmd.Parameters.AddWithValue("@creeated_by", produto.creeated_by);
                
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
                string sql = "UPDATE tbProdcts SET name = @name, category = @category, description = @description, " +
                    " rate = @rate, amt = @amt, created_date = @created_date, creeated_by = @creeated_by WHERE id_product = @id_product";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@name", produto.name);
                cmd.Parameters.AddWithValue("@category", produto.category);
                cmd.Parameters.AddWithValue("@description", produto.description);
                cmd.Parameters.AddWithValue("@rate", produto.rate);
                cmd.Parameters.AddWithValue("@amt", produto.amt);
                cmd.Parameters.AddWithValue("@created_date", produto.created_date);
                cmd.Parameters.AddWithValue("@creeated_by", produto.creeated_by);
                cmd.Parameters.AddWithValue("@id_product", produto.id_product);

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
        public bool Delete(ProdutoClass produto)
        {
            bool isSuccess = false;
            SqlConnection conn = new SqlConnection(myconnstring);
            try
            {
                string sql = "DELETE FROM tbProducts WHERE id_product = @id_product";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@id_product", produto.id_product);

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
                String sql = "SELECT * FROM tbProducts WHERE id_product LIKE '%" + keywords + "%' or name '%" + keywords + "%' or category LIKE '%" + keywords + "%'";
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
