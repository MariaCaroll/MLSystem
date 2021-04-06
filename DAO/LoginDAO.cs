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
               
                string sql = "SELECT * FROM tbUser WHERE username = @username AND password = @password AND user_type = @user_type";
                SqlCommand cmd = new SqlCommand(sql, conn);
               
                cmd.Parameters.AddWithValue("@username", loginClass.username);
                cmd.Parameters.AddWithValue("@password", loginClass.password);
                cmd.Parameters.AddWithValue("@user_type", loginClass.type_user);
               // cmd.Parameters.AddWithValue("@id_user", loginClass.SessionID);


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
