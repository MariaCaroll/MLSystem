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
    public partial class frmLogin : Form


    {
        public frmLogin()
        {
            InitializeComponent();
        }
        // tem que por um metodo apar apegar o id da sessão 
        public static string usuarioConectado;


        LoginClass loginClass = new LoginClass();
        LoginDAO loginDao = new LoginDAO();
        UserDAO userDao = new UserDAO();
        UserClass userClass = new UserClass();

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //clicando no botao para entrar
        private void btnlogin_Click(object sender, EventArgs e)
        {
            logar();
        }

        //quando terminar de digitar a senhar só apertar ENTER 
        private void txtSenha_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (e.KeyChar == 13)
            {

                logar();

            }

        }
        private void logar()
        {
            loginClass.login = txtLogin.Text.Trim();
            loginClass.senha = txtSenha.Text.Trim();
            loginClass.tipo_usuario = rdUser.Text.Trim();
            loginClass.tipo_usuario = rbAdmin.Text.Trim();

            if (rdUser.Checked == false && rbAdmin.Checked == false)
            {
                MessageBox.Show("Favor Selecionar um tipo de Usuário", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                if (rbAdmin.Checked == true)
                {
                    loginClass.tipo_usuario = "Admin";
                }
                else
                {
                    loginClass.tipo_usuario = "User";
                }
            }


            bool Success = loginDao.loginCheck(loginClass);
            if (Success == true)
            {
                MessageBox.Show("Login efetudado!!");
                switch (loginClass.tipo_usuario)
                {
                    case "Admin":
                        {
                            frmAdminDashBoard admin = new frmAdminDashBoard();
                            admin.Show();
                            admin.lblLogado.Text = loginClass.login.ToUpper();
                            admin.lblID.Text = Convert.ToString(userClass.id_usuario) ;

                            this.Hide();
                        }
                        break;
                    case "User":
                        {
                            frmUserDashbord user = new frmUserDashbord();
                            user.Show();
                            user.lblLogado.Text = loginClass.login.ToUpper();
                            user.lbDateTime.Text = DateTime.Now.ToString();
                            this.Hide();
                        }
                        break;
                    default:
                        {
                            MessageBox.Show("Tipo de usuário inválido!!");
                        }
                        break;
                }
            }
            else
            {
                MessageBox.Show("Erro, Verifique login e senha!!");

            }

        }

        private void txtSenha_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void lblEsquecerSenha_Click(object sender, EventArgs e)
        {
            frmLostSenha lost = new frmLostSenha();
            lost.Show();
            this.Visible = false;
        }
    }
}
