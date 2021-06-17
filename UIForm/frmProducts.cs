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
    public partial class frmProducts : Form
    {
        public frmProducts()
        {
            InitializeComponent();
        }
        ProdutoDAO produtoDao = new ProdutoDAO();
        ProdutoClass produtoClass = new ProdutoClass();
        public string foto = null;

        // insanciado pra popular o combobox
        CategoryDAO categoryDao = new CategoryDAO();

   
        //carrega  a table
        // popula o compbo bonx
        private void frmProducts_Load(object sender, EventArgs e)

        {
            // carrega o tabela com os dados do banco 
            tableLoad();
            // carrega o combobox com os dados da categoria
            categorias();
        }

        // Ordem do banco de dados [0] = id e assim por diante
        // quando clicar em uma linha da tabela as informações vao para o campo de texto
        private void tblProduto_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowIndex = e.RowIndex;

            txtCodigo.Text = tblProduto.Rows[rowIndex].Cells[0].Value.ToString();
            txtNome.Text = tblProduto.Rows[rowIndex].Cells[1].Value.ToString();
            cbCategoria.Text = tblProduto.Rows[rowIndex].Cells[2].Value.ToString();
            txtDescricao.Text = tblProduto.Rows[rowIndex].Cells[3].Value.ToString();
            txtPreco.Text = tblProduto.Rows[rowIndex].Cells[4].Value.ToString();
            txtQtd.Text = tblProduto.Rows[rowIndex].Cells[5].Value.ToString();
        }

      

        //metodo para adicionar produto
        private void btnAddProduto_Click(object sender, EventArgs e)
        {
            produtoClass.nome_produto = txtNome.Text;
            produtoClass.categoria = cbCategoria.Text;
            produtoClass.descricao = txtDescricao.Text;
            produtoClass.valor = txtPreco.Text;
            produtoClass.quantidade = txtQtd.Text;
            produtoClass.data_criacao = DateTime.Now;
            produtoClass.criado_por = 1;

            // seria a imagem mas não ta dando
            /*produtoClass.imagem = Convert.ToString(picture.Image);
           
            imagem(); */

            bool success = produtoDao.Insert(produtoClass);
            if (success == true)
            {
                MessageBox.Show("Produto Cadastrado com Sucesso!!");
                limpar();
            }
            else
            {
                MessageBox.Show("Erro ao Cadastrado produto!!");
            }
            // attualiza a tabela de tal ação
            DataTable dt = produtoDao.Select();
            tblProduto.DataSource = dt;

        }
        private void btnLimpar_Click(object sender, EventArgs e)
        {
            limpar();
        }

        //metodo para alterar produto
        private void btnAlterarProduto_Click(object sender, EventArgs e)
        {
            produtoClass.id_produto = Convert.ToInt32(txtCodigo.Text);
            produtoClass.nome_produto = txtNome.Text;
            produtoClass.categoria = cbCategoria.Text;
            produtoClass.descricao = txtDescricao.Text;
            produtoClass.valor = txtPreco.Text;
            produtoClass.quantidade = txtQtd.Text;
            produtoClass.data_criacao = DateTime.Now;
            produtoClass.criado_por = 1;
            

            bool success = produtoDao.Update(produtoClass);
            if (success == true)
            {
                MessageBox.Show("Produto alterado com Sucesso!!");
                limpar();
            }
            else
            {
                MessageBox.Show("Erro ao alterado produto!!");
            }
            // attualiza a tabela de tal ação
            DataTable dt = produtoDao.Select();
            tblProduto.DataSource = dt;
        }

        //metodo para excluir produto
        private void btnExluirProduto_Click(object sender, EventArgs e)
        {
            produtoClass.id_produto = Convert.ToInt32(txtCodigo.Text);

            bool success = produtoDao.Delete(produtoClass);
            if (success == true)
            {
                MessageBox.Show("Produto Excluido com sucesso!!");
                limpar();
            }
            else
            {
                MessageBox.Show("Erro ao excluir produto!!");
            }

            // attualiza a tabela de tal ação
            DataTable dt = produtoDao.Select();
            tblProduto.DataSource = dt;
        }

        //metodo para limpar os campos
        public void limpar()
        {
            txtCodigo.Text = "";
            txtNome.Text = "";
            cbCategoria.Text = "";
            txtDescricao.Text = "";
            txtPreco.Text = "";
            txtQtd.Text = "";

        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        // metodo para fazer pesquisa do produto no txtpesquisa
        private void txtPesquisarProduto_TextChanged(object sender, EventArgs e)
        {
            string keywords = txtPesquisarProduto.Text;
            if (keywords != null)
            {
                DataTable dt = produtoDao.Search(keywords);
                tblProduto.DataSource = dt;
            }
            else
            {
                DataTable dt = produtoDao.Search();
                tblProduto.DataSource = dt;
            }
        }

        //metodo para carregar a tabela
        public void tableLoad()
        {
            DataTable dt = produtoDao.Select();

            tblProduto.DataSource = dt;
            tblProduto.Columns[0].HeaderText = "ID";
            tblProduto.Columns[1].HeaderText = "Nome";
            tblProduto.Columns[2].HeaderText = "Categoria";
            tblProduto.Columns[3].HeaderText = "Descrição";
            tblProduto.Columns[4].HeaderText = "valor";
            tblProduto.Columns[5].HeaderText = "QTD";
            tblProduto.Columns[6].HeaderText = "Data_Criação";
            tblProduto.Columns[7].HeaderText = "Criado_Por";
        }

        //metodo para popular o combobox da categoria
        public void categorias()
        {
            DataTable categoria = categoryDao.Select();
            cbCategoria.DataSource = categoria;
            cbCategoria.DisplayMember = "title";
            cbCategoria.ValueMember = "title";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

     

        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {

        }

        // metodo para procurar a foto ta cert
        private void btnUpload_Click(object sender, EventArgs e)
        {
            // deu certo
            OpenFileDialog od = new OpenFileDialog();
            //outra alternativa
            if( od.ShowDialog() == DialogResult.OK)
            {
                foto = od.FileName;
                picture.Image = Image.FromFile(od.FileName);
            }

        
        }

        // metodoo do bit da imagem
        public void imagem()
        {
            Image img = picture.Image;
            byte[] arr;
            ImageConverter convert = new ImageConverter();
            arr = (byte[])convert.ConvertTo(img, typeof(byte[]));
                           
        }
    }
}
