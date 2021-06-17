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
    class ClienteDAO
    {
        static String myconnstring = ConfigurationManager.ConnectionStrings["connstring"].ConnectionString;

        #region selecionar dados do database
        public DataTable Select()
        {
            SqlConnection conn = new SqlConnection(myconnstring);
            DataTable dt = new DataTable();
            try
            {
                String sql = "SELECT * FROM tbCliente";
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
        public bool Insert(ClienteClass cliente)
        {
            bool isSuccess = false;
            SqlConnection conn = new SqlConnection(myconnstring);
            try
            {
                String sql = "INSERT INTO tbCliente(nome_cliente, sobrenome_cliente, email_cliente, phone_cliente, sexo_cliente," +
                    "cep_cliente, estado_cliente, endereco_cliente, cidade_cliente, bairro_cliente, numero_cliente, data_criacao, criado_por, aniversario)" +
                    "VALUES(@nome_cliente, @sobrenome_cliente, @email_cliente, @phone_cliente, @sexo_cliente, @cep_cliente, @estado_cliente," +
                    "@endereco_cliente, @cidade_cliente, @bairro_cliente, @numero_cliente, @data_criacao, @criado_por,  @aniversario)";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@nome_cliente", cliente.nome_cliente);
                cmd.Parameters.AddWithValue("@sobrenome_cliente", cliente.sobrenome_cliente);
                cmd.Parameters.AddWithValue("@email_cliente", cliente.email_cliente);
                cmd.Parameters.AddWithValue("@phone_cliente", cliente.phone_cliente);
                cmd.Parameters.AddWithValue("@sexo_cliente", cliente.sexo_cliente);
                
                cmd.Parameters.AddWithValue("@cep_cliente", cliente.cep_cliente);
                cmd.Parameters.AddWithValue("@estado_cliente", cliente.estado_cliente);
                cmd.Parameters.AddWithValue("@endereco_cliente", cliente.endereco_cliente);
                cmd.Parameters.AddWithValue("@cidade_cliente", cliente.cidade_cliente);
                cmd.Parameters.AddWithValue("@bairro_cliente", cliente.bairro_cliente);
                cmd.Parameters.AddWithValue("@numero_cliente", cliente.numero_cliente);
                cmd.Parameters.AddWithValue("@data_criacao", cliente.data_criacao);
                cmd.Parameters.AddWithValue("@criado_por", cliente.criado_por);
                cmd.Parameters.AddWithValue("@aniversario", cliente.aniversario_cliente);

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
        public bool Update(ClienteClass cliente)
        {
            bool isSuccess = false;
            SqlConnection conn = new SqlConnection(myconnstring);
            try
            {   
                string sql = "UPDATE tbCliente SET nome_cliente = @nome_cliente, sobrenome_cliente = @sobrenome_cliente, email_cliente = @email_cliente," +
                    "phone_cliente = @phone_cliente,sexo_cliente = @sexo_cliente, aniversario_cliente =  @aniversario_cliente, cep_cliente = @cep_cliente, estado_cliente = @estado_cliente " +
                    "endereco_cliente = @endereco_cliente, cidade_cliente = @cidade_cliente, bairro_cliente = @bairro_cliente,numero_cliente = @numero_cliente,data_criacao = @data_criacao, criado_por = @criado_por " +
                    "WHERE id_cliente = @id_cliente";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@nome_cliente", cliente.nome_cliente);
                cmd.Parameters.AddWithValue("@sobrenome_cliente", cliente.sobrenome_cliente);
                cmd.Parameters.AddWithValue("@email_cliente", cliente.email_cliente);
                cmd.Parameters.AddWithValue("@phone_cliente", cliente.phone_cliente);
                cmd.Parameters.AddWithValue("@sexo_cliente", cliente.sexo_cliente);
               
                cmd.Parameters.AddWithValue("@cep_cliente", cliente.cep_cliente);
                cmd.Parameters.AddWithValue("@estado_cliente", cliente.estado_cliente);
                cmd.Parameters.AddWithValue("@endereco_cliente", cliente.endereco_cliente);
                cmd.Parameters.AddWithValue("@cidade_cliente", cliente.cidade_cliente);
                cmd.Parameters.AddWithValue("@bairro_cliente", cliente.bairro_cliente);
                cmd.Parameters.AddWithValue("@numero_cliente", cliente.numero_cliente);
                cmd.Parameters.AddWithValue("@data_criacao", cliente.data_criacao);
                cmd.Parameters.AddWithValue("@criado_por", cliente.criado_por);
                cmd.Parameters.AddWithValue("@id_cliente", cliente.id_cliente);
                cmd.Parameters.AddWithValue("@aniversario", cliente.aniversario_cliente);

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
        public bool Delete(ClienteClass cliente)
        {
            bool isSuccess = false;
            SqlConnection conn = new SqlConnection(myconnstring);
            try
            {
                string sql = "DELETE FROM tbCliente WHERE id_cliente = @id_cliente";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@id_cliente", cliente.id_cliente);

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
                String sql = "SELECT * FROM tbCliente WHERE id_cliente LIKE '%" + keywords + "%' or nome_cliente LIKE '%" + keywords + "%' or sobrenome_cliente LIKE '%" + keywords + "%'";


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

        #region Metodo para pesquisar cliente exibido na tela de vendas
        public ClienteClass pesquisaParaTransacao(string keywords)
        {
            ClienteClass cliente = new ClienteClass();
            SqlConnection conn = new SqlConnection(myconnstring);
            DataTable dt = new DataTable();
            try
            {
                String sql = "SELECT nome_cliente, sobrenome_cliente, email_cliente, phone_cliente, endereco_cliente  FROM tbCliente" +
                    " WHERE id_cliente  LIKE '%" + keywords + "%' or nome_cliente LIKE '%" + keywords + "%' or sobrenome_cliente LIKE '%" + keywords + "%'";


                SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);
                conn.Open();
                adapter.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    cliente.nome_cliente = dt.Rows[0]["nome_cliente"].ToString();
                    cliente.sobrenome_cliente = dt.Rows[0]["sobrenome_cliente"].ToString();
                    cliente.email_cliente = dt.Rows[0]["email_cliente"].ToString();
                    cliente.phone_cliente = dt.Rows[0]["phone_cliente"].ToString();
                    cliente.endereco_cliente = dt.Rows[0]["endereco_cliente"].ToString();

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
            return cliente;
        }
        #endregion
    }
}
