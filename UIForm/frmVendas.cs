using MLSystem.Class;
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
    public partial class frmVendas : Form
    {
        public frmVendas()
        {
            InitializeComponent();
        }

        ClienteDAO cliDao = new ClienteDAO();

        private void frmVendas_Load(object sender, EventArgs e)
        {
            string tipo = frmUserDashbord.transacaoTipo;
            lblTopo.Text = tipo;
        }

        private void txtPesquisaCliente_TextChanged(object sender, EventArgs e)
        {
            string keyword = txtPesquisaCliente.Text;
            if (keyword == "")
            {
                txtNomeCliente.Text = "";
                txtSobrenomeCliente.Text = "";
                txtEmailCliente.Text = "";
                txtContatoCliente.Text = "";
                txtEnderecoCliente.Text = "";
            }

            ClienteClass cliente = cliDao.pesquisaParaTransacao(keyword);
            txtNomeCliente.Text = cliente.nome_cliente;
            txtSobrenomeCliente.Text = cliente.sobrenome_cliente;
            txtEmailCliente.Text = cliente.email_cliente;
            txtContatoCliente.Text = cliente.phone_cliente;
            txtEnderecoCliente.Text = cliente.endereco_cliente;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

     
    }
}
