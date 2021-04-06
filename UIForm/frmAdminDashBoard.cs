using MLSystem.Class;
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
    public partial class frmAdminDashBoard : Form
    {
        public frmAdminDashBoard()
        {
            InitializeComponent();
        }
        LoginClass loginClass = new LoginClass();

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void userToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUsers user = new frmUsers();
            user.Show();
            
        }

        private void productToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmProducts user = new frmProducts();
            user.Show();
        }

        private void categoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCategory cat = new frmCategory();
            cat.Show();
        }

        private void frmAdminDashBoard_Load(object sender, EventArgs e)
        {
            timer2.Start();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void lbDateTime_Click(object sender, EventArgs e)
        {

        }

        private void timer_ValueChanged(object sender, EventArgs e)
        {
           
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            DateTime datetime = DateTime.Now;
            this.lbltime.Text = datetime.ToString();
        }
    }
}
