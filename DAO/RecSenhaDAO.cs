using MLSystem.Class;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MLSystem.DAO
{
    class RecSenhaDAO
    {

        static String myconnstring = ConfigurationManager.ConnectionStrings["connstring"].ConnectionString;

        #region atualizando senha no banco de dados
        public bool UpdateSenha( RecSenhaClass senha)
        {
            bool isSuccess = false;
            SqlConnection conn = new SqlConnection(myconnstring);
            try
            {
                string sql = "UPDATE tbUsuario SET senha = @senha WHERE cpf_usuario = @cpf_usuario";

                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@senha", senha.confirma_senha );
                cmd.Parameters.AddWithValue("@cpf_usuario", senha.cpf_usuario);


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
