using MLSystem.Class;
using MLSystem.DAO;
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
    public partial class frmLostSenha : Form
    {
        public frmLostSenha()
        {
            InitializeComponent();
        }


        LoginClass loginClass = new LoginClass();
        LoginDAO loginDao = new LoginDAO();
        UserDAO userDao = new UserDAO();
        UserClass userClass = new UserClass();

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            frmLogin login = new frmLogin();
            login.Show();
            this.Dispose();
        }

      


        private void btnContinuar_Click(object sender, EventArgs e)
        {
            userClass.login = txtLogin.Text.Trim();
            userClass.cpf_usuario = mkCpf.Text.Trim();
            userClass.recuperacao_senha = txtRecuera.Text.Trim();


            if (txtLogin.Text == userClass.login && mkCpf.Text == userClass.cpf_usuario && txtRecuera.Text == userClass.recuperacao_senha)
            {

                frmRecSenha senha = new frmRecSenha();
                senha.Show();
                senha.lblUsuario.Text = userClass.login;
                senha.lblcpf.Text = userClass.cpf_usuario;
                senha.lblID.Text = Convert.ToString(userClass.id_usuario);
                MessageBox.Show("Ok");
                this.Hide();

            }
            else
            {
                MessageBox.Show("Erro, Verifique os dados informados!!");

            }

        }
    }
}
