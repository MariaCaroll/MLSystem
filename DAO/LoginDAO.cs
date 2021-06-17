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
    class LoginDAO

    {
        
        static string  myConnstring = ConfigurationManager.ConnectionStrings["connstring"].ConnectionString;

        public bool loginCheck(LoginClass loginClass)
        {
            bool isSuccess = false;
            SqlConnection conn = new SqlConnection(myConnstring);

            try
            {
               
                string sql = "SELECT * FROM tbUsuario WHERE login = @login AND senha = @senha AND tipo_usuario = @tipo_usuario";
                SqlCommand cmd = new SqlCommand(sql, conn);
               
                cmd.Parameters.AddWithValue("@login", loginClass.login);
                cmd.Parameters.AddWithValue("@senha", loginClass.senha);
                cmd.Parameters.AddWithValue("@tipo_usuario", loginClass.tipo_usuario);
               // cmd.Parameters.AddWithValue("@id_usuario", loginClass.SessionID);


                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                if(dt.Rows.Count > 0)
                {
                    isSuccess = true;

                }
                else
                {
                    isSuccess = false;

                }

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return isSuccess;
        }

    }
}
