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

namespace MLSystem.Data
{
    class UserDAO
    {
        static String myconnstring = ConfigurationManager.ConnectionStrings["connstring"].ConnectionString;

        #region selecionar dados do database
        public DataTable Select()
        {
            SqlConnection conn = new SqlConnection(myconnstring);
            DataTable dt = new DataTable();
            try
            {
                String sql = "SELECT * FROM tbUser";
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
        public bool Insert(UserClass usuario)
        {
            bool isSuccess = false;
            SqlConnection conn = new SqlConnection(myconnstring);
            try
            {
                String sql = "INSERT INTO tbUser(first_name, last_name, email, username, password, phone," +
                    " address, denger, user_type, created_date, created_by, zip_code, state, neighborhood, city, number)" +
                    "VALUES(@first_name, @last_name, @email, @username, @password, @phone, @address, @denger, @user_type, " +
                    "@created_date, @created_by, @zip_code, @state, @neighborhood, @city, @number)";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@first_name", usuario.first_name);
                cmd.Parameters.AddWithValue("@last_name", usuario.last_name);
                cmd.Parameters.AddWithValue("@email", usuario.email);
                cmd.Parameters.AddWithValue("@username", usuario.username);
                cmd.Parameters.AddWithValue("@password", usuario.password);
                cmd.Parameters.AddWithValue("@phone", usuario.phone);
                cmd.Parameters.AddWithValue("@address", usuario.address);
                cmd.Parameters.AddWithValue("@denger", usuario.denger);
                cmd.Parameters.AddWithValue("@user_type", usuario.user_type);
                cmd.Parameters.AddWithValue("@created_date", usuario.created_date);
                cmd.Parameters.AddWithValue("@created_by", usuario.created_by);
                cmd.Parameters.AddWithValue("@zip_code", usuario.zip_code);
                cmd.Parameters.AddWithValue("@state", usuario.state);
                cmd.Parameters.AddWithValue("@neighborhood", usuario.neighborhood);
                cmd.Parameters.AddWithValue("@city", usuario.city);
                cmd.Parameters.AddWithValue("@number", usuario.number);

                conn.Open();
                int rows = cmd.ExecuteNonQuery();
                if( rows > 0)
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
        public bool Update(UserClass usuario)
        {
            bool isSuccess = false;
            SqlConnection conn = new SqlConnection(myconnstring);
            try
            {
                string sql = "UPDATE tbUser SET first_name = @first_name, last_name = @last_name, email = @email, " +
                    " username = @username, password = @password, phone = @phone, address = @address, denger = @denger," +
                    " user_type = @user_type, created_date = @created_date, created_by = @created_by, zip_code = @zip_code," +
                    " state = @state, neighborhood = @neighborhood, city = @city, number = @number WHERE id_user = @id_user";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@first_name", usuario.first_name);
                cmd.Parameters.AddWithValue("@last_name", usuario.last_name);
                cmd.Parameters.AddWithValue("@email", usuario.email);
                cmd.Parameters.AddWithValue("@username", usuario.username);
                cmd.Parameters.AddWithValue("@password", usuario.password);
                cmd.Parameters.AddWithValue("@phone", usuario.phone);
                cmd.Parameters.AddWithValue("@address", usuario.address);
                cmd.Parameters.AddWithValue("@denger", usuario.denger);
                cmd.Parameters.AddWithValue("@user_type", usuario.user_type);
                cmd.Parameters.AddWithValue("@created_date", usuario.created_date);
                cmd.Parameters.AddWithValue("@created_by", usuario.created_by);
                cmd.Parameters.AddWithValue("@zip_code", usuario.zip_code);
                cmd.Parameters.AddWithValue("@state", usuario.state);
                cmd.Parameters.AddWithValue("@neighborhood", usuario.neighborhood);
                cmd.Parameters.AddWithValue("@city", usuario.city);
                cmd.Parameters.AddWithValue("@number", usuario.number);
                cmd.Parameters.AddWithValue("@id_user", usuario.id_user);

                conn.Open();
                int rows = cmd.ExecuteNonQuery();
                
                if(rows > 0 )
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
        public bool Delete(UserClass usuario)
        {
            bool isSuccess = false;
            SqlConnection conn = new SqlConnection(myconnstring);
            try
            {
                string sql = "DELETE FROM tbUser WHERE id_user = @id_user";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@id_user", usuario.id_user);

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
                String sql = "SELECT * FROM tbUser WHERE id_user LIKE '%" + keywords + "%' or first_name LIKE '%" + keywords + "%' or last_name LIKE '%" + keywords + "%' or username LIKE '%" + keywords + "%'";

             

                // String sql = "SELECT * FROM tbUser WHERE id_user LIKE '%"+ keywords + "%' " +
                 //   "OR first_name LIKE '%" + keywords + "%'  OR last_name LIKE '%" + keywords + "%' OR username'%" + keywords + "%'";
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
