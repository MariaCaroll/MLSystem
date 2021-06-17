using MLSystem.UIForm;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MLSystem
{
    public partial class frmUserDashbord : Form
    {
        public frmUserDashbord()
        {
            InitializeComponent();
        }

        public static String transacaoTipo;

        private void storeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void lbDateTime_Click(object sender, EventArgs e)
        {

        }

        private void frmUserDashbord_Load(object sender, EventArgs e)
        {

        }

        // quando o aplicativo é fechado exibir a tela de login
        private void frmUserDashbord_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmLogin login = new frmLogin();
            login.Show();
            this.Hide();
        }

        private void lojaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            transacaoTipo = "Compras";
            frmVendas compra = new frmVendas();           
            compra.Show();
            
        }

        private void vendaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            transacaoTipo = "Vendas";
            frmVendas venda = new frmVendas();
            venda.Show();
            
        }
    }
}
