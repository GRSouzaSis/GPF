namespace GPF.View
{
    partial class fCadOrcamento
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.bRemover = new FontAwesome.Sharp.IconButton();
            this.bAdd = new FontAwesome.Sharp.IconButton();
            this.txtDataOrcamento = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbbLote = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbbCliente = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbbProjeto = new System.Windows.Forms.ComboBox();
            this.pCadastroEnd = new System.Windows.Forms.Panel();
            this.pBotoes = new System.Windows.Forms.Panel();
            this.bCancelar = new FontAwesome.Sharp.IconButton();
            this.bSalvar = new FontAwesome.Sharp.IconButton();
            this.pEndereco = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.txtValorParcela = new System.Windows.Forms.TextBox();
            this.txtMulta = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.numParcelas = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.txtValorTotal = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.cbAprovado = new System.Windows.Forms.CheckBox();
            this.bMinimizar = new FontAwesome.Sharp.IconButton();
            this.bFechar = new FontAwesome.Sharp.IconButton();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvLote = new System.Windows.Forms.DataGridView();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbbVencimento = new System.Windows.Forms.ComboBox();
            this.pDgvLocaliza.SuspendLayout();
            this.pBuscas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCadastro)).BeginInit();
            this.pButtons.SuspendLayout();
            this.pCrud.SuspendLayout();
            this.pCadastroEnd.SuspendLayout();
            this.pBotoes.SuspendLayout();
            this.pEndereco.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numParcelas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLote)).BeginInit();
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
            this.pDgvLocaliza.Size = new System.Drawing.Size(577, 519);
            this.pDgvLocaliza.TabIndex = 12;
            // 
            // pBuscas
            // 
            this.pBuscas.Controls.Add(this.bBuscar);
            this.pBuscas.Controls.Add(this.txtDescricao);
            this.pBuscas.Dock = System.Windows.Forms.DockStyle.Top;
            this.pBuscas.Location = new System.Drawing.Point(0, 0);
            this.pBuscas.Name = "pBuscas";
            this.pBuscas.Size = new System.Drawing.Size(577, 42);
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
            this.bBuscar.Location = new System.Drawing.Point(495, 7);
            this.bBuscar.Name = "bBuscar";
            this.bBuscar.Rotation = 0D;
            this.bBuscar.Size = new System.Drawing.Size(75, 29);
            this.bBuscar.TabIndex = 2;
            this.bBuscar.Text = "   Buscar";
            this.bBuscar.UseVisualStyleBackColor = false;
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
            this.txtDescricao.Size = new System.Drawing.Size(478, 21);
            this.txtDescricao.TabIndex = 0;
            // 
            // dgvCadastro
            // 
            this.dgvCadastro.AllowUserToAddRows = false;
            this.dgvCadastro.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvCadastro.BackgroundColor = System.Drawing.Color.DarkSlateGray;
            this.dgvCadastro.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvCadastro.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.DarkCyan;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCadastro.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvCadastro.ColumnHeadersHeight = 40;
            this.dgvCadastro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.MediumTurquoise;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCadastro.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgvCadastro.EnableHeadersVisualStyles = false;
            this.dgvCadastro.GridColor = System.Drawing.SystemColors.GrayText;
            this.dgvCadastro.Location = new System.Drawing.Point(12, 48);
            this.dgvCadastro.Name = "dgvCadastro";
            this.dgvCadastro.ReadOnly = true;
            this.dgvCadastro.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.DarkCyan;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCadastro.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvCadastro.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCadastro.Size = new System.Drawing.Size(558, 464);
            this.dgvCadastro.TabIndex = 0;
            // 
            // pButtons
            // 
            this.pButtons.BackColor = System.Drawing.Color.LightSeaGreen;
            this.pButtons.Controls.Add(this.bExcluir);
            this.pButtons.Controls.Add(this.bAlterar);
            this.pButtons.Controls.Add(this.bNovo);
            this.pButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pButtons.Location = new System.Drawing.Point(0, 519);
            this.pButtons.Name = "pButtons";
            this.pButtons.Size = new System.Drawing.Size(577, 42);
            this.pButtons.TabIndex = 11;
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
            this.bExcluir.Location = new System.Drawing.Point(496, 9);
            this.bExcluir.Name = "bExcluir";
            this.bExcluir.Rotation = 0D;
            this.bExcluir.Size = new System.Drawing.Size(75, 23);
            this.bExcluir.TabIndex = 2;
            this.bExcluir.Text = "  Excluir";
            this.bExcluir.UseVisualStyleBackColor = false;
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
            this.bAlterar.Location = new System.Drawing.Point(415, 9);
            this.bAlterar.Name = "bAlterar";
            this.bAlterar.Rotation = 0D;
            this.bAlterar.Size = new System.Drawing.Size(75, 23);
            this.bAlterar.TabIndex = 1;
            this.bAlterar.Text = "  Alterar";
            this.bAlterar.UseVisualStyleBackColor = false;
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
            this.bNovo.Location = new System.Drawing.Point(334, 9);
            this.bNovo.Name = "bNovo";
            this.bNovo.Rotation = 0D;
            this.bNovo.Size = new System.Drawing.Size(75, 23);
            this.bNovo.TabIndex = 0;
            this.bNovo.Text = "  Novo";
            this.bNovo.UseVisualStyleBackColor = false;
            // 
            // pCrud
            // 
            this.pCrud.BackColor = System.Drawing.Color.DarkCyan;
            this.pCrud.Controls.Add(this.dgvLote);
            this.pCrud.Controls.Add(this.bRemover);
            this.pCrud.Controls.Add(this.bAdd);
            this.pCrud.Controls.Add(this.txtDataOrcamento);
            this.pCrud.Controls.Add(this.label5);
            this.pCrud.Controls.Add(this.label4);
            this.pCrud.Controls.Add(this.cbbLote);
            this.pCrud.Controls.Add(this.label3);
            this.pCrud.Controls.Add(this.cbbCliente);
            this.pCrud.Controls.Add(this.label1);
            this.pCrud.Controls.Add(this.cbbProjeto);
            this.pCrud.Controls.Add(this.pCadastroEnd);
            this.pCrud.Controls.Add(this.checkBox1);
            this.pCrud.Controls.Add(this.cbAprovado);
            this.pCrud.Controls.Add(this.bMinimizar);
            this.pCrud.Controls.Add(this.bFechar);
            this.pCrud.Controls.Add(this.label2);
            this.pCrud.Dock = System.Windows.Forms.DockStyle.Right;
            this.pCrud.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.pCrud.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pCrud.Location = new System.Drawing.Point(577, 0);
            this.pCrud.Name = "pCrud";
            this.pCrud.Size = new System.Drawing.Size(279, 561);
            this.pCrud.TabIndex = 10;
            // 
            // bRemover
            // 
            this.bRemover.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bRemover.BackColor = System.Drawing.Color.Maroon;
            this.bRemover.FlatAppearance.BorderSize = 0;
            this.bRemover.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bRemover.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.bRemover.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bRemover.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.bRemover.IconChar = FontAwesome.Sharp.IconChar.Minus;
            this.bRemover.IconColor = System.Drawing.Color.WhiteSmoke;
            this.bRemover.IconSize = 16;
            this.bRemover.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bRemover.Location = new System.Drawing.Point(185, 186);
            this.bRemover.Name = "bRemover";
            this.bRemover.Rotation = 0D;
            this.bRemover.Size = new System.Drawing.Size(24, 24);
            this.bRemover.TabIndex = 47;
            this.bRemover.UseVisualStyleBackColor = false;
            // 
            // bAdd
            // 
            this.bAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bAdd.BackColor = System.Drawing.Color.Green;
            this.bAdd.FlatAppearance.BorderSize = 0;
            this.bAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bAdd.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.bAdd.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bAdd.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.bAdd.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.bAdd.IconColor = System.Drawing.Color.WhiteSmoke;
            this.bAdd.IconSize = 16;
            this.bAdd.Location = new System.Drawing.Point(154, 186);
            this.bAdd.Name = "bAdd";
            this.bAdd.Rotation = 0D;
            this.bAdd.Size = new System.Drawing.Size(24, 24);
            this.bAdd.TabIndex = 46;
            this.bAdd.UseVisualStyleBackColor = false;
            // 
            // txtDataOrcamento
            // 
            this.txtDataOrcamento.BeepOnError = true;
            this.txtDataOrcamento.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDataOrcamento.Location = new System.Drawing.Point(19, 57);
            this.txtDataOrcamento.Mask = "00/00/0000";
            this.txtDataOrcamento.Name = "txtDataOrcamento";
            this.txtDataOrcamento.Size = new System.Drawing.Size(104, 22);
            this.txtDataOrcamento.TabIndex = 43;
            this.txtDataOrcamento.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtDataOrcamento.ValidatingType = typeof(System.DateTime);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label5.Location = new System.Drawing.Point(19, 41);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 16);
            this.label5.TabIndex = 44;
            this.label5.Text = "Data orçamento";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label4.Location = new System.Drawing.Point(19, 168);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 16);
            this.label4.TabIndex = 42;
            this.label4.Text = "Lote";
            // 
            // cbbLote
            // 
            this.cbbLote.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbLote.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbbLote.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbLote.FormattingEnabled = true;
            this.cbbLote.Location = new System.Drawing.Point(22, 185);
            this.cbbLote.Name = "cbbLote";
            this.cbbLote.Size = new System.Drawing.Size(119, 24);
            this.cbbLote.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label3.Location = new System.Drawing.Point(19, 125);
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
            this.cbbCliente.Location = new System.Drawing.Point(22, 142);
            this.cbbCliente.Name = "cbbCliente";
            this.cbbCliente.Size = new System.Drawing.Size(237, 24);
            this.cbbCliente.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(19, 82);
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
            this.cbbProjeto.Location = new System.Drawing.Point(22, 99);
            this.cbbProjeto.Name = "cbbProjeto";
            this.cbbProjeto.Size = new System.Drawing.Size(237, 24);
            this.cbbProjeto.TabIndex = 2;
            // 
            // pCadastroEnd
            // 
            this.pCadastroEnd.Controls.Add(this.pBotoes);
            this.pCadastroEnd.Controls.Add(this.pEndereco);
            this.pCadastroEnd.Location = new System.Drawing.Point(7, 338);
            this.pCadastroEnd.Name = "pCadastroEnd";
            this.pCadastroEnd.Size = new System.Drawing.Size(260, 220);
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
            // 
            // pEndereco
            // 
            this.pEndereco.Controls.Add(this.cbbVencimento);
            this.pEndereco.Controls.Add(this.label12);
            this.pEndereco.Controls.Add(this.txtValorParcela);
            this.pEndereco.Controls.Add(this.txtMulta);
            this.pEndereco.Controls.Add(this.label10);
            this.pEndereco.Controls.Add(this.maskedTextBox1);
            this.pEndereco.Controls.Add(this.label9);
            this.pEndereco.Controls.Add(this.label8);
            this.pEndereco.Controls.Add(this.numParcelas);
            this.pEndereco.Controls.Add(this.label7);
            this.pEndereco.Controls.Add(this.txtValorTotal);
            this.pEndereco.Controls.Add(this.label6);
            this.pEndereco.Controls.Add(this.label11);
            this.pEndereco.Dock = System.Windows.Forms.DockStyle.Top;
            this.pEndereco.Location = new System.Drawing.Point(0, 0);
            this.pEndereco.Name = "pEndereco";
            this.pEndereco.Size = new System.Drawing.Size(260, 156);
            this.pEndereco.TabIndex = 32;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label12.Location = new System.Drawing.Point(175, 44);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(16, 16);
            this.label12.TabIndex = 46;
            this.label12.Text = "X";
            // 
            // txtValorParcela
            // 
            this.txtValorParcela.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValorParcela.Location = new System.Drawing.Point(190, 41);
            this.txtValorParcela.Name = "txtValorParcela";
            this.txtValorParcela.ReadOnly = true;
            this.txtValorParcela.Size = new System.Drawing.Size(62, 22);
            this.txtValorParcela.TabIndex = 45;
            // 
            // txtMulta
            // 
            this.txtMulta.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMulta.Location = new System.Drawing.Point(148, 121);
            this.txtMulta.Name = "txtMulta";
            this.txtMulta.Size = new System.Drawing.Size(104, 22);
            this.txtMulta.TabIndex = 4;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label10.Location = new System.Drawing.Point(145, 105);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(109, 16);
            this.label10.TabIndex = 44;
            this.label10.Text = "Multa - Opcional";
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.BeepOnError = true;
            this.maskedTextBox1.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskedTextBox1.Location = new System.Drawing.Point(15, 121);
            this.maskedTextBox1.Mask = "00/00/0000";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(104, 22);
            this.maskedTextBox1.TabIndex = 3;
            this.maskedTextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.maskedTextBox1.ValidatingType = typeof(System.DateTime);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label9.Location = new System.Drawing.Point(12, 105);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(93, 16);
            this.label9.TabIndex = 42;
            this.label9.Text = "Inicío do Pag.";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label8.Location = new System.Drawing.Point(12, 65);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(104, 16);
            this.label8.TabIndex = 40;
            this.label8.Text = "Vencimento dia";
            // 
            // numParcelas
            // 
            this.numParcelas.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numParcelas.Location = new System.Drawing.Point(128, 41);
            this.numParcelas.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numParcelas.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numParcelas.Name = "numParcelas";
            this.numParcelas.Size = new System.Drawing.Size(47, 22);
            this.numParcelas.TabIndex = 1;
            this.numParcelas.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numParcelas.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label7.Location = new System.Drawing.Point(122, 25);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 16);
            this.label7.TabIndex = 37;
            this.label7.Text = "Parcelas";
            // 
            // txtValorTotal
            // 
            this.txtValorTotal.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValorTotal.Location = new System.Drawing.Point(15, 41);
            this.txtValorTotal.Name = "txtValorTotal";
            this.txtValorTotal.Size = new System.Drawing.Size(104, 22);
            this.txtValorTotal.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label6.Location = new System.Drawing.Point(9, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(113, 16);
            this.label6.TabIndex = 0;
            this.label6.Text = "Valor Orçamento";
            // 
            // label11
            // 
            this.label11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label11.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label11.Location = new System.Drawing.Point(3, 5);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(254, 19);
            this.label11.TabIndex = 28;
            this.label11.Text = "Dados Orçamento";
            this.label11.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.BackColor = System.Drawing.Color.DarkCyan;
            this.checkBox1.FlatAppearance.BorderSize = 0;
            this.checkBox1.Font = new System.Drawing.Font("MS Reference Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.checkBox1.Location = new System.Drawing.Point(166, 58);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(95, 22);
            this.checkBox1.TabIndex = 5;
            this.checkBox1.Text = "Aprovado";
            this.checkBox1.UseVisualStyleBackColor = false;
            // 
            // cbAprovado
            // 
            this.cbAprovado.AutoSize = true;
            this.cbAprovado.BackColor = System.Drawing.Color.DarkCyan;
            this.cbAprovado.FlatAppearance.BorderSize = 0;
            this.cbAprovado.Font = new System.Drawing.Font("MS Reference Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbAprovado.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.cbAprovado.Location = new System.Drawing.Point(166, 55);
            this.cbAprovado.Name = "cbAprovado";
            this.cbAprovado.Size = new System.Drawing.Size(95, 22);
            this.cbAprovado.TabIndex = 8;
            this.cbAprovado.Text = "Aprovado";
            this.cbAprovado.UseVisualStyleBackColor = false;
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
            this.label2.Location = new System.Drawing.Point(8, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 29);
            this.label2.TabIndex = 7;
            this.label2.Text = "Orçamento";
            // 
            // dgvLote
            // 
            this.dgvLote.AllowUserToAddRows = false;
            this.dgvLote.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvLote.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvLote.BackgroundColor = System.Drawing.Color.DarkSlateGray;
            this.dgvLote.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvLote.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.DarkCyan;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvLote.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.dgvLote.ColumnHeadersHeight = 22;
            this.dgvLote.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvLote.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column3,
            this.Column1,
            this.Column2});
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.MediumTurquoise;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvLote.DefaultCellStyle = dataGridViewCellStyle11;
            this.dgvLote.EnableHeadersVisualStyles = false;
            this.dgvLote.GridColor = System.Drawing.SystemColors.GrayText;
            this.dgvLote.Location = new System.Drawing.Point(19, 216);
            this.dgvLote.Name = "dgvLote";
            this.dgvLote.ReadOnly = true;
            this.dgvLote.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.DarkCyan;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvLote.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.dgvLote.RowHeadersWidth = 37;
            this.dgvLote.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLote.Size = new System.Drawing.Size(240, 115);
            this.dgvLote.TabIndex = 48;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Codigo";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Visible = false;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Lote";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Quadra";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // cbbVencimento
            // 
            this.cbbVencimento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbVencimento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbbVencimento.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbVencimento.FormattingEnabled = true;
            this.cbbVencimento.Location = new System.Drawing.Point(15, 83);
            this.cbbVencimento.Name = "cbbVencimento";
            this.cbbVencimento.Size = new System.Drawing.Size(49, 24);
            this.cbbVencimento.TabIndex = 47;
            // 
            // fCadOrcamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(856, 561);
            this.Controls.Add(this.pDgvLocaliza);
            this.Controls.Add(this.pButtons);
            this.Controls.Add(this.pCrud);
            this.MaximumSize = new System.Drawing.Size(872, 600);
            this.MinimumSize = new System.Drawing.Size(872, 600);
            this.Name = "fCadOrcamento";
            this.Text = "Orçamento";
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
            ((System.ComponentModel.ISupportInitialize)(this.numParcelas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLote)).EndInit();
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
        private System.Windows.Forms.Panel pCadastroEnd;
        private System.Windows.Forms.Panel pBotoes;
        private FontAwesome.Sharp.IconButton bCancelar;
        private FontAwesome.Sharp.IconButton bSalvar;
        private System.Windows.Forms.Panel pEndereco;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.CheckBox cbAprovado;
        private FontAwesome.Sharp.IconButton bMinimizar;
        private FontAwesome.Sharp.IconButton bFechar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbbProjeto;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbbLote;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbbCliente;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtValorTotal;
        private System.Windows.Forms.NumericUpDown numParcelas;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MaskedTextBox txtDataOrcamento;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.TextBox txtMulta;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtValorParcela;
        private FontAwesome.Sharp.IconButton bRemover;
        private FontAwesome.Sharp.IconButton bAdd;
        private System.Windows.Forms.DataGridView dgvLote;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.ComboBox cbbVencimento;
    }
}