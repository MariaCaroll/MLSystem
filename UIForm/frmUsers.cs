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
        UserData usuarioData = new UserData();

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

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            usuarioClass.first_name = txtNomeUser.Text;
            usuarioClass.last_name = txtSobrenomeUser.Text;
            usuarioClass.email = txtEmail.Text;
            usuarioClass.phone = txtPhoneUserE.Text;
            usuarioClass.denger = cbxSexoUser.Text;
            usuarioClass.username = txtLoginUser.Text;
            usuarioClass.password = txtSenhaUser.Text;
            usuarioClass.zip_code = txtCepUsere.Text;
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
            if( success == true)
            {
                MessageBox.Show("Usuário Cadastrado com Sucesso!!");
            }
            else
            {
                MessageBox.Show("Erro ao Cadastrado usuário!!");
            }

            DataTable dt = usuarioData.Select();
            tblUser.DataSource = dt;

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
