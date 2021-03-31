using MLSystem.Class;
using MLSystem.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MLSystem.UIForm
{
    public partial class frmUsers : Form
    {
        public frmUsers()
        {
            InitializeComponent();
        }

        UserClass usuarioClass = new UserClass();
        UserDAO usuarioData = new UserDAO();

        
        // inicia a tabela com dados do banco, se estiver vazio não lista nada
        private void frmUsers_Load(object sender, EventArgs e)
        {
            DataTable dt = usuarioData.Select();
            tblUser.DataSource = dt;
            tblUser.Columns[0].HeaderText = "ID";
            tblUser.Columns[1].HeaderText = "Nome";
            tblUser.Columns[2].HeaderText = "Sobrenome";
            tblUser.Columns[3].HeaderText = "Email";
            tblUser.Columns[4].HeaderText = "Phone";
            tblUser.Columns[5].HeaderText = "Sexo";
            tblUser.Columns[6].HeaderText = "CEP";
            tblUser.Columns[7].HeaderText = "Estado";
            tblUser.Columns[8].HeaderText = "Endereço";
            tblUser.Columns[9].HeaderText = "Cidade";
            tblUser.Columns[10].HeaderText = "Bairro";
            tblUser.Columns[11].HeaderText = "Numero";
            tblUser.Columns[12].HeaderText = "Login";
            tblUser.Columns[13].HeaderText = "Senha";
            tblUser.Columns[14].HeaderText = "Tipo_Usuário";
            tblUser.Columns[15].HeaderText = "Data_Hora";
            tblUser.Columns[16].HeaderText = "Cadastrado_Por";
            
        }

        // metodo para adicionar o usuário no banco de dados
        private void btnAddUser_Click(object sender, EventArgs e)
        {
            usuarioClass.first_name = txtNomeUser.Text;
            usuarioClass.last_name = txtSobrenomeUser.Text;
            usuarioClass.email = txtEmail.Text;
            usuarioClass.phone = txtPhoneUser.Text;
            usuarioClass.denger = cbxSexoUser.Text;
            usuarioClass.zip_code = txtCepUser.Text;
            usuarioClass.state = cbxUFUser.Text;
            usuarioClass.address = txtEnderecoUser.Text;
            usuarioClass.city = txtCidadeUser.Text;
            usuarioClass.neighborhood = txtBairroUser.Text;
            usuarioClass.number = txtNumeroUser.Text;
            usuarioClass.username = txtLoginUser.Text;
            usuarioClass.password = txtSenhaUser.Text;
            usuarioClass.user_type = cbxTipoUser.Text;
            usuarioClass.created_date = DateTime.Now;
            usuarioClass.created_by = 1;

            bool success = usuarioData.Insert(usuarioClass);
            if (success == true)
            {
                MessageBox.Show("Usuário Cadastrado com Sucesso!!");
                limpar();
            }
            else
            {
                MessageBox.Show("Erro ao Cadastrado usuário!!");
            }
            // attualiza a tabela de tal ação
            DataTable dt = usuarioData.Select();
            tblUser.DataSource = dt;

        }

        // atualiza as informações do usuário cadastrado
        private void btnAtualizarUser_Click(object sender, EventArgs e)
        {
            usuarioClass.id_user = Convert.ToInt32(txtCodigoUser.Text);
            usuarioClass.first_name = txtNomeUser.Text;
            usuarioClass.last_name = txtSobrenomeUser.Text;
            usuarioClass.email = txtEmail.Text;
            usuarioClass.phone = txtPhoneUser.Text;
            usuarioClass.denger = cbxSexoUser.Text;
            usuarioClass.zip_code = txtCepUser.Text;
            usuarioClass.state = cbxUFUser.Text;
            usuarioClass.address = txtEnderecoUser.Text;
            usuarioClass.city = txtCidadeUser.Text;
            usuarioClass.neighborhood = txtBairroUser.Text;
            usuarioClass.number = txtNumeroUser.Text;
            usuarioClass.username = txtLoginUser.Text;
            usuarioClass.password = txtSenhaUser.Text;
            usuarioClass.user_type = cbxTipoUser.Text;
            usuarioClass.created_date = DateTime.Now;
            usuarioClass.created_by = 1;

            bool success = usuarioData.Update(usuarioClass);
            if (success == true)
            {
                MessageBox.Show("Usuário atualizado com sucesso!!");
                limpar();
            }
            else
            {
                MessageBox.Show("Erro ao atualizar usuário!!");
            }

            // attualiza a tabela de tal ação
            DataTable dt = usuarioData.Select();
            tblUser.DataSource = dt;
        }

        // metodo para exluir os dados 
        private void btnExcluiUser_Click(object sender, EventArgs e)
        {
            usuarioClass.id_user = Convert.ToInt32(txtCodigoUser.Text);
                
            bool success = usuarioData.Delete(usuarioClass);
            if (success == true)
            {
                MessageBox.Show("Usuário Excluido com sucesso!!");
                limpar();
            }
            else
            {
                MessageBox.Show("Erro ao excluir usuário!!");
            }

            // attualiza a tabela de tal ação
            DataTable dt = usuarioData.Select();
            tblUser.DataSource = dt;
        }
        
        // Ordem do banco de dados [0] = id e assim por diante
        // quando clicar em uma linha da tabela as informações vao para o campo de texto
        private void tblUser_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowIndex = e.RowIndex;
            
            txtCodigoUser.Text = tblUser.Rows[rowIndex].Cells[0].Value.ToString();
            txtNomeUser.Text = tblUser.Rows[rowIndex].Cells[1].Value.ToString();
            txtSobrenomeUser.Text = tblUser.Rows[rowIndex].Cells[2].Value.ToString();
            txtEmail.Text = tblUser.Rows[rowIndex].Cells[3].Value.ToString();
            txtPhoneUser.Text = tblUser.Rows[rowIndex].Cells[4].Value.ToString();
            cbxSexoUser.Text = tblUser.Rows[rowIndex].Cells[5].Value.ToString();
            txtCepUser.Text = tblUser.Rows[rowIndex].Cells[6].Value.ToString();
            cbxUFUser.Text = tblUser.Rows[rowIndex].Cells[7].Value.ToString();
            txtEnderecoUser.Text = tblUser.Rows[rowIndex].Cells[8].Value.ToString();
            txtCidadeUser.Text = tblUser.Rows[rowIndex].Cells[9].Value.ToString();
            txtBairroUser.Text = tblUser.Rows[rowIndex].Cells[10].Value.ToString();
            txtNumeroUser.Text = tblUser.Rows[rowIndex].Cells[11].Value.ToString();
            txtLoginUser.Text = tblUser.Rows[rowIndex].Cells[12].Value.ToString();
            txtSenhaUser.Text = tblUser.Rows[rowIndex].Cells[13].Value.ToString();
            cbxTipoUser.Text = tblUser.Rows[rowIndex].Cells[14].Value.ToString();
            //cbxTipoUser.Text = tblUser.Rows[rowIndex].Cells[15].Value.ToString();
           // cbxTipoUser.Text = tblUser.Rows[rowIndex].Cells[16].Value.ToString();

        }

        // metodo para limpar os campos
        private void limpar()
        {
            txtCodigoUser.Text = "";
            txtNomeUser.Text = "";
            txtSobrenomeUser.Text = "";
            txtEmail.Text = "";
            txtPhoneUser.Text = "";
            cbxSexoUser.Text = "";
            txtCepUser.Text = "";
            cbxUFUser.Text = "";
            txtEnderecoUser.Text = "";
            txtCidadeUser.Text = "";
            txtBairroUser.Text = "";
            txtNumeroUser.Text = "";
            txtLoginUser.Text = "";
            txtSenhaUser.Text = "";
            cbxTipoUser.Text = "";
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        
       
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            limpar();
        }

        private void txtPesquisaUser_TextChanged(object sender, EventArgs e)
        {
            string keywords = txtPesquisaUser.Text;
            if (keywords != null)
            {
                DataTable dt = usuarioData.Search(keywords);
                tblUser.DataSource = dt;
            }
            else
            {
                DataTable dt = usuarioData.Search();
                tblUser.DataSource = dt;
            }
        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {
            
        }
    }
}
