namespace MLSystem.UIForm
{
    partial class frmCategory
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCategory));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Login = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPesquisar = new System.Windows.Forms.TextBox();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tblCategoria = new System.Windows.Forms.DataGridView();
            this.btnLimparr = new System.Windows.Forms.Button();
            this.btnExcluiUser = new System.Windows.Forms.Button();
            this.btnAtualizarUser = new System.Windows.Forms.Button();
            this.btnAddUser = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblCategoria)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(757, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(35, 34);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel1.Controls.Add(this.Login);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(795, 38);
            this.panel1.TabIndex = 2;
            // 
            // Login
            // 
            this.Login.AutoSize = true;
            this.Login.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Login.Location = new System.Drawing.Point(248, 4);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(226, 25);
            this.Login.TabIndex = 1;
            this.Login.Text = "Cadatro de Categorias";
            this.Login.Click += new System.EventHandler(this.Login_Click);
            // 
            // txtTitle
            // 
            this.txtTitle.Font = new System.Drawing.Font("Cambria", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTitle.Location = new System.Drawing.Point(86, 103);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(187, 31);
            this.txtTitle.TabIndex = 7;
            // 
            // txtID
            // 
            this.txtID.Enabled = false;
            this.txtID.Font = new System.Drawing.Font("Cambria", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.Location = new System.Drawing.Point(95, 56);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(178, 31);
            this.txtID.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Cambria", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 103);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 26);
            this.label5.TabIndex = 5;
            this.label5.Text = "Titulo";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cambria", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 26);
            this.label4.TabIndex = 4;
            this.label4.Text = "Código";
            // 
            // txtPesquisar
            // 
            this.txtPesquisar.Font = new System.Drawing.Font("Cambria", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPesquisar.Location = new System.Drawing.Point(483, 58);
            this.txtPesquisar.Name = "txtPesquisar";
            this.txtPesquisar.Size = new System.Drawing.Size(236, 31);
            this.txtPesquisar.TabIndex = 11;
            this.txtPesquisar.TextChanged += new System.EventHandler(this.txtPesquisar_TextChanged);
            // 
            // txtDescricao
            // 
            this.txtDescricao.Font = new System.Drawing.Font("Cambria", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescricao.Location = new System.Drawing.Point(17, 179);
            this.txtDescricao.Multiline = true;
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(239, 134);
            this.txtDescricao.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(373, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 26);
            this.label1.TabIndex = 9;
            this.label1.Text = "Pesquisar";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cambria", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 26);
            this.label2.TabIndex = 8;
            this.label2.Text = "Descricao";
            // 
            // tblCategoria
            // 
            this.tblCategoria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblCategoria.Location = new System.Drawing.Point(293, 103);
            this.tblCategoria.Name = "tblCategoria";
            this.tblCategoria.Size = new System.Drawing.Size(480, 210);
            this.tblCategoria.TabIndex = 12;
            this.tblCategoria.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tblCategoria_CellContentClick);
            this.tblCategoria.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.tblCategoria_RowHeaderMouseClick);
            // 
            // btnLimparr
            // 
            this.btnLimparr.Image = ((System.Drawing.Image)(resources.GetObject("btnLimparr.Image")));
            this.btnLimparr.Location = new System.Drawing.Point(138, 353);
            this.btnLimparr.Name = "btnLimparr";
            this.btnLimparr.Size = new System.Drawing.Size(77, 65);
            this.btnLimparr.TabIndex = 47;
            this.btnLimparr.UseVisualStyleBackColor = true;
            this.btnLimparr.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnExcluiUser
            // 
            this.btnExcluiUser.Image = ((System.Drawing.Image)(resources.GetObject("btnExcluiUser.Image")));
            this.btnExcluiUser.Location = new System.Drawing.Point(678, 353);
            this.btnExcluiUser.Name = "btnExcluiUser";
            this.btnExcluiUser.Size = new System.Drawing.Size(75, 65);
            this.btnExcluiUser.TabIndex = 46;
            this.btnExcluiUser.UseVisualStyleBackColor = true;
            this.btnExcluiUser.Click += new System.EventHandler(this.btnExcluiUser_Click);
            // 
            // btnAtualizarUser
            // 
            this.btnAtualizarUser.Image = ((System.Drawing.Image)(resources.GetObject("btnAtualizarUser.Image")));
            this.btnAtualizarUser.Location = new System.Drawing.Point(557, 353);
            this.btnAtualizarUser.Name = "btnAtualizarUser";
            this.btnAtualizarUser.Size = new System.Drawing.Size(77, 65);
            this.btnAtualizarUser.TabIndex = 45;
            this.btnAtualizarUser.UseVisualStyleBackColor = true;
            this.btnAtualizarUser.Click += new System.EventHandler(this.btnAtualizarUser_Click);
            // 
            // btnAddUser
            // 
            this.btnAddUser.Image = ((System.Drawing.Image)(resources.GetObject("btnAddUser.Image")));
            this.btnAddUser.Location = new System.Drawing.Point(42, 353);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.Size = new System.Drawing.Size(75, 65);
            this.btnAddUser.TabIndex = 44;
            this.btnAddUser.UseVisualStyleBackColor = true;
            this.btnAddUser.Click += new System.EventHandler(this.btnAddUser_Click);
            // 
            // frmCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(795, 445);
            this.Controls.Add(this.btnLimparr);
            this.Controls.Add(this.btnExcluiUser);
            this.Controls.Add(this.btnAtualizarUser);
            this.Controls.Add(this.btnAddUser);
            this.Controls.Add(this.tblCategoria);
            this.Controls.Add(this.txtPesquisar);
            this.Controls.Add(this.txtDescricao);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmCategory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Categorias:";
            this.Load += new System.EventHandler(this.frmCategory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblCategoria)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Login;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPesquisar;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView tblCategoria;
        private System.Windows.Forms.Button btnLimparr;
        private System.Windows.Forms.Button btnExcluiUser;
        private System.Windows.Forms.Button btnAtualizarUser;
        private System.Windows.Forms.Button btnAddUser;
    }
}