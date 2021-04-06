﻿using MLSystem.Class;
using MLSystem.DAO;
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



        LoginClass loginClass = new LoginClass();
        LoginDAO loginDao = new LoginDAO();

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
            loginClass.username = txtLogin.Text.Trim();
            loginClass.password = txtSenha.Text.Trim();
            loginClass.type_user = rdUser.Text.Trim();
            loginClass.type_user = rbAdmin.Text.Trim();

            if (rdUser.Checked == false && rbAdmin.Checked == false)
            {
                MessageBox.Show("Favor Selecionar um tipo de Usuário", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                if (rbAdmin.Checked == true)
                {
                    loginClass.type_user = "Admin";
                }
                else
                {
                    loginClass.type_user = "User";
                }
            }


            bool Success = loginDao.loginCheck(loginClass);
            if (Success == true)
            {
                MessageBox.Show("Login efetudado!!");
                switch (loginClass.type_user)
                {
                    case "Admin":
                        {
                            frmAdminDashBoard admin = new frmAdminDashBoard();
                            admin.Show();
                            admin.lblLogado.Text = loginClass.username.ToUpper();
                            this.Hide();
                        }
                        break;
                    case "User":
                        {
                            frmUserDashbord user = new frmUserDashbord();
                            user.Show();
                            user.lblLogado.Text = loginClass.username.ToUpper();
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
    }
}
