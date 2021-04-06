namespace MLSystem.UIForm
{
    partial class frmUsers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUsers));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCodigoUser = new System.Windows.Forms.TextBox();
            this.txtNomeUser = new System.Windows.Forms.TextBox();
            this.txtSobrenomeUser = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCidadeUser = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtLoginUser = new System.Windows.Forms.TextBox();
            this.txtBairroUser = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtSenhaUser = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.txtNumeroUser = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.cbxTipoUser = new System.Windows.Forms.ComboBox();
            this.cbxUFUser = new System.Windows.Forms.ComboBox();
            this.cbxSexoUser = new System.Windows.Forms.ComboBox();
            this.txtPesquisaUser = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.tblUser = new System.Windows.Forms.DataGridView();
            this.btnAddUser = new System.Windows.Forms.Button();
            this.btnAtualizarUser = new System.Windows.Forms.Button();
            this.btnExcluiUser = new System.Windows.Forms.Button();
            this.txtEnderecoUser = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txtPhoneUser = new System.Windows.Forms.MaskedTextBox();
            this.txtCepUser = new System.Windows.Forms.MaskedTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblUser)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1254, 56);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1211, 11);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(31, 31);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Oswald", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(540, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Formulário de Usuários";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Codigo:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nome:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Sobrenome:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // txtCodigoUser
            // 
            this.txtCodigoUser.Enabled = false;
            this.txtCodigoUser.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigoUser.Location = new System.Drawing.Point(103, 73);
            this.txtCodigoUser.Name = "txtCodigoUser";
            this.txtCodigoUser.Size = new System.Drawing.Size(92, 26);
            this.txtCodigoUser.TabIndex = 5;
            // 
            // txtNomeUser
            // 
            this.txtNomeUser.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeUser.Location = new System.Drawing.Point(88, 104);
            this.txtNomeUser.Name = "txtNomeUser";
            this.txtNomeUser.Size = new System.Drawing.Size(344, 26);
            this.txtNomeUser.TabIndex = 6;
            this.txtNomeUser.TextChanged += new System.EventHandler(this.txtNomeUser_TextChanged);
            // 
            // txtSobrenomeUser
            // 
            this.txtSobrenomeUser.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSobrenomeUser.Location = new System.Drawing.Point(140, 136);
            this.txtSobrenomeUser.Name = "txtSobrenomeUser";
            this.txtSobrenomeUser.Size = new System.Drawing.Size(295, 26);
            this.txtSobrenomeUser.TabIndex = 7;
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(91, 169);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(344, 26);
            this.txtEmail.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 198);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 25);
            this.label5.TabIndex = 9;
            this.label5.Text = "Telefone:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 169);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 25);
            this.label6.TabIndex = 8;
            this.label6.Text = "Email:";
            // 
            // txtCidadeUser
            // 
            this.txtCidadeUser.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCidadeUser.Location = new System.Drawing.Point(101, 313);
            this.txtCidadeUser.Name = "txtCidadeUser";
            this.txtCidadeUser.Size = new System.Drawing.Size(335, 26);
            this.txtCidadeUser.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(13, 307);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 25);
            this.label7.TabIndex = 13;
            this.label7.Text = "Cidade:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(12, 233);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 25);
            this.label8.TabIndex = 12;
            this.label8.Text = "CEP:";
            // 
            // txtLoginUser
            // 
            this.txtLoginUser.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLoginUser.Location = new System.Drawing.Point(101, 376);
            this.txtLoginUser.Name = "txtLoginUser";
            this.txtLoginUser.Size = new System.Drawing.Size(136, 26);
            this.txtLoginUser.TabIndex = 19;
            // 
            // txtBairroUser
            // 
            this.txtBairroUser.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBairroUser.Location = new System.Drawing.Point(101, 347);
            this.txtBairroUser.Name = "txtBairroUser";
            this.txtBairroUser.Size = new System.Drawing.Size(194, 26);
            this.txtBairroUser.TabIndex = 18;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(13, 371);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(68, 25);
            this.label9.TabIndex = 17;
            this.label9.Text = "Login:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(13, 342);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(76, 25);
            this.label10.TabIndex = 16;
            this.label10.Text = "Bairro:";
            // 
            // txtSenhaUser
            // 
            this.txtSenhaUser.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSenhaUser.Location = new System.Drawing.Point(325, 377);
            this.txtSenhaUser.Name = "txtSenhaUser";
            this.txtSenhaUser.PasswordChar = '*';
            this.txtSenhaUser.Size = new System.Drawing.Size(110, 26);
            this.txtSenhaUser.TabIndex = 22;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(13, 411);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(162, 25);
            this.label11.TabIndex = 21;
            this.label11.Text = "Tipo de Usuário:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(243, 371);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(72, 25);
            this.label12.TabIndex = 20;
            this.label12.Text = "Senha:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(181, 233);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(79, 25);
            this.label13.TabIndex = 24;
            this.label13.Text = "Estado:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(269, 197);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(59, 25);
            this.label14.TabIndex = 26;
            this.label14.Text = "Sexo:";
            // 
            // txtNumeroUser
            // 
            this.txtNumeroUser.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumeroUser.Location = new System.Drawing.Point(352, 347);
            this.txtNumeroUser.Name = "txtNumeroUser";
            this.txtNumeroUser.Size = new System.Drawing.Size(84, 26);
            this.txtNumeroUser.TabIndex = 29;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(305, 341);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(41, 25);
            this.label15.TabIndex = 28;
            this.label15.Text = "Nº:";
            // 
            // cbxTipoUser
            // 
            this.cbxTipoUser.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxTipoUser.FormattingEnabled = true;
            this.cbxTipoUser.Items.AddRange(new object[] {
            "Admin",
            "User"});
            this.cbxTipoUser.Location = new System.Drawing.Point(187, 417);
            this.cbxTipoUser.Name = "cbxTipoUser";
            this.cbxTipoUser.Size = new System.Drawing.Size(249, 27);
            this.cbxTipoUser.TabIndex = 30;
            // 
            // cbxUFUser
            // 
            this.cbxUFUser.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxUFUser.FormattingEnabled = true;
            this.cbxUFUser.Items.AddRange(new object[] {
            "AC",
            "AL",
            "AP",
            "AM",
            "BA",
            "CE",
            "ES",
            "GO",
            "MA",
            "MT",
            "MS",
            "MG",
            "PA",
            "PB",
            "PR",
            "PE",
            "PI",
            "RJ",
            "RS",
            "RO",
            "RR",
            "SC",
            "SP",
            "SE",
            "TO",
            "DF"});
            this.cbxUFUser.Location = new System.Drawing.Point(274, 238);
            this.cbxUFUser.Name = "cbxUFUser";
            this.cbxUFUser.Size = new System.Drawing.Size(161, 27);
            this.cbxUFUser.TabIndex = 31;
            // 
            // cbxSexoUser
            // 
            this.cbxSexoUser.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxSexoUser.FormattingEnabled = true;
            this.cbxSexoUser.Items.AddRange(new object[] {
            "F",
            "M"});
            this.cbxSexoUser.Location = new System.Drawing.Point(334, 201);
            this.cbxSexoUser.Name = "cbxSexoUser";
            this.cbxSexoUser.Size = new System.Drawing.Size(101, 27);
            this.cbxSexoUser.TabIndex = 32;
            // 
            // txtPesquisaUser
            // 
            this.txtPesquisaUser.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPesquisaUser.Location = new System.Drawing.Point(671, 67);
            this.txtPesquisaUser.Name = "txtPesquisaUser";
            this.txtPesquisaUser.Size = new System.Drawing.Size(344, 26);
            this.txtPesquisaUser.TabIndex = 34;
            this.txtPesquisaUser.TextChanged += new System.EventHandler(this.txtPesquisaUser_TextChanged);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(561, 68);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(104, 25);
            this.label16.TabIndex = 33;
            this.label16.Text = "Pesquisa:";
            // 
            // tblUser
            // 
            this.tblUser.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tblUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblUser.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.tblUser.Location = new System.Drawing.Point(467, 105);
            this.tblUser.Name = "tblUser";
            this.tblUser.Size = new System.Drawing.Size(775, 288);
            this.tblUser.TabIndex = 35;
            this.tblUser.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tblUser_CellContentClick);
            this.tblUser.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.tblUser_RowHeaderMouseClick);
            // 
            // btnAddUser
            // 
            this.btnAddUser.Image = ((System.Drawing.Image)(resources.GetObject("btnAddUser.Image")));
            this.btnAddUser.Location = new System.Drawing.Point(494, 408);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.Size = new System.Drawing.Size(75, 65);
            this.btnAddUser.TabIndex = 36;
            this.btnAddUser.UseVisualStyleBackColor = true;
            this.btnAddUser.Click += new System.EventHandler(this.btnAddUser_Click);
            // 
            // btnAtualizarUser
            // 
            this.btnAtualizarUser.Image = ((System.Drawing.Image)(resources.GetObject("btnAtualizarUser.Image")));
            this.btnAtualizarUser.Location = new System.Drawing.Point(1050, 411);
            this.btnAtualizarUser.Name = "btnAtualizarUser";
            this.btnAtualizarUser.Size = new System.Drawing.Size(77, 65);
            this.btnAtualizarUser.TabIndex = 37;
            this.btnAtualizarUser.UseVisualStyleBackColor = true;
            this.btnAtualizarUser.Click += new System.EventHandler(this.btnAtualizarUser_Click);
            // 
            // btnExcluiUser
            // 
            this.btnExcluiUser.Image = ((System.Drawing.Image)(resources.GetObject("btnExcluiUser.Image")));
            this.btnExcluiUser.Location = new System.Drawing.Point(1167, 408);
            this.btnExcluiUser.Name = "btnExcluiUser";
            this.btnExcluiUser.Size = new System.Drawing.Size(75, 65);
            this.btnExcluiUser.TabIndex = 38;
            this.btnExcluiUser.UseVisualStyleBackColor = true;
            this.btnExcluiUser.Click += new System.EventHandler(this.btnExcluiUser_Click);
            // 
            // txtEnderecoUser
            // 
            this.txtEnderecoUser.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEnderecoUser.Location = new System.Drawing.Point(118, 278);
            this.txtEnderecoUser.Name = "txtEnderecoUser";
            this.txtEnderecoUser.Size = new System.Drawing.Size(317, 26);
            this.txtEnderecoUser.TabIndex = 40;
            this.txtEnderecoUser.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(12, 272);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(103, 25);
            this.label17.TabIndex = 39;
            this.label17.Text = "Endereço:";
            this.label17.Click += new System.EventHandler(this.label17_Click);
            // 
            // txtPhoneUser
            // 
            this.txtPhoneUser.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhoneUser.Location = new System.Drawing.Point(118, 203);
            this.txtPhoneUser.Mask = "(00) 00000-0000";
            this.txtPhoneUser.Name = "txtPhoneUser";
            this.txtPhoneUser.Size = new System.Drawing.Size(127, 26);
            this.txtPhoneUser.TabIndex = 41;
            // 
            // txtCepUser
            // 
            this.txtCepUser.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCepUser.Location = new System.Drawing.Point(74, 238);
            this.txtCepUser.Mask = "00.000-000";
            this.txtCepUser.Name = "txtCepUser";
            this.txtCepUser.Size = new System.Drawing.Size(101, 26);
            this.txtCepUser.TabIndex = 42;
            // 
            // button1
            // 
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(636, 411);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(77, 65);
            this.button1.TabIndex = 43;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(1254, 497);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtCepUser);
            this.Controls.Add(this.txtPhoneUser);
            this.Controls.Add(this.txtEnderecoUser);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.btnExcluiUser);
            this.Controls.Add(this.btnAtualizarUser);
            this.Controls.Add(this.btnAddUser);
            this.Controls.Add(this.tblUser);
            this.Controls.Add(this.txtPesquisaUser);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.cbxSexoUser);
            this.Controls.Add(this.cbxUFUser);
            this.Controls.Add(this.cbxTipoUser);
            this.Controls.Add(this.txtNumeroUser);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtSenhaUser);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtLoginUser);
            this.Controls.Add(this.txtBairroUser);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtCidadeUser);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtSobrenomeUser);
            this.Controls.Add(this.txtNomeUser);
            this.Controls.Add(this.txtCodigoUser);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmUsers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Usuários:";
            this.Load += new System.EventHandler(this.frmUsers_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblUser)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCodigoUser;
        private System.Windows.Forms.TextBox txtNomeUser;
        private System.Windows.Forms.TextBox txtSobrenomeUser;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtCidadeUser;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtLoginUser;
        private System.Windows.Forms.TextBox txtBairroUser;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtSenhaUser;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtNumeroUser;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox cbxTipoUser;
        private System.Windows.Forms.ComboBox cbxUFUser;
        private System.Windows.Forms.ComboBox cbxSexoUser;
        private System.Windows.Forms.TextBox txtPesquisaUser;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.DataGridView tblUser;
        private System.Windows.Forms.Button btnAddUser;
        private System.Windows.Forms.Button btnAtualizarUser;
        private System.Windows.Forms.Button btnExcluiUser;
        private System.Windows.Forms.TextBox txtEnderecoUser;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.MaskedTextBox txtPhoneUser;
        private System.Windows.Forms.MaskedTextBox txtCepUser;
        private System.Windows.Forms.Button button1;
    }
}