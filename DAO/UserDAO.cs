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
                String sql = "SELECT * FROM tbUsuario";
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
                String sql = "INSERT INTO tbUsuario(nome_usuario, sobrenome_usuario, email_usuario, login, senha, phone_usuario," +
                    " endereco_usuario, sexo, tipo_usuario, data_criacao, criado_por, cep_usuario, estado_usuario, bairro_usuario," +
                    " cidade_usuario, numero_usuario, recuperacao_senha, @cpf_usuario)" +
                    "VALUES(@nome_usuario, @sobrenome_usuario, @email_usuario, @login, @senha, @phone_usuario, @endereco_usuario, @sexo, @tipo_usuario, " +
                    "@data_criacao, @criado_por, @cep_usuario, @estado_usuario, @bairro_usuario, @cidade_usuario, @numero_usuario, @recuperacao_senha, @cpf_usuario)";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@nome_usuario", usuario.nome_usuario);
                cmd.Parameters.AddWithValue("@sobrenome_usuario", usuario.sobrenome_usuario);
                cmd.Parameters.AddWithValue("@email_usuario", usuario.email_usuario);
                cmd.Parameters.AddWithValue("@login", usuario.login);
                cmd.Parameters.AddWithValue("@senha", usuario.senha);
                cmd.Parameters.AddWithValue("@phone_usuario", usuario.phone_usuario);
                cmd.Parameters.AddWithValue("@endereco_usuario", usuario.endereco_usuario);
                cmd.Parameters.AddWithValue("@sexo", usuario.sexo);
                cmd.Parameters.AddWithValue("@tipo_usuario", usuario.tipo_usuario);
                cmd.Parameters.AddWithValue("@data_criacao", usuario.data_criacao);
                cmd.Parameters.AddWithValue("@criado_por", usuario.criado_por);
                cmd.Parameters.AddWithValue("@cep_usuario", usuario.cep_usuario);
                cmd.Parameters.AddWithValue("@estado_usuario", usuario.estado_usuario);
                cmd.Parameters.AddWithValue("@bairro_usuario", usuario.bairro_usuario);
                cmd.Parameters.AddWithValue("@cidade_usuario", usuario.cidade_usuario);
                cmd.Parameters.AddWithValue("@numero_usuario", usuario.numero_usuario);
                cmd.Parameters.AddWithValue("@cpf_usuario",usuario.cpf_usuario);
                cmd.Parameters.AddWithValue("@recuperacao_senha", usuario.recuperacao_senha);

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
                string sql = "UPDATE tbUsuario SET nome_usuario = @nome_usuario, sobrenome_usuario = @sobrenome_usuario, email_usuario = @email_usuario, " +
                    " login = @login, senha = @senha, phone_usuario = @phone_usuario, endereco_usuario = @endereco_usuario, sexo = @sexo," +
                    " tipo_usuario = @tipo_usuario, data_criacao = @data_criacao, criado_por = @criado_por, cep_usuario = @cep_usuario," +
                    " estado_usuario = @estado_usuario, bairro_usuario = @bairro_usuario, cidade_usuario = @cidade_usuario, numero_usuario = @numero_usuario," +
                    " recuperacao_senha = @recuperacao_senha, cpf_usuario = @cpf_usuario" +
                    " WHERE id_usuario = @id_usuario";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@nome_usuario", usuario.nome_usuario);
                cmd.Parameters.AddWithValue("@sobrenome_usuario", usuario.sobrenome_usuario);
                cmd.Parameters.AddWithValue("@email_usuario", usuario.email_usuario);
                cmd.Parameters.AddWithValue("@login", usuario.login);
                cmd.Parameters.AddWithValue("@senha", usuario.senha);
                cmd.Parameters.AddWithValue("@phone_usuario", usuario.phone_usuario);
                cmd.Parameters.AddWithValue("@endereco_usuario", usuario.endereco_usuario);
                cmd.Parameters.AddWithValue("@sexo", usuario.sexo);
                cmd.Parameters.AddWithValue("@tipo_usuario", usuario.tipo_usuario);
                cmd.Parameters.AddWithValue("@data_criacao", usuario.data_criacao);
                cmd.Parameters.AddWithValue("@criado_por", usuario.criado_por);
                cmd.Parameters.AddWithValue("@cep_usuario", usuario.cep_usuario);
                cmd.Parameters.AddWithValue("@estado_usuario", usuario.estado_usuario);
                cmd.Parameters.AddWithValue("@bairro_usuario", usuario.bairro_usuario);
                cmd.Parameters.AddWithValue("@cidade_usuario", usuario.cidade_usuario);
                cmd.Parameters.AddWithValue("@numero_usuario", usuario.numero_usuario);
                cmd.Parameters.AddWithValue("@recuperacao_senha", usuario.recuperacao_senha);
                cmd.Parameters.AddWithValue("@cpf_usuario", usuario.cpf_usuario);
                cmd.Parameters.AddWithValue("@id_usuario", usuario.id_usuario);

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
                string sql = "DELETE FROM tbUsuario WHERE id_usuario = @id_usuario";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@id_usuario", usuario.id_usuario);

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
                String sql = "SELECT * FROM tbUsuario WHERE id_usuario LIKE '%" + keywords + "%' or nome_usuario LIKE '%" + keywords + "%' or sobrenome_usuario LIKE '%" + keywords + "%' or login LIKE '%" + keywords + "%'";

             

                // String sql = "SELECT * FROM tbUsuario WHERE id_usuario LIKE '%"+ keywords + "%' " +
                 //   "OR nome_usuario LIKE '%" + keywords + "%'  OR sobrenome_usuario LIKE '%" + keywords + "%' OR login'%" + keywords + "%'";
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
