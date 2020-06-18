namespace GPF.View
{
    partial class fCadUsuario
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pCrud = new System.Windows.Forms.Panel();
            this.label15 = new System.Windows.Forms.Label();
            this.CbbFuncionario = new System.Windows.Forms.ComboBox();
            this.bMinimizar = new FontAwesome.Sharp.IconButton();
            this.bFechar = new FontAwesome.Sharp.IconButton();
            this.bCancelar = new FontAwesome.Sharp.IconButton();
            this.bSalvar = new FontAwesome.Sharp.IconButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbAtivo = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.txtNomeUsuario = new System.Windows.Forms.TextBox();
            this.pDgvLocaliza = new System.Windows.Forms.Panel();
            this.pBuscas = new System.Windows.Forms.Panel();
            this.bBuscar = new FontAwesome.Sharp.IconButton();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.dgvCadastro = new System.Windows.Forms.DataGridView();
            this.Login = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Usuário = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ativo = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.pButtons = new System.Windows.Forms.Panel();
            this.bExcluir = new FontAwesome.Sharp.IconButton();
            this.bAlterar = new FontAwesome.Sharp.IconButton();
            this.bNovo = new FontAwesome.Sharp.IconButton();
            this.uso_login = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pCrud.SuspendLayout();
            this.pDgvLocaliza.SuspendLayout();
            this.pBuscas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCadastro)).BeginInit();
            this.pButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // pCrud
            // 
            this.pCrud.BackColor = System.Drawing.Color.CadetBlue;
            this.pCrud.Controls.Add(this.label15);
            this.pCrud.Controls.Add(this.CbbFuncionario);
            this.pCrud.Controls.Add(this.bMinimizar);
            this.pCrud.Controls.Add(this.bFechar);
            this.pCrud.Controls.Add(this.bCancelar);
            this.pCrud.Controls.Add(this.bSalvar);
            this.pCrud.Controls.Add(this.label4);
            this.pCrud.Controls.Add(this.label3);
            this.pCrud.Controls.Add(this.label1);
            this.pCrud.Controls.Add(this.cbAtivo);
            this.pCrud.Controls.Add(this.label2);
            this.pCrud.Controls.Add(this.txtSenha);
            this.pCrud.Controls.Add(this.txtLogin);
            this.pCrud.Controls.Add(this.txtNomeUsuario);
            this.pCrud.Dock = System.Windows.Forms.DockStyle.Right;
            this.pCrud.Location = new System.Drawing.Point(505, 0);
            this.pCrud.Name = "pCrud";
            this.pCrud.Size = new System.Drawing.Size(279, 438);
            this.pCrud.TabIndex = 1;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label15.Location = new System.Drawing.Point(18, 109);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(80, 16);
            this.label15.TabIndex = 38;
            this.label15.Text = "Funcionário";
            // 
            // CbbFuncionario
            // 
            this.CbbFuncionario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbbFuncionario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CbbFuncionario.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CbbFuncionario.FormattingEnabled = true;
            this.CbbFuncionario.Location = new System.Drawing.Point(21, 126);
            this.CbbFuncionario.Name = "CbbFuncionario";
            this.CbbFuncionario.Size = new System.Drawing.Size(230, 24);
            this.CbbFuncionario.TabIndex = 0;
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
            this.bMinimizar.Location = new System.Drawing.Point(220, 8);
            this.bMinimizar.Name = "bMinimizar";
            this.bMinimizar.Rotation = 0D;
            this.bMinimizar.Size = new System.Drawing.Size(24, 24);
            this.bMinimizar.TabIndex = 20;
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
            this.bFechar.Location = new System.Drawing.Point(246, 8);
            this.bFechar.Name = "bFechar";
            this.bFechar.Rotation = 0D;
            this.bFechar.Size = new System.Drawing.Size(24, 24);
            this.bFechar.TabIndex = 19;
            this.bFechar.UseVisualStyleBackColor = true;
            // 
            // bCancelar
            // 
            this.bCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bCancelar.BackColor = System.Drawing.Color.DarkCyan;
            this.bCancelar.FlatAppearance.BorderSize = 0;
            this.bCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bCancelar.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.bCancelar.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bCancelar.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.bCancelar.IconChar = FontAwesome.Sharp.IconChar.Ban;
            this.bCancelar.IconColor = System.Drawing.Color.WhiteSmoke;
            this.bCancelar.IconSize = 16;
            this.bCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bCancelar.Location = new System.Drawing.Point(21, 335);
            this.bCancelar.Name = "bCancelar";
            this.bCancelar.Rotation = 0D;
            this.bCancelar.Size = new System.Drawing.Size(230, 23);
            this.bCancelar.TabIndex = 6;
            this.bCancelar.Text = "Cancelar";
            this.bCancelar.UseVisualStyleBackColor = false;
            this.bCancelar.Click += new System.EventHandler(this.bCancelar_Click);
            // 
            // bSalvar
            // 
            this.bSalvar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
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
            this.bSalvar.Location = new System.Drawing.Point(21, 300);
            this.bSalvar.Name = "bSalvar";
            this.bSalvar.Rotation = 0D;
            this.bSalvar.Size = new System.Drawing.Size(230, 23);
            this.bSalvar.TabIndex = 5;
            this.bSalvar.Text = "Salvar";
            this.bSalvar.UseVisualStyleBackColor = false;
            this.bSalvar.Click += new System.EventHandler(this.bSalvar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label4.Location = new System.Drawing.Point(19, 153);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 16);
            this.label4.TabIndex = 12;
            this.label4.Text = "Nome de usuário";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label3.Location = new System.Drawing.Point(19, 239);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 16);
            this.label3.TabIndex = 11;
            this.label3.Text = "Senha";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(19, 196);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 16);
            this.label1.TabIndex = 10;
            this.label1.Text = "Login";
            // 
            // cbAtivo
            // 
            this.cbAtivo.AutoSize = true;
            this.cbAtivo.BackColor = System.Drawing.Color.CadetBlue;
            this.cbAtivo.Checked = true;
            this.cbAtivo.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbAtivo.FlatAppearance.BorderSize = 0;
            this.cbAtivo.Font = new System.Drawing.Font("MS Reference Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbAtivo.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.cbAtivo.Location = new System.Drawing.Point(184, 90);
            this.cbAtivo.Name = "cbAtivo";
            this.cbAtivo.Size = new System.Drawing.Size(68, 22);
            this.cbAtivo.TabIndex = 4;
            this.cbAtivo.Text = "Ativo";
            this.cbAtivo.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS Reference Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Location = new System.Drawing.Point(32, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(219, 29);
            this.label2.TabIndex = 7;
            this.label2.Text = "Cadastro Usuário";
            // 
            // txtSenha
            // 
            this.txtSenha.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSenha.Location = new System.Drawing.Point(21, 258);
            this.txtSenha.MaxLength = 50;
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(230, 21);
            this.txtSenha.TabIndex = 3;
            // 
            // txtLogin
            // 
            this.txtLogin.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLogin.Location = new System.Drawing.Point(21, 215);
            this.txtLogin.MaxLength = 50;
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(230, 21);
            this.txtLogin.TabIndex = 2;
            // 
            // txtNomeUsuario
            // 
            this.txtNomeUsuario.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeUsuario.Location = new System.Drawing.Point(22, 172);
            this.txtNomeUsuario.MaxLength = 20;
            this.txtNomeUsuario.Name = "txtNomeUsuario";
            this.txtNomeUsuario.Size = new System.Drawing.Size(230, 21);
            this.txtNomeUsuario.TabIndex = 1;
            // 
            // pDgvLocaliza
            // 
            this.pDgvLocaliza.BackColor = System.Drawing.Color.CadetBlue;
            this.pDgvLocaliza.Controls.Add(this.pBuscas);
            this.pDgvLocaliza.Controls.Add(this.dgvCadastro);
            this.pDgvLocaliza.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pDgvLocaliza.Location = new System.Drawing.Point(0, 0);
            this.pDgvLocaliza.Name = "pDgvLocaliza";
            this.pDgvLocaliza.Size = new System.Drawing.Size(505, 396);
            this.pDgvLocaliza.TabIndex = 8;
            // 
            // pBuscas
            // 
            this.pBuscas.BackColor = System.Drawing.Color.CadetBlue;
            this.pBuscas.Controls.Add(this.bBuscar);
            this.pBuscas.Controls.Add(this.txtDescricao);
            this.pBuscas.Dock = System.Windows.Forms.DockStyle.Top;
            this.pBuscas.Location = new System.Drawing.Point(0, 0);
            this.pBuscas.Name = "pBuscas";
            this.pBuscas.Size = new System.Drawing.Size(505, 42);
            this.pBuscas.TabIndex = 1;
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
            this.bBuscar.Location = new System.Drawing.Point(421, 7);
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
            this.txtDescricao.Size = new System.Drawing.Size(405, 21);
            this.txtDescricao.TabIndex = 0;
            this.txtDescricao.Text = "Nome de usuário ou login";
            this.txtDescricao.Enter += new System.EventHandler(this.txtDescricao_Enter);
            this.txtDescricao.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDescricao_KeyPress);
            this.txtDescricao.Leave += new System.EventHandler(this.txtDescricao_Leave);
            // 
            // dgvCadastro
            // 
            this.dgvCadastro.AllowUserToAddRows = false;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.Black;
            this.dgvCadastro.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvCadastro.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvCadastro.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvCadastro.BackgroundColor = System.Drawing.Color.DarkSlateGray;
            this.dgvCadastro.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvCadastro.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.AppWorkspace;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCadastro.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.dgvCadastro.ColumnHeadersHeight = 30;
            this.dgvCadastro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvCadastro.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Login,
            this.Usuário,
            this.Ativo});
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCadastro.DefaultCellStyle = dataGridViewCellStyle11;
            this.dgvCadastro.EnableHeadersVisualStyles = false;
            this.dgvCadastro.GridColor = System.Drawing.SystemColors.GrayText;
            this.dgvCadastro.Location = new System.Drawing.Point(12, 48);
            this.dgvCadastro.Name = "dgvCadastro";
            this.dgvCadastro.ReadOnly = true;
            this.dgvCadastro.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.AppWorkspace;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCadastro.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.dgvCadastro.RowHeadersWidth = 20;
            this.dgvCadastro.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCadastro.Size = new System.Drawing.Size(487, 342);
            this.dgvCadastro.TabIndex = 0;
            this.dgvCadastro.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCadastro_CellDoubleClick);
            // 
            // Login
            // 
            this.Login.DataPropertyName = "Login";
            this.Login.HeaderText = "Login";
            this.Login.Name = "Login";
            this.Login.ReadOnly = true;
            // 
            // Usuário
            // 
            this.Usuário.DataPropertyName = "Usuário";
            this.Usuário.HeaderText = "Usuário";
            this.Usuário.Name = "Usuário";
            this.Usuário.ReadOnly = true;
            // 
            // Ativo
            // 
            this.Ativo.DataPropertyName = "Ativo";
            this.Ativo.HeaderText = "Ativo";
            this.Ativo.Name = "Ativo";
            this.Ativo.ReadOnly = true;
            // 
            // pButtons
            // 
            this.pButtons.BackColor = System.Drawing.Color.CadetBlue;
            this.pButtons.Controls.Add(this.bExcluir);
            this.pButtons.Controls.Add(this.bAlterar);
            this.pButtons.Controls.Add(this.bNovo);
            this.pButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pButtons.Location = new System.Drawing.Point(0, 396);
            this.pButtons.Name = "pButtons";
            this.pButtons.Size = new System.Drawing.Size(505, 42);
            this.pButtons.TabIndex = 7;
            // 
            // bExcluir
            // 
            this.bExcluir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bExcluir.BackColor = System.Drawing.Color.DarkCyan;
            this.bExcluir.FlatAppearance.BorderSize = 0;
            this.bExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bExcluir.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.bExcluir.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bExcluir.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.bExcluir.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            this.bExcluir.IconColor = System.Drawing.Color.WhiteSmoke;
            this.bExcluir.IconSize = 16;
            this.bExcluir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bExcluir.Location = new System.Drawing.Point(424, 9);
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
            this.bAlterar.BackColor = System.Drawing.Color.DarkCyan;
            this.bAlterar.FlatAppearance.BorderSize = 0;
            this.bAlterar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bAlterar.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.bAlterar.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bAlterar.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.bAlterar.IconChar = FontAwesome.Sharp.IconChar.PencilAlt;
            this.bAlterar.IconColor = System.Drawing.Color.WhiteSmoke;
            this.bAlterar.IconSize = 16;
            this.bAlterar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bAlterar.Location = new System.Drawing.Point(343, 9);
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
            this.bNovo.BackColor = System.Drawing.Color.SeaGreen;
            this.bNovo.FlatAppearance.BorderSize = 0;
            this.bNovo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bNovo.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.bNovo.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bNovo.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.bNovo.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.bNovo.IconColor = System.Drawing.Color.WhiteSmoke;
            this.bNovo.IconSize = 16;
            this.bNovo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bNovo.Location = new System.Drawing.Point(262, 9);
            this.bNovo.Name = "bNovo";
            this.bNovo.Rotation = 0D;
            this.bNovo.Size = new System.Drawing.Size(75, 23);
            this.bNovo.TabIndex = 0;
            this.bNovo.Text = "  Novo";
            this.bNovo.UseVisualStyleBackColor = false;
            this.bNovo.Click += new System.EventHandler(this.bNovo_Click);
            // 
            // uso_login
            // 
            this.uso_login.DataPropertyName = "uso_login";
            this.uso_login.HeaderText = "Login";
            this.uso_login.Name = "uso_login";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "funcionario";
            this.dataGridViewTextBoxColumn1.HeaderText = "funcionario";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // fCadUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 438);
            this.Controls.Add(this.pDgvLocaliza);
            this.Controls.Add(this.pButtons);
            this.Controls.Add(this.pCrud);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MaximumSize = new System.Drawing.Size(800, 500);
            this.MinimumSize = new System.Drawing.Size(600, 430);
            this.Name = "fCadUsuario";
            this.Text = "Cadastro Usuário";
            this.Load += new System.EventHandler(this.fCadUsuario_Load);
            this.pCrud.ResumeLayout(false);
            this.pCrud.PerformLayout();
            this.pDgvLocaliza.ResumeLayout(false);
            this.pBuscas.ResumeLayout(false);
            this.pBuscas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCadastro)).EndInit();
            this.pButtons.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pCrud;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.TextBox txtNomeUsuario;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox cbAtivo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pDgvLocaliza;
        private System.Windows.Forms.Panel pBuscas;
        private FontAwesome.Sharp.IconButton bBuscar;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.Panel pButtons;
        private FontAwesome.Sharp.IconButton bExcluir;
        private FontAwesome.Sharp.IconButton bAlterar;
        private FontAwesome.Sharp.IconButton bNovo;
        private FontAwesome.Sharp.IconButton bCancelar;
        private FontAwesome.Sharp.IconButton bSalvar;
        private FontAwesome.Sharp.IconButton bMinimizar;
        private FontAwesome.Sharp.IconButton bFechar;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox CbbFuncionario;
        private System.Windows.Forms.DataGridViewTextBoxColumn uso_login;
        private System.Windows.Forms.DataGridView dgvCadastro;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Login;
        private System.Windows.Forms.DataGridViewTextBoxColumn Usuário;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Ativo;
    }
}