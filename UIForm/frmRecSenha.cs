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
    public partial class frmRecSenha : Form
    {
        public frmRecSenha()
        {
            InitializeComponent();
        }

        UserClass usuarioClass = new UserClass();
        UserDAO usuarioData = new UserDAO();
        RecSenhaDAO senhaData = new RecSenhaDAO();
        RecSenhaClass senhaClass = new RecSenhaClass();

        // atualiza as informações do usuário cadastrado
        private void btnAtualizarUser_Click(object sender, EventArgs e)
        {
            //           usuarioClass.id_usuario = Convert.ToInt32(lblID.Text);
            //usuarioClass.cpf_usuario = lblcpf.Text;
            //usuarioClass.senha = txtConfirmaSenha.Text;     

            senhaClass.confirma_senha = txtConfirmaSenha.Text;
            senhaClass.cpf_usuario = lblcpf.Text;


            bool success = senhaData.UpdateSenha(senhaClass);
            if (success == true)
            {
                MessageBox.Show("Senha alterada com sucesso!!");
                limpar();
            }
            else
            {
                MessageBox.Show("Erro ao salvar a senha usuário!!");
            }
        }

        private void bntSalvar_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void limpar()
        {
            txtConfirmaSenha.Text = "";
            txtNovaSenha.Text = "";
        }
    }
}
