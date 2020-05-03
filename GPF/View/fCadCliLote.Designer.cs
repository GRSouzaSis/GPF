namespace GPF.View
{
    partial class fCadCliLote
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pDgvLocaliza = new System.Windows.Forms.Panel();
            this.pBuscas = new System.Windows.Forms.Panel();
            this.bBuscar = new FontAwesome.Sharp.IconButton();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.dgvCadastro = new System.Windows.Forms.DataGridView();
            this.pButtons = new System.Windows.Forms.Panel();
            this.bExcluir = new FontAwesome.Sharp.IconButton();
            this.bAlterar = new FontAwesome.Sharp.IconButton();
            this.bNovo = new FontAwesome.Sharp.IconButton();
            this.pCrud = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.cbbCliente = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbbProjeto = new System.Windows.Forms.ComboBox();
            this.pCadastroEnd = new System.Windows.Forms.Panel();
            this.pBotoes = new System.Windows.Forms.Panel();
            this.bCancelar = new FontAwesome.Sharp.IconButton();
            this.bSalvar = new FontAwesome.Sharp.IconButton();
            this.pEndereco = new System.Windows.Forms.Panel();
            this.txtMatricula = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNroQuadra = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNroLote = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.bMinimizar = new FontAwesome.Sharp.IconButton();
            this.bFechar = new FontAwesome.Sharp.IconButton();
            this.label2 = new System.Windows.Forms.Label();
            this.pDgvLocaliza.SuspendLayout();
            this.pBuscas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCadastro)).BeginInit();
            this.pButtons.SuspendLayout();
            this.pCrud.SuspendLayout();
            this.pCadastroEnd.SuspendLayout();
            this.pBotoes.SuspendLayout();
            this.pEndereco.SuspendLayout();
            this.SuspendLayout();
            // 
            // pDgvLocaliza
            // 
            this.pDgvLocaliza.BackColor = System.Drawing.Color.LightSeaGreen;
            this.pDgvLocaliza.Controls.Add(this.pBuscas);
            this.pDgvLocaliza.Controls.Add(this.dgvCadastro);
            this.pDgvLocaliza.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pDgvLocaliza.Location = new System.Drawing.Point(0, 0);
            this.pDgvLocaliza.Name = "pDgvLocaliza";
            this.pDgvLocaliza.Size = new System.Drawing.Size(553, 385);
            this.pDgvLocaliza.TabIndex = 15;
            // 
            // pBuscas
            // 
            this.pBuscas.Controls.Add(this.bBuscar);
            this.pBuscas.Controls.Add(this.txtDescricao);
            this.pBuscas.Dock = System.Windows.Forms.DockStyle.Top;
            this.pBuscas.Location = new System.Drawing.Point(0, 0);
            this.pBuscas.Name = "pBuscas";
            this.pBuscas.Size = new System.Drawing.Size(553, 42);
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
            this.bBuscar.Location = new System.Drawing.Point(469, 7);
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
            this.txtDescricao.Size = new System.Drawing.Size(453, 21);
            this.txtDescricao.TabIndex = 0;
            this.txtDescricao.Text = "Projeto ou Cliente";
            this.txtDescricao.Enter += new System.EventHandler(this.txtDescricao_Enter);
            this.txtDescricao.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDescricao_KeyPress);
            this.txtDescricao.Leave += new System.EventHandler(this.txtDescricao_Leave);
            // 
            // dgvCadastro
            // 
            this.dgvCadastro.AllowUserToAddRows = false;
            this.dgvCadastro.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvCadastro.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvCadastro.BackgroundColor = System.Drawing.Color.DarkSlateGray;
            this.dgvCadastro.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvCadastro.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.DarkCyan;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCadastro.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.dgvCadastro.ColumnHeadersHeight = 40;
            this.dgvCadastro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.MediumTurquoise;
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
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.DarkCyan;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCadastro.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.dgvCadastro.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCadastro.Size = new System.Drawing.Size(535, 331);
            this.dgvCadastro.TabIndex = 0;
            this.dgvCadastro.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCadastro_CellDoubleClick);
            // 
            // pButtons
            // 
            this.pButtons.BackColor = System.Drawing.Color.LightSeaGreen;
            this.pButtons.Controls.Add(this.bExcluir);
            this.pButtons.Controls.Add(this.bAlterar);
            this.pButtons.Controls.Add(this.bNovo);
            this.pButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pButtons.Location = new System.Drawing.Point(0, 385);
            this.pButtons.Name = "pButtons";
            this.pButtons.Size = new System.Drawing.Size(553, 42);
            this.pButtons.TabIndex = 14;
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
            this.bExcluir.Location = new System.Drawing.Point(472, 9);
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
            this.bAlterar.Location = new System.Drawing.Point(391, 9);
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
            this.bNovo.Location = new System.Drawing.Point(310, 9);
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
            this.pCrud.BackColor = System.Drawing.Color.DarkCyan;
            this.pCrud.Controls.Add(this.label3);
            this.pCrud.Controls.Add(this.cbbCliente);
            this.pCrud.Controls.Add(this.label1);
            this.pCrud.Controls.Add(this.cbbProjeto);
            this.pCrud.Controls.Add(this.pCadastroEnd);
            this.pCrud.Controls.Add(this.bMinimizar);
            this.pCrud.Controls.Add(this.bFechar);
            this.pCrud.Controls.Add(this.label2);
            this.pCrud.Dock = System.Windows.Forms.DockStyle.Right;
            this.pCrud.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.pCrud.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pCrud.Location = new System.Drawing.Point(553, 0);
            this.pCrud.Name = "pCrud";
            this.pCrud.Size = new System.Drawing.Size(279, 427);
            this.pCrud.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label3.Location = new System.Drawing.Point(19, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 16);
            this.label3.TabIndex = 40;
            this.label3.Text = "Cliente";
            // 
            // cbbCliente
            // 
            this.cbbCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbbCliente.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbCliente.FormattingEnabled = true;
            this.cbbCliente.Location = new System.Drawing.Point(22, 126);
            this.cbbCliente.Name = "cbbCliente";
            this.cbbCliente.Size = new System.Drawing.Size(230, 24);
            this.cbbCliente.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(19, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 16);
            this.label1.TabIndex = 38;
            this.label1.Text = "Projeto";
            // 
            // cbbProjeto
            // 
            this.cbbProjeto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbProjeto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbbProjeto.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbProjeto.FormattingEnabled = true;
            this.cbbProjeto.Location = new System.Drawing.Point(22, 83);
            this.cbbProjeto.Name = "cbbProjeto";
            this.cbbProjeto.Size = new System.Drawing.Size(230, 24);
            this.cbbProjeto.TabIndex = 2;
            // 
            // pCadastroEnd
            // 
            this.pCadastroEnd.Controls.Add(this.pBotoes);
            this.pCadastroEnd.Controls.Add(this.pEndereco);
            this.pCadastroEnd.Location = new System.Drawing.Point(7, 156);
            this.pCadastroEnd.Name = "pCadastroEnd";
            this.pCadastroEnd.Size = new System.Drawing.Size(260, 258);
            this.pCadastroEnd.TabIndex = 31;
            // 
            // pBotoes
            // 
            this.pBotoes.Controls.Add(this.bCancelar);
            this.pBotoes.Controls.Add(this.bSalvar);
            this.pBotoes.Dock = System.Windows.Forms.DockStyle.Top;
            this.pBotoes.Location = new System.Drawing.Point(0, 156);
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
            this.bCancelar.TabIndex = 1;
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
            this.bSalvar.Location = new System.Drawing.Point(14, 2);
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
            this.pEndereco.Controls.Add(this.txtMatricula);
            this.pEndereco.Controls.Add(this.label5);
            this.pEndereco.Controls.Add(this.txtNroQuadra);
            this.pEndereco.Controls.Add(this.label4);
            this.pEndereco.Controls.Add(this.txtNroLote);
            this.pEndereco.Controls.Add(this.label10);
            this.pEndereco.Controls.Add(this.label11);
            this.pEndereco.Dock = System.Windows.Forms.DockStyle.Top;
            this.pEndereco.Location = new System.Drawing.Point(0, 0);
            this.pEndereco.Name = "pEndereco";
            this.pEndereco.Size = new System.Drawing.Size(260, 156);
            this.pEndereco.TabIndex = 32;
            // 
            // txtMatricula
            // 
            this.txtMatricula.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMatricula.Location = new System.Drawing.Point(14, 119);
            this.txtMatricula.Name = "txtMatricula";
            this.txtMatricula.Size = new System.Drawing.Size(128, 22);
            this.txtMatricula.TabIndex = 47;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label5.Location = new System.Drawing.Point(12, 102);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(131, 16);
            this.label5.TabIndex = 48;
            this.label5.Text = "Matrícula - Opcional";
            // 
            // txtNroQuadra
            // 
            this.txtNroQuadra.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNroQuadra.Location = new System.Drawing.Point(14, 78);
            this.txtNroQuadra.Name = "txtNroQuadra";
            this.txtNroQuadra.Size = new System.Drawing.Size(128, 22);
            this.txtNroQuadra.TabIndex = 45;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label4.Location = new System.Drawing.Point(11, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 16);
            this.label4.TabIndex = 46;
            this.label4.Text = "Quadra";
            // 
            // txtNroLote
            // 
            this.txtNroLote.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNroLote.Location = new System.Drawing.Point(15, 38);
            this.txtNroLote.Name = "txtNroLote";
            this.txtNroLote.Size = new System.Drawing.Size(128, 22);
            this.txtNroLote.TabIndex = 4;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label10.Location = new System.Drawing.Point(12, 21);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(36, 16);
            this.label10.TabIndex = 44;
            this.label10.Text = "Lote";
            // 
            // label11
            // 
            this.label11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label11.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label11.Location = new System.Drawing.Point(3, 2);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(254, 19);
            this.label11.TabIndex = 28;
            this.label11.Text = "Dados Lote";
            this.label11.TextAlign = System.Drawing.ContentAlignment.TopCenter;
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS Reference Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Location = new System.Drawing.Point(16, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(175, 29);
            this.label2.TabIndex = 7;
            this.label2.Text = "Cliente x Lote";
            // 
            // fCadCliLote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 427);
            this.Controls.Add(this.pDgvLocaliza);
            this.Controls.Add(this.pButtons);
            this.Controls.Add(this.pCrud);
            this.MinimumSize = new System.Drawing.Size(848, 466);
            this.Name = "fCadCliLote";
            this.Text = "Cliente x Lote";
            this.Load += new System.EventHandler(this.fCadCliLote_Load);
            this.pDgvLocaliza.ResumeLayout(false);
            this.pBuscas.ResumeLayout(false);
            this.pBuscas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCadastro)).EndInit();
            this.pButtons.ResumeLayout(false);
            this.pCrud.ResumeLayout(false);
            this.pCrud.PerformLayout();
            this.pCadastroEnd.ResumeLayout(false);
            this.pBotoes.ResumeLayout(false);
            this.pEndereco.ResumeLayout(false);
            this.pEndereco.PerformLayout();
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
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbbCliente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbbProjeto;
        private System.Windows.Forms.Panel pCadastroEnd;
        private System.Windows.Forms.Panel pBotoes;
        private FontAwesome.Sharp.IconButton bCancelar;
        private FontAwesome.Sharp.IconButton bSalvar;
        private System.Windows.Forms.Panel pEndereco;
        private System.Windows.Forms.TextBox txtNroLote;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private FontAwesome.Sharp.IconButton bMinimizar;
        private FontAwesome.Sharp.IconButton bFechar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMatricula;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNroQuadra;
        private System.Windows.Forms.Label label4;
    }
}