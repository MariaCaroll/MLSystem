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
    public partial class frmCategory : Form
    {
        public frmCategory()
        {
            InitializeComponent();
        }
        CategoryDAO categoryDao = new CategoryDAO();
        CategoryClass categoryClass = new CategoryClass();
        UserClass userClass = new UserClass();
        UserDAO userDao = new UserDAO();

     
        // Ordem do banco de dados [0] = id e assim por diante
        // quando clicar em uma linha da tabela as informações vao para o campo de texto
        private void tblCategoria_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowIndex = e.RowIndex;

            txtID.Text = tblCategoria.Rows[rowIndex].Cells[0].Value.ToString();
            txtTitle.Text = tblCategoria.Rows[rowIndex].Cells[1].Value.ToString();
            txtDescricao.Text = tblCategoria.Rows[rowIndex].Cells[2].Value.ToString();

        }

        //metodo de para acionar pesquisa
        private void txtPesquisar_TextChanged(object sender, EventArgs e)
        {
            string keywords = txtPesquisar.Text;
            if (keywords != null)
            {
                DataTable dt = categoryDao.Search(keywords);
                tblCategoria.DataSource = dt;
            }
            else
            {
                DataTable dt = categoryDao.Search();
                tblCategoria.DataSource = dt;
            }

        }

        //metodod para adicionar categoria
        private void btnAddUser_Click(object sender, EventArgs e)
        {
            // pegar o valor inseridos no campo de texto e salvar no bd
            categoryClass.nome_categora = txtTitle.Text;
            categoryClass.descricao_categoria = txtDescricao.Text;
            categoryClass.data_criacao = DateTime.Now;


            //pegar o ID do usuário logado mas não se como
            // por enquanto eu não vou setar o 1 
            categoryClass.criado_por = 1;

            bool success = categoryDao.Insert(categoryClass);

            if (success == true)
            {
                MessageBox.Show("Categoria Cadastrada com Sucesso!!");
                limpar();
            }
            else
            {
                MessageBox.Show("Erro ao Cadastrar categoria!!");
            }
            // attualiza a tabela de tal ação
            DataTable dt = categoryDao.Select();
            tblCategoria.DataSource = dt;


        }

        //metdodo para atualizar a categoria
        private void btnAtualizarUser_Click(object sender, EventArgs e)
        {
            categoryClass.id_categoria = Convert.ToInt32(txtID.Text);
            categoryClass.nome_categora = txtTitle.Text;
            categoryClass.descricao_categoria = txtDescricao.Text;
            categoryClass.data_criacao = DateTime.Now;
            categoryClass.criado_por = 1;


            bool success = categoryDao.Update(categoryClass);
            if (success == true)
            {
                MessageBox.Show("Categoria atualizada com sucesso!!");
                limpar();
            }
            else
            {
                MessageBox.Show("Erro ao atualizar categoria!!");
            }

            // attualiza a tabela de tal ação
            DataTable dt = categoryDao.Select();
            tblCategoria.DataSource = dt;


        }

        // metodo para excluir a categoria
        private void btnExcluiUser_Click(object sender, EventArgs e)
        {
            categoryClass.id_categoria = Convert.ToInt32(txtID.Text);

            bool success = categoryDao.Delete(categoryClass);
            if (success == true)
            {
                MessageBox.Show("Categoria Excluido com sucesso!!");
                limpar();
            }
            else
            {
                MessageBox.Show("Categoria ao excluir usuário!!");
            }

            // attualiza a tabela de tal ação
            DataTable dt = categoryDao.Select();
            tblCategoria.DataSource = dt;
        }

        //metdodo para limapar os campos 
        private void button1_Click(object sender, EventArgs e)
        {
            limpar();
        }


        public void limpar()
        {
            txtDescricao.Text = "";
            txtID.Text = "";
            txtTitle.Text = "";
        }



        private void Login_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

       
        private frmAdminDashBoard frmAdminDashBoard()
        {
            throw new NotImplementedException();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        

        private void tblCategoria_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmCategory_Load(object sender, EventArgs e)
        {
            // inicia a tabela com dados do banco, se estiver vazio não lista nada


            DataTable dt = categoryDao.Select();
            tblCategoria.DataSource = dt;
            tblCategoria.Columns[0].HeaderText = "ID";
            tblCategoria.Columns[0].HeaderText = "ID";
            tblCategoria.Columns[1].HeaderText = "Titulo";
            tblCategoria.Columns[2].HeaderText = "Descrição";
            tblCategoria.Columns[3].HeaderText = "Criado_por";
            tblCategoria.Columns[4].HeaderText = "Data_da_criação";
        }
    }
}
