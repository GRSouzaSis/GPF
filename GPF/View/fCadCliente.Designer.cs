namespace GPF.View
{
    partial class fCadCliente
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pDgvLocaliza = new System.Windows.Forms.Panel();
            this.pBuscas = new System.Windows.Forms.Panel();
            this.bBuscar = new FontAwesome.Sharp.IconButton();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.dgvCadastro = new System.Windows.Forms.DataGridView();
            this.cli_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cli_nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cli_sobrenome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cli_cpf = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cli_rg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cli_dtnasc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cli_telefone1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cli_telefone2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cli_casado = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.cli_conjuge = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cli_conjuge_cpf = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cli_conjuge_rg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.end_logradouro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.end_bairro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cid_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.end_uf = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.end_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pButtons = new System.Windows.Forms.Panel();
            this.bExcluir = new FontAwesome.Sharp.IconButton();
            this.bAlterar = new FontAwesome.Sharp.IconButton();
            this.bNovo = new FontAwesome.Sharp.IconButton();
            this.pCrud = new System.Windows.Forms.Panel();
            this.dtpDataNasc = new System.Windows.Forms.DateTimePicker();
            this.txtRG = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txtTelefone1 = new System.Windows.Forms.MaskedTextBox();
            this.txtTelefone2 = new System.Windows.Forms.MaskedTextBox();
            this.pCadastroEnd = new System.Windows.Forms.Panel();
            this.pBotoes = new System.Windows.Forms.Panel();
            this.bCancelar = new FontAwesome.Sharp.IconButton();
            this.bSalvar = new FontAwesome.Sharp.IconButton();
            this.pEndereco = new System.Windows.Forms.Panel();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.CbbCidade = new System.Windows.Forms.ComboBox();
            this.CbbUf = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtLogradouro = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.pConjunge = new System.Windows.Forms.Panel();
            this.txtConjugeRg = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtCpfConjuge = new System.Windows.Forms.MaskedTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtNomeConjuge = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cbCasado = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCpf = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSobrenome = new System.Windows.Forms.TextBox();
            this.bMinimizar = new FontAwesome.Sharp.IconButton();
            this.bFechar = new FontAwesome.Sharp.IconButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.enderecoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pDgvLocaliza.SuspendLayout();
            this.pBuscas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCadastro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).BeginInit();
            this.pButtons.SuspendLayout();
            this.pCrud.SuspendLayout();
            this.pCadastroEnd.SuspendLayout();
            this.pBotoes.SuspendLayout();
            this.pEndereco.SuspendLayout();
            this.pConjunge.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.enderecoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // pDgvLocaliza
            // 
            this.pDgvLocaliza.BackColor = System.Drawing.Color.CadetBlue;
            this.pDgvLocaliza.Controls.Add(this.pBuscas);
            this.pDgvLocaliza.Controls.Add(this.dgvCadastro);
            this.pDgvLocaliza.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pDgvLocaliza.Location = new System.Drawing.Point(0, 0);
            this.pDgvLocaliza.Name = "pDgvLocaliza";
            this.pDgvLocaliza.Size = new System.Drawing.Size(625, 569);
            this.pDgvLocaliza.TabIndex = 9;
            // 
            // pBuscas
            // 
            this.pBuscas.BackColor = System.Drawing.Color.CadetBlue;
            this.pBuscas.Controls.Add(this.bBuscar);
            this.pBuscas.Controls.Add(this.txtDescricao);
            this.pBuscas.Dock = System.Windows.Forms.DockStyle.Top;
            this.pBuscas.Location = new System.Drawing.Point(0, 0);
            this.pBuscas.Name = "pBuscas";
            this.pBuscas.Size = new System.Drawing.Size(625, 42);
            this.pBuscas.TabIndex = 0;
            // 
            // bBuscar
            // 
            this.bBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bBuscar.BackColor = System.Drawing.Color.SeaGreen;
            this.bBuscar.FlatAppearance.BorderSize = 0;
            this.bBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bBuscar.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.bBuscar.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bBuscar.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.bBuscar.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.bBuscar.IconColor = System.Drawing.Color.WhiteSmoke;
            this.bBuscar.IconSize = 16;
            this.bBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bBuscar.Location = new System.Drawing.Point(541, 7);
            this.bBuscar.Name = "bBuscar";
            this.bBuscar.Rotation = 0D;
            this.bBuscar.Size = new System.Drawing.Size(75, 29);
            this.bBuscar.TabIndex = 2;
            this.bBuscar.Text = "   Buscar";
            this.bBuscar.UseVisualStyleBackColor = false;
            this.bBuscar.Click += new System.EventHandler(this.bBuscar_Click);
            // 
            // txtDescricao
            // 
            this.txtDescricao.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDescricao.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescricao.ForeColor = System.Drawing.Color.DarkGray;
            this.txtDescricao.Location = new System.Drawing.Point(12, 12);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(525, 21);
            this.txtDescricao.TabIndex = 0;
            this.txtDescricao.Text = "Nome ou Sobrenome ou CPF ex: 123.456.789-25";
            this.txtDescricao.Enter += new System.EventHandler(this.txtDescricao_Enter);
            this.txtDescricao.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDescricao_KeyPress);
            this.txtDescricao.Leave += new System.EventHandler(this.txtDescricao_Leave);
            // 
            // dgvCadastro
            // 
            this.dgvCadastro.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dgvCadastro.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCadastro.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvCadastro.AutoGenerateColumns = false;
            this.dgvCadastro.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvCadastro.BackgroundColor = System.Drawing.Color.DarkSlateGray;
            this.dgvCadastro.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvCadastro.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.AppWorkspace;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCadastro.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvCadastro.ColumnHeadersHeight = 40;
            this.dgvCadastro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvCadastro.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cli_id,
            this.cli_nome,
            this.cli_sobrenome,
            this.cli_cpf,
            this.cli_rg,
            this.cli_dtnasc,
            this.cli_telefone1,
            this.cli_telefone2,
            this.cli_casado,
            this.cli_conjuge,
            this.cli_conjuge_cpf,
            this.cli_conjuge_rg,
            this.end_logradouro,
            this.end_bairro,
            this.cid_id,
            this.end_uf,
            this.end_id});
            this.dgvCadastro.DataSource = this.clienteBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCadastro.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvCadastro.EnableHeadersVisualStyles = false;
            this.dgvCadastro.GridColor = System.Drawing.SystemColors.GrayText;
            this.dgvCadastro.Location = new System.Drawing.Point(12, 48);
            this.dgvCadastro.Name = "dgvCadastro";
            this.dgvCadastro.ReadOnly = true;
            this.dgvCadastro.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.AppWorkspace;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCadastro.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvCadastro.RowHeadersWidth = 20;
            this.dgvCadastro.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCadastro.Size = new System.Drawing.Size(607, 515);
            this.dgvCadastro.TabIndex = 0;
            this.dgvCadastro.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCadastro_CellDoubleClick);
            // 
            // cli_id
            // 
            this.cli_id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.cli_id.DataPropertyName = "cli_id";
            this.cli_id.HeaderText = "Código";
            this.cli_id.Name = "cli_id";
            this.cli_id.ReadOnly = true;
            this.cli_id.Width = 80;
            // 
            // cli_nome
            // 
            this.cli_nome.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.cli_nome.DataPropertyName = "cli_nome";
            this.cli_nome.HeaderText = "Nome";
            this.cli_nome.Name = "cli_nome";
            this.cli_nome.ReadOnly = true;
            this.cli_nome.Width = 73;
            // 
            // cli_sobrenome
            // 
            this.cli_sobrenome.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.cli_sobrenome.DataPropertyName = "cli_sobrenome";
            this.cli_sobrenome.HeaderText = "Sobrenome";
            this.cli_sobrenome.Name = "cli_sobrenome";
            this.cli_sobrenome.ReadOnly = true;
            this.cli_sobrenome.Width = 110;
            // 
            // cli_cpf
            // 
            this.cli_cpf.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.cli_cpf.DataPropertyName = "cli_cpf";
            this.cli_cpf.HeaderText = "CPF";
            this.cli_cpf.Name = "cli_cpf";
            this.cli_cpf.ReadOnly = true;
            this.cli_cpf.Width = 62;
            // 
            // cli_rg
            // 
            this.cli_rg.DataPropertyName = "cli_rg";
            this.cli_rg.HeaderText = "RG";
            this.cli_rg.Name = "cli_rg";
            this.cli_rg.ReadOnly = true;
            // 
            // cli_dtnasc
            // 
            this.cli_dtnasc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.cli_dtnasc.DataPropertyName = "cli_dtnasc";
            this.cli_dtnasc.HeaderText = "Data Nascimento";
            this.cli_dtnasc.Name = "cli_dtnasc";
            this.cli_dtnasc.ReadOnly = true;
            this.cli_dtnasc.Width = 134;
            // 
            // cli_telefone1
            // 
            this.cli_telefone1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.cli_telefone1.DataPropertyName = "cli_telefone1";
            this.cli_telefone1.HeaderText = "Contato";
            this.cli_telefone1.Name = "cli_telefone1";
            this.cli_telefone1.ReadOnly = true;
            this.cli_telefone1.Width = 85;
            // 
            // cli_telefone2
            // 
            this.cli_telefone2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.cli_telefone2.DataPropertyName = "cli_telefone2";
            this.cli_telefone2.HeaderText = "Contato";
            this.cli_telefone2.Name = "cli_telefone2";
            this.cli_telefone2.ReadOnly = true;
            this.cli_telefone2.Width = 85;
            // 
            // cli_casado
            // 
            this.cli_casado.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.cli_casado.DataPropertyName = "cli_casado";
            this.cli_casado.HeaderText = "Casado";
            this.cli_casado.Name = "cli_casado";
            this.cli_casado.ReadOnly = true;
            this.cli_casado.Width = 65;
            // 
            // cli_conjuge
            // 
            this.cli_conjuge.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.cli_conjuge.DataPropertyName = "cli_conjuge";
            this.cli_conjuge.HeaderText = "Nome Cônjuge";
            this.cli_conjuge.Name = "cli_conjuge";
            this.cli_conjuge.ReadOnly = true;
            this.cli_conjuge.Width = 121;
            // 
            // cli_conjuge_cpf
            // 
            this.cli_conjuge_cpf.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.cli_conjuge_cpf.DataPropertyName = "cli_conjuge_cpf";
            this.cli_conjuge_cpf.HeaderText = "Cônjuge CPF";
            this.cli_conjuge_cpf.Name = "cli_conjuge_cpf";
            this.cli_conjuge_cpf.ReadOnly = true;
            this.cli_conjuge_cpf.Width = 111;
            // 
            // cli_conjuge_rg
            // 
            this.cli_conjuge_rg.DataPropertyName = "cli_conjuge_rg";
            this.cli_conjuge_rg.HeaderText = "Cônjuge RG";
            this.cli_conjuge_rg.Name = "cli_conjuge_rg";
            this.cli_conjuge_rg.ReadOnly = true;
            // 
            // end_logradouro
            // 
            this.end_logradouro.DataPropertyName = "end_logradouro";
            this.end_logradouro.HeaderText = "Logradouro";
            this.end_logradouro.Name = "end_logradouro";
            this.end_logradouro.ReadOnly = true;
            // 
            // end_bairro
            // 
            this.end_bairro.DataPropertyName = "end_bairro";
            this.end_bairro.HeaderText = "Bairro";
            this.end_bairro.Name = "end_bairro";
            this.end_bairro.ReadOnly = true;
            // 
            // cid_id
            // 
            this.cid_id.DataPropertyName = "cid_id";
            this.cid_id.HeaderText = "cid_id";
            this.cid_id.Name = "cid_id";
            this.cid_id.ReadOnly = true;
            this.cid_id.Visible = false;
            // 
            // end_uf
            // 
            this.end_uf.DataPropertyName = "end_uf";
            this.end_uf.HeaderText = "end_uf";
            this.end_uf.Name = "end_uf";
            this.end_uf.ReadOnly = true;
            this.end_uf.Visible = false;
            // 
            // end_id
            // 
            this.end_id.DataPropertyName = "end_id";
            this.end_id.HeaderText = "end_id";
            this.end_id.Name = "end_id";
            this.end_id.ReadOnly = true;
            this.end_id.Visible = false;
            // 
            // clienteBindingSource
            // 
            this.clienteBindingSource.DataSource = typeof(GPF.Model.Cliente);
            // 
            // pButtons
            // 
            this.pButtons.BackColor = System.Drawing.Color.CadetBlue;
            this.pButtons.Controls.Add(this.bExcluir);
            this.pButtons.Controls.Add(this.bAlterar);
            this.pButtons.Controls.Add(this.bNovo);
            this.pButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pButtons.Location = new System.Drawing.Point(0, 569);
            this.pButtons.Name = "pButtons";
            this.pButtons.Size = new System.Drawing.Size(625, 42);
            this.pButtons.TabIndex = 8;
            // 
            // bExcluir
            // 
            this.bExcluir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bExcluir.BackColor = System.Drawing.Color.Maroon;
            this.bExcluir.FlatAppearance.BorderSize = 0;
            this.bExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bExcluir.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.bExcluir.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bExcluir.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.bExcluir.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            this.bExcluir.IconColor = System.Drawing.Color.WhiteSmoke;
            this.bExcluir.IconSize = 16;
            this.bExcluir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bExcluir.Location = new System.Drawing.Point(544, 9);
            this.bExcluir.Name = "bExcluir";
            this.bExcluir.Rotation = 0D;
            this.bExcluir.Size = new System.Drawing.Size(75, 23);
            this.bExcluir.TabIndex = 2;
            this.bExcluir.Text = "  Excluir";
            this.bExcluir.UseVisualStyleBackColor = false;
            this.bExcluir.Click += new System.EventHandler(this.bExcluir_Click);
            // 
            // bAlterar
            // 
            this.bAlterar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bAlterar.BackColor = System.Drawing.Color.Orange;
            this.bAlterar.FlatAppearance.BorderSize = 0;
            this.bAlterar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bAlterar.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.bAlterar.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bAlterar.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.bAlterar.IconChar = FontAwesome.Sharp.IconChar.PencilAlt;
            this.bAlterar.IconColor = System.Drawing.Color.WhiteSmoke;
            this.bAlterar.IconSize = 16;
            this.bAlterar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bAlterar.Location = new System.Drawing.Point(463, 9);
            this.bAlterar.Name = "bAlterar";
            this.bAlterar.Rotation = 0D;
            this.bAlterar.Size = new System.Drawing.Size(75, 23);
            this.bAlterar.TabIndex = 1;
            this.bAlterar.Text = "  Alterar";
            this.bAlterar.UseVisualStyleBackColor = false;
            this.bAlterar.Click += new System.EventHandler(this.bAlterar_Click);
            // 
            // bNovo
            // 
            this.bNovo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bNovo.BackColor = System.Drawing.Color.Green;
            this.bNovo.FlatAppearance.BorderSize = 0;
            this.bNovo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bNovo.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.bNovo.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bNovo.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.bNovo.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.bNovo.IconColor = System.Drawing.Color.WhiteSmoke;
            this.bNovo.IconSize = 16;
            this.bNovo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bNovo.Location = new System.Drawing.Point(382, 9);
            this.bNovo.Name = "bNovo";
            this.bNovo.Rotation = 0D;
            this.bNovo.Size = new System.Drawing.Size(75, 23);
            this.bNovo.TabIndex = 0;
            this.bNovo.Text = "  Novo";
            this.bNovo.UseVisualStyleBackColor = false;
            this.bNovo.Click += new System.EventHandler(this.bNovo_Click);
            // 
            // pCrud
            // 
            this.pCrud.BackColor = System.Drawing.Color.CadetBlue;
            this.pCrud.Controls.Add(this.dtpDataNasc);
            this.pCrud.Controls.Add(this.txtRG);
            this.pCrud.Controls.Add(this.label17);
            this.pCrud.Controls.Add(this.txtTelefone1);
            this.pCrud.Controls.Add(this.txtTelefone2);
            this.pCrud.Controls.Add(this.pCadastroEnd);
            this.pCrud.Controls.Add(this.label6);
            this.pCrud.Controls.Add(this.label7);
            this.pCrud.Controls.Add(this.cbCasado);
            this.pCrud.Controls.Add(this.label5);
            this.pCrud.Controls.Add(this.label3);
            this.pCrud.Controls.Add(this.txtCpf);
            this.pCrud.Controls.Add(this.label1);
            this.pCrud.Controls.Add(this.txtSobrenome);
            this.pCrud.Controls.Add(this.bMinimizar);
            this.pCrud.Controls.Add(this.bFechar);
            this.pCrud.Controls.Add(this.label4);
            this.pCrud.Controls.Add(this.label2);
            this.pCrud.Controls.Add(this.txtNome);
            this.pCrud.Dock = System.Windows.Forms.DockStyle.Right;
            this.pCrud.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.pCrud.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pCrud.Location = new System.Drawing.Point(625, 0);
            this.pCrud.Name = "pCrud";
            this.pCrud.Size = new System.Drawing.Size(279, 611);
            this.pCrud.TabIndex = 7;
            // 
            // dtpDataNasc
            // 
            this.dtpDataNasc.CustomFormat = "";
            this.dtpDataNasc.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDataNasc.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataNasc.Location = new System.Drawing.Point(22, 180);
            this.dtpDataNasc.Name = "dtpDataNasc";
            this.dtpDataNasc.Size = new System.Drawing.Size(112, 22);
            this.dtpDataNasc.TabIndex = 6;
            this.dtpDataNasc.Value = new System.DateTime(2020, 5, 18, 0, 0, 0, 0);
            // 
            // txtRG
            // 
            this.txtRG.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtRG.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRG.Location = new System.Drawing.Point(142, 139);
            this.txtRG.MaxLength = 13;
            this.txtRG.Name = "txtRG";
            this.txtRG.Size = new System.Drawing.Size(112, 22);
            this.txtRG.TabIndex = 5;
            this.txtRG.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRG_KeyPress);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label17.Location = new System.Drawing.Point(141, 122);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(25, 16);
            this.label17.TabIndex = 32;
            this.label17.Text = "RG";
            // 
            // txtTelefone1
            // 
            this.txtTelefone1.BeepOnError = true;
            this.txtTelefone1.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefone1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtTelefone1.Location = new System.Drawing.Point(24, 221);
            this.txtTelefone1.Mask = "(00)00000000#";
            this.txtTelefone1.Name = "txtTelefone1";
            this.txtTelefone1.Size = new System.Drawing.Size(110, 22);
            this.txtTelefone1.TabIndex = 7;
            // 
            // txtTelefone2
            // 
            this.txtTelefone2.BeepOnError = true;
            this.txtTelefone2.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefone2.Location = new System.Drawing.Point(140, 221);
            this.txtTelefone2.Mask = "(00)00000000#";
            this.txtTelefone2.Name = "txtTelefone2";
            this.txtTelefone2.Size = new System.Drawing.Size(112, 22);
            this.txtTelefone2.TabIndex = 8;
            // 
            // pCadastroEnd
            // 
            this.pCadastroEnd.Controls.Add(this.pBotoes);
            this.pCadastroEnd.Controls.Add(this.pEndereco);
            this.pCadastroEnd.Controls.Add(this.pConjunge);
            this.pCadastroEnd.Location = new System.Drawing.Point(7, 264);
            this.pCadastroEnd.Name = "pCadastroEnd";
            this.pCadastroEnd.Size = new System.Drawing.Size(260, 338);
            this.pCadastroEnd.TabIndex = 31;
            // 
            // pBotoes
            // 
            this.pBotoes.Controls.Add(this.bCancelar);
            this.pBotoes.Controls.Add(this.bSalvar);
            this.pBotoes.Dock = System.Windows.Forms.DockStyle.Top;
            this.pBotoes.Location = new System.Drawing.Point(0, 274);
            this.pBotoes.Name = "pBotoes";
            this.pBotoes.Size = new System.Drawing.Size(260, 58);
            this.pBotoes.TabIndex = 33;
            // 
            // bCancelar
            // 
            this.bCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bCancelar.BackColor = System.Drawing.Color.OrangeRed;
            this.bCancelar.FlatAppearance.BorderSize = 0;
            this.bCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bCancelar.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.bCancelar.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bCancelar.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.bCancelar.IconChar = FontAwesome.Sharp.IconChar.Ban;
            this.bCancelar.IconColor = System.Drawing.Color.WhiteSmoke;
            this.bCancelar.IconSize = 16;
            this.bCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bCancelar.Location = new System.Drawing.Point(14, 31);
            this.bCancelar.Name = "bCancelar";
            this.bCancelar.Rotation = 0D;
            this.bCancelar.Size = new System.Drawing.Size(230, 23);
            this.bCancelar.TabIndex = 2;
            this.bCancelar.Text = "Cancelar";
            this.bCancelar.UseVisualStyleBackColor = false;
            this.bCancelar.Click += new System.EventHandler(this.bCancelar_Click);
            // 
            // bSalvar
            // 
            this.bSalvar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bSalvar.BackColor = System.Drawing.Color.RoyalBlue;
            this.bSalvar.FlatAppearance.BorderSize = 0;
            this.bSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bSalvar.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.bSalvar.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bSalvar.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.bSalvar.IconChar = FontAwesome.Sharp.IconChar.Save;
            this.bSalvar.IconColor = System.Drawing.Color.WhiteSmoke;
            this.bSalvar.IconSize = 16;
            this.bSalvar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bSalvar.Location = new System.Drawing.Point(15, 2);
            this.bSalvar.Name = "bSalvar";
            this.bSalvar.Rotation = 0D;
            this.bSalvar.Size = new System.Drawing.Size(230, 23);
            this.bSalvar.TabIndex = 0;
            this.bSalvar.Text = "Salvar";
            this.bSalvar.UseVisualStyleBackColor = false;
            this.bSalvar.Click += new System.EventHandler(this.bSalvar_Click);
            // 
            // pEndereco
            // 
            this.pEndereco.Controls.Add(this.label15);
            this.pEndereco.Controls.Add(this.label14);
            this.pEndereco.Controls.Add(this.CbbCidade);
            this.pEndereco.Controls.Add(this.CbbUf);
            this.pEndereco.Controls.Add(this.label13);
            this.pEndereco.Controls.Add(this.txtBairro);
            this.pEndereco.Controls.Add(this.label12);
            this.pEndereco.Controls.Add(this.txtLogradouro);
            this.pEndereco.Controls.Add(this.label11);
            this.pEndereco.Dock = System.Windows.Forms.DockStyle.Top;
            this.pEndereco.Location = new System.Drawing.Point(0, 101);
            this.pEndereco.Name = "pEndereco";
            this.pEndereco.Size = new System.Drawing.Size(260, 173);
            this.pEndereco.TabIndex = 32;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label15.Location = new System.Drawing.Point(14, 48);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(52, 16);
            this.label15.TabIndex = 36;
            this.label15.Text = "Cidade";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label14.Location = new System.Drawing.Point(14, 7);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(52, 16);
            this.label14.TabIndex = 35;
            this.label14.Text = "Estado";
            // 
            // CbbCidade
            // 
            this.CbbCidade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbbCidade.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CbbCidade.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CbbCidade.FormattingEnabled = true;
            this.CbbCidade.Location = new System.Drawing.Point(17, 65);
            this.CbbCidade.Name = "CbbCidade";
            this.CbbCidade.Size = new System.Drawing.Size(230, 24);
            this.CbbCidade.TabIndex = 1;
            // 
            // CbbUf
            // 
            this.CbbUf.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbbUf.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CbbUf.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CbbUf.FormattingEnabled = true;
            this.CbbUf.Location = new System.Drawing.Point(17, 24);
            this.CbbUf.Name = "CbbUf";
            this.CbbUf.Size = new System.Drawing.Size(56, 24);
            this.CbbUf.TabIndex = 0;
            this.CbbUf.SelectedIndexChanged += new System.EventHandler(this.CbbUf_SelectedIndexChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label13.Location = new System.Drawing.Point(14, 126);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(45, 16);
            this.label13.TabIndex = 32;
            this.label13.Text = "Bairro";
            // 
            // txtBairro
            // 
            this.txtBairro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtBairro.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBairro.Location = new System.Drawing.Point(17, 142);
            this.txtBairro.MaxLength = 100;
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(230, 22);
            this.txtBairro.TabIndex = 3;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label12.Location = new System.Drawing.Point(14, 87);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(81, 16);
            this.label12.TabIndex = 30;
            this.label12.Text = "Logradouro";
            // 
            // txtLogradouro
            // 
            this.txtLogradouro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtLogradouro.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLogradouro.Location = new System.Drawing.Point(17, 104);
            this.txtLogradouro.MaxLength = 200;
            this.txtLogradouro.Name = "txtLogradouro";
            this.txtLogradouro.Size = new System.Drawing.Size(230, 22);
            this.txtLogradouro.TabIndex = 2;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label11.Location = new System.Drawing.Point(99, 5);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(75, 16);
            this.label11.TabIndex = 28;
            this.label11.Text = "Endereço";
            this.label11.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pConjunge
            // 
            this.pConjunge.Controls.Add(this.txtConjugeRg);
            this.pConjunge.Controls.Add(this.label16);
            this.pConjunge.Controls.Add(this.label10);
            this.pConjunge.Controls.Add(this.label8);
            this.pConjunge.Controls.Add(this.txtCpfConjuge);
            this.pConjunge.Controls.Add(this.label9);
            this.pConjunge.Controls.Add(this.txtNomeConjuge);
            this.pConjunge.Dock = System.Windows.Forms.DockStyle.Top;
            this.pConjunge.Location = new System.Drawing.Point(0, 0);
            this.pConjunge.Name = "pConjunge";
            this.pConjunge.Size = new System.Drawing.Size(260, 101);
            this.pConjunge.TabIndex = 31;
            // 
            // txtConjugeRg
            // 
            this.txtConjugeRg.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtConjugeRg.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConjugeRg.Location = new System.Drawing.Point(133, 74);
            this.txtConjugeRg.MaxLength = 13;
            this.txtConjugeRg.Name = "txtConjugeRg";
            this.txtConjugeRg.Size = new System.Drawing.Size(112, 22);
            this.txtConjugeRg.TabIndex = 2;
            this.txtConjugeRg.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtConjugeRg_KeyPress);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label16.Location = new System.Drawing.Point(132, 58);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(25, 16);
            this.label16.TabIndex = 29;
            this.label16.Text = "RG";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label10.Location = new System.Drawing.Point(74, 1);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(136, 16);
            this.label10.TabIndex = 27;
            this.label10.Text = "Cadastro cônjuge";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label8.Location = new System.Drawing.Point(14, 58);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(32, 16);
            this.label8.TabIndex = 26;
            this.label8.Text = "CPF";
            // 
            // txtCpfConjuge
            // 
            this.txtCpfConjuge.BeepOnError = true;
            this.txtCpfConjuge.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCpfConjuge.Location = new System.Drawing.Point(17, 74);
            this.txtCpfConjuge.Mask = "000,000,000-00";
            this.txtCpfConjuge.Name = "txtCpfConjuge";
            this.txtCpfConjuge.Size = new System.Drawing.Size(112, 22);
            this.txtCpfConjuge.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label9.Location = new System.Drawing.Point(14, 20);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(159, 16);
            this.label9.TabIndex = 24;
            this.label9.Text = "Nome completo cônjuge";
            // 
            // txtNomeConjuge
            // 
            this.txtNomeConjuge.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNomeConjuge.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeConjuge.Location = new System.Drawing.Point(17, 37);
            this.txtNomeConjuge.MaxLength = 50;
            this.txtNomeConjuge.Name = "txtNomeConjuge";
            this.txtNomeConjuge.Size = new System.Drawing.Size(230, 22);
            this.txtNomeConjuge.TabIndex = 0;
            this.txtNomeConjuge.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNomeConjuge_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label6.Location = new System.Drawing.Point(135, 204);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(126, 16);
            this.label6.TabIndex = 29;
            this.label6.Text = "Contato - Opcional";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label7.Location = new System.Drawing.Point(18, 204);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 16);
            this.label7.TabIndex = 27;
            this.label7.Text = "Contato";
            // 
            // cbCasado
            // 
            this.cbCasado.AutoSize = true;
            this.cbCasado.BackColor = System.Drawing.Color.CadetBlue;
            this.cbCasado.FlatAppearance.BorderSize = 0;
            this.cbCasado.Font = new System.Drawing.Font("MS Reference Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCasado.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.cbCasado.Location = new System.Drawing.Point(24, 245);
            this.cbCasado.Name = "cbCasado";
            this.cbCasado.Size = new System.Drawing.Size(79, 22);
            this.cbCasado.TabIndex = 9;
            this.cbCasado.Text = "Casado";
            this.cbCasado.UseVisualStyleBackColor = false;
            this.cbCasado.CheckedChanged += new System.EventHandler(this.cbCasado_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label5.Location = new System.Drawing.Point(19, 163);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 16);
            this.label5.TabIndex = 24;
            this.label5.Text = "Data Nascimento";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label3.Location = new System.Drawing.Point(19, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 16);
            this.label3.TabIndex = 22;
            this.label3.Text = "CPF";
            // 
            // txtCpf
            // 
            this.txtCpf.BeepOnError = true;
            this.txtCpf.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCpf.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCpf.Location = new System.Drawing.Point(22, 139);
            this.txtCpf.Mask = "000,000,000-00";
            this.txtCpf.Name = "txtCpf";
            this.txtCpf.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtCpf.Size = new System.Drawing.Size(112, 22);
            this.txtCpf.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(19, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 16);
            this.label1.TabIndex = 20;
            this.label1.Text = "Sobrenome";
            // 
            // txtSobrenome
            // 
            this.txtSobrenome.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtSobrenome.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSobrenome.Location = new System.Drawing.Point(22, 98);
            this.txtSobrenome.MaxLength = 80;
            this.txtSobrenome.Name = "txtSobrenome";
            this.txtSobrenome.Size = new System.Drawing.Size(230, 22);
            this.txtSobrenome.TabIndex = 3;
            this.txtSobrenome.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSobrenome_KeyPress);
            // 
            // bMinimizar
            // 
            this.bMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bMinimizar.FlatAppearance.BorderSize = 0;
            this.bMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bMinimizar.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.bMinimizar.IconChar = FontAwesome.Sharp.IconChar.MinusSquare;
            this.bMinimizar.IconColor = System.Drawing.Color.WhiteSmoke;
            this.bMinimizar.IconSize = 23;
            this.bMinimizar.Location = new System.Drawing.Point(222, 10);
            this.bMinimizar.Name = "bMinimizar";
            this.bMinimizar.Rotation = 0D;
            this.bMinimizar.Size = new System.Drawing.Size(24, 24);
            this.bMinimizar.TabIndex = 0;
            this.bMinimizar.UseVisualStyleBackColor = true;
            // 
            // bFechar
            // 
            this.bFechar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bFechar.FlatAppearance.BorderSize = 0;
            this.bFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bFechar.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.bFechar.IconChar = FontAwesome.Sharp.IconChar.WindowClose;
            this.bFechar.IconColor = System.Drawing.Color.WhiteSmoke;
            this.bFechar.IconSize = 23;
            this.bFechar.Location = new System.Drawing.Point(248, 10);
            this.bFechar.Name = "bFechar";
            this.bFechar.Rotation = 0D;
            this.bFechar.Size = new System.Drawing.Size(24, 24);
            this.bFechar.TabIndex = 1;
            this.bFechar.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label4.Location = new System.Drawing.Point(19, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 16);
            this.label4.TabIndex = 12;
            this.label4.Text = "Nome";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS Reference Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Location = new System.Drawing.Point(8, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(209, 29);
            this.label2.TabIndex = 7;
            this.label2.Text = "Cadastro Cliente";
            // 
            // txtNome
            // 
            this.txtNome.BackColor = System.Drawing.SystemColors.Window;
            this.txtNome.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNome.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(22, 59);
            this.txtNome.MaxLength = 50;
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(230, 22);
            this.txtNome.TabIndex = 2;
            this.txtNome.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNome_KeyPress);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "end_id";
            this.dataGridViewTextBoxColumn1.HeaderText = "end_id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // enderecoBindingSource
            // 
            this.enderecoBindingSource.DataSource = typeof(GPF.Model.Endereco);
            // 
            // fCadCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSlateGray;
            this.ClientSize = new System.Drawing.Size(904, 611);
            this.Controls.Add(this.pDgvLocaliza);
            this.Controls.Add(this.pButtons);
            this.Controls.Add(this.pCrud);
            this.MaximumSize = new System.Drawing.Size(920, 650);
            this.MinimumSize = new System.Drawing.Size(720, 600);
            this.Name = "fCadCliente";
            this.Text = "Cadastro Cliente";
            this.Load += new System.EventHandler(this.fCadCliente_Load);
            this.pDgvLocaliza.ResumeLayout(false);
            this.pBuscas.ResumeLayout(false);
            this.pBuscas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCadastro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).EndInit();
            this.pButtons.ResumeLayout(false);
            this.pCrud.ResumeLayout(false);
            this.pCrud.PerformLayout();
            this.pCadastroEnd.ResumeLayout(false);
            this.pBotoes.ResumeLayout(false);
            this.pEndereco.ResumeLayout(false);
            this.pEndereco.PerformLayout();
            this.pConjunge.ResumeLayout(false);
            this.pConjunge.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.enderecoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pDgvLocaliza;
        private System.Windows.Forms.Panel pBuscas;
        private FontAwesome.Sharp.IconButton bBuscar;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.DataGridView dgvCadastro;
        private System.Windows.Forms.Panel pButtons;
        private FontAwesome.Sharp.IconButton bExcluir;
        private FontAwesome.Sharp.IconButton bAlterar;
        private FontAwesome.Sharp.IconButton bNovo;
        private System.Windows.Forms.Panel pCrud;
        private FontAwesome.Sharp.IconButton bMinimizar;
        private FontAwesome.Sharp.IconButton bFechar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSobrenome;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox txtCpf;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox cbCasado;
        private System.Windows.Forms.Panel pCadastroEnd;
        private System.Windows.Forms.Panel pEndereco;
        private System.Windows.Forms.Panel pConjunge;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.MaskedTextBox txtCpfConjuge;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtNomeConjuge;
        private System.Windows.Forms.MaskedTextBox txtTelefone1;
        private System.Windows.Forms.MaskedTextBox txtTelefone2;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtBairro;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtLogradouro;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox CbbCidade;
        private System.Windows.Forms.ComboBox CbbUf;
        private System.Windows.Forms.Panel pBotoes;
        private FontAwesome.Sharp.IconButton bSalvar;
        private FontAwesome.Sharp.IconButton bCancelar;
        private System.Windows.Forms.BindingSource enderecoBindingSource;
        private System.Windows.Forms.BindingSource clienteBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.TextBox txtConjugeRg;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtRG;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.DataGridViewTextBoxColumn cli_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn cli_nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn cli_sobrenome;
        private System.Windows.Forms.DataGridViewTextBoxColumn cli_cpf;
        private System.Windows.Forms.DataGridViewTextBoxColumn cli_rg;
        private System.Windows.Forms.DataGridViewTextBoxColumn cli_dtnasc;
        private System.Windows.Forms.DataGridViewTextBoxColumn cli_telefone1;
        private System.Windows.Forms.DataGridViewTextBoxColumn cli_telefone2;
        private System.Windows.Forms.DataGridViewCheckBoxColumn cli_casado;
        private System.Windows.Forms.DataGridViewTextBoxColumn cli_conjuge;
        private System.Windows.Forms.DataGridViewTextBoxColumn cli_conjuge_cpf;
        private System.Windows.Forms.DataGridViewTextBoxColumn cli_conjuge_rg;
        private System.Windows.Forms.DataGridViewTextBoxColumn end_logradouro;
        private System.Windows.Forms.DataGridViewTextBoxColumn end_bairro;
        private System.Windows.Forms.DataGridViewTextBoxColumn cid_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn end_uf;
        private System.Windows.Forms.DataGridViewTextBoxColumn end_id;
        private System.Windows.Forms.DateTimePicker dtpDataNasc;
    }
}