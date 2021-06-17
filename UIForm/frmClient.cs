using MLSystem.Class;
using MLSystem.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MLSystem.UIForm
{
    public partial class frmClient : Form
    {
        public frmClient()
        {
            InitializeComponent();
        }

        ClienteDAO clienteDao = new ClienteDAO();
        ClienteClass clienteClass = new ClienteClass();

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmClient_Load(object sender, EventArgs e)
        {

        }

        private void frmClient_Paint(object sender, PaintEventArgs e)
        {
            Graphics graphics = e.Graphics;
            Pen pen = new Pen(Color.FromArgb(96, 155, 173), 1);

            Rectangle rec = new Rectangle(0, 0, this.Width - 1, this.Height - 1);
            LinearGradientBrush blush = new LinearGradientBrush(rec, Color.FromArgb(96, 155, 173), 
                Color.FromArgb(245, 251,251), LinearGradientMode.Vertical);
            graphics.FillRectangle(blush, rec);
            graphics.DrawRectangle(pen, rec);

        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            clienteClass.nome_cliente = txtNomeCliente.Text;
            clienteClass.sobrenome_cliente = txtSobrenomeCliente.Text;
            clienteClass.email_cliente = txtEmail.Text;
            clienteClass.phone_cliente = txtPhoneCliente.Text;
            clienteClass.sexo_cliente = cbxSexoCliente.Text;
            clienteClass.cep_cliente = cbxUFCliente.Text;
            clienteClass.numero_cliente = txtNumeroCliente.Text;
            clienteClass.aniversario_cliente = mkNascimento.Text;
            clienteClass.cidade_cliente = txtCidadeCliente.Text;
            clienteClass.bairro_cliente = txtBairroCliente.Text;
            clienteClass.endereco_cliente = txtEnderecoCliente.Text;
            clienteClass.data_criacao = DateTime.Now;
            clienteClass.criado_por = 1;


            bool success = clienteDao.Insert(clienteClass);
            if (success == true)
            {
                MessageBox.Show("Cliente Cadastrado com Sucesso!!");
                limpar();
            }
            else
            {
                MessageBox.Show("Erro ao Cadastrado Cliente!!");
            }
            // attualiza a tabela de tal ação
            DataTable dt = clienteDao.Select();
            tblCliente.DataSource = dt;
        }

        private void limpar()
        {
            txtNomeCliente.Text = "";
            txtSobrenomeCliente.Text = "";
            txtEmail.Text = "";
            txtPhoneCliente.Text = "";
            cbxSexoCliente.Text = "";
            
            cbxUFCliente.Text = "";
            txtNumeroCliente.Text = "";
            txtCidadeCliente.Text = "";
            txtBairroCliente.Text = "";
            txtEnderecoCliente.Text = "";
          
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            limpar();
        }

        private void btnExcluiCliente_Click(object sender, EventArgs e)
        {
            clienteClass.id_cliente = Convert.ToInt32(txtCodigoCliente.Text);

            bool success = clienteDao.Delete(clienteClass);
            if (success == true)
            {
                MessageBox.Show("Cliente Excluido com sucesso!!");
                limpar();
            }
            else
            {
                MessageBox.Show("Erro ao excluir Cliente!!");
            }

            // attualiza a tabela de tal ação
            DataTable dt = clienteDao.Select();
            tblCliente.DataSource = dt;
        }

        private void btnAtualizarCliente_Click(object sender, EventArgs e)
        {

            clienteClass.id_cliente = Convert.ToInt32(txtCodigoCliente.Text);
            clienteClass.nome_cliente = txtNomeCliente.Text;
            clienteClass.sobrenome_cliente = txtSobrenomeCliente.Text;
            clienteClass.email_cliente = txtEmail.Text;
            clienteClass.phone_cliente = txtPhoneCliente.Text;
            clienteClass.sexo_cliente = cbxSexoCliente.Text;
            clienteClass.cep_cliente = cbxUFCliente.Text;
            clienteClass.numero_cliente = txtNumeroCliente.Text;
            clienteClass.aniversario_cliente = mkNascimento.Text;
            clienteClass.cidade_cliente = txtCidadeCliente.Text;
            clienteClass.bairro_cliente = txtBairroCliente.Text;
            clienteClass.endereco_cliente = txtEnderecoCliente.Text;
            clienteClass.data_criacao = DateTime.Now;
            clienteClass.criado_por = 1;


            bool success = clienteDao.Insert(clienteClass);
            if (success == true)
            {
                MessageBox.Show("Cliente alterado com Sucesso!!");
                limpar();
            }
            else
            {
                MessageBox.Show("Erro ao alterado cliente!!");
            }
            // attualiza a tabela de tal ação
            DataTable dt = clienteDao.Select();
            tblCliente.DataSource = dt;
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
