namespace GPF.View
{
    partial class fCadRecebimento
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle25 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle26 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle27 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle28 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle29 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle30 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle31 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle32 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pCrud = new System.Windows.Forms.Panel();
            this.gbBaixaRecebimentos = new System.Windows.Forms.GroupBox();
            this.bBaixa = new FontAwesome.Sharp.IconButton();
            this.txtLotid = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.txtValorPago = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtValorTotal = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.dgvLotes = new System.Windows.Forms.DataGridView();
            this.gbFiltrados = new System.Windows.Forms.GroupBox();
            this.bTodos = new FontAwesome.Sharp.IconButton();
            this.bDetalhes = new FontAwesome.Sharp.IconButton();
            this.pRodape = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbTotalSelecionado = new System.Windows.Forms.Label();
            this.bCalcular = new FontAwesome.Sharp.IconButton();
            this.lbSomaSelect = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lbTotal = new System.Windows.Forms.Label();
            this.dgvReceber = new System.Windows.Forms.DataGridView();
            this.cbbCliente = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.gbFiltro = new System.Windows.Forms.GroupBox();
            this.bNovaBusca = new FontAwesome.Sharp.IconButton();
            this.label7 = new System.Windows.Forms.Label();
            this.cbbTipoMovimento = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.bFiltro = new FontAwesome.Sharp.IconButton();
            this.cbbProjeto = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.dtpVencFinal = new System.Windows.Forms.DateTimePicker();
            this.dtpVencInicial = new System.Windows.Forms.DateTimePicker();
            this.bFechar = new FontAwesome.Sharp.IconButton();
            this.pCrud.SuspendLayout();
            this.gbBaixaRecebimentos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLotes)).BeginInit();
            this.gbFiltrados.SuspendLayout();
            this.pRodape.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReceber)).BeginInit();
            this.gbFiltro.SuspendLayout();
            this.SuspendLayout();
            // 
            // pCrud
            // 
            this.pCrud.BackColor = System.Drawing.Color.CadetBlue;
            this.pCrud.Controls.Add(this.gbBaixaRecebimentos);
            this.pCrud.Controls.Add(this.gbFiltrados);
            this.pCrud.Controls.Add(this.gbFiltro);
            this.pCrud.Controls.Add(this.bFechar);
            this.pCrud.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pCrud.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.pCrud.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pCrud.Location = new System.Drawing.Point(0, 0);
            this.pCrud.Name = "pCrud";
            this.pCrud.Size = new System.Drawing.Size(996, 493);
            this.pCrud.TabIndex = 10;
            // 
            // gbBaixaRecebimentos
            // 
            this.gbBaixaRecebimentos.Controls.Add(this.bBaixa);
            this.gbBaixaRecebimentos.Controls.Add(this.txtLotid);
            this.gbBaixaRecebimentos.Controls.Add(this.label24);
            this.gbBaixaRecebimentos.Controls.Add(this.txtValorPago);
            this.gbBaixaRecebimentos.Controls.Add(this.label1);
            this.gbBaixaRecebimentos.Controls.Add(this.txtValorTotal);
            this.gbBaixaRecebimentos.Controls.Add(this.label14);
            this.gbBaixaRecebimentos.Controls.Add(this.dgvLotes);
            this.gbBaixaRecebimentos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbBaixaRecebimentos.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.gbBaixaRecebimentos.Location = new System.Drawing.Point(691, 86);
            this.gbBaixaRecebimentos.Name = "gbBaixaRecebimentos";
            this.gbBaixaRecebimentos.Size = new System.Drawing.Size(292, 395);
            this.gbBaixaRecebimentos.TabIndex = 141;
            this.gbBaixaRecebimentos.TabStop = false;
            this.gbBaixaRecebimentos.Text = "Baixa de Recebimentos";
            // 
            // bBaixa
            // 
            this.bBaixa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bBaixa.BackColor = System.Drawing.SystemColors.Highlight;
            this.bBaixa.FlatAppearance.BorderSize = 0;
            this.bBaixa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bBaixa.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.bBaixa.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bBaixa.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.bBaixa.IconChar = FontAwesome.Sharp.IconChar.ArrowDown;
            this.bBaixa.IconColor = System.Drawing.Color.WhiteSmoke;
            this.bBaixa.IconSize = 16;
            this.bBaixa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bBaixa.Location = new System.Drawing.Point(188, 358);
            this.bBaixa.Name = "bBaixa";
            this.bBaixa.Rotation = 0D;
            this.bBaixa.Size = new System.Drawing.Size(89, 24);
            this.bBaixa.TabIndex = 151;
            this.bBaixa.Text = "Baixar";
            this.bBaixa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bBaixa.UseVisualStyleBackColor = false;
            // 
            // txtLotid
            // 
            this.txtLotid.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLotid.Location = new System.Drawing.Point(9, 310);
            this.txtLotid.MaxLength = 4;
            this.txtLotid.Name = "txtLotid";
            this.txtLotid.ReadOnly = true;
            this.txtLotid.Size = new System.Drawing.Size(43, 22);
            this.txtLotid.TabIndex = 149;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label24.Location = new System.Drawing.Point(6, 291);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(61, 16);
            this.label24.TabIndex = 150;
            this.label24.Text = "CodLote";
            // 
            // txtValorPago
            // 
            this.txtValorPago.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValorPago.Location = new System.Drawing.Point(182, 309);
            this.txtValorPago.Name = "txtValorPago";
            this.txtValorPago.Size = new System.Drawing.Size(104, 22);
            this.txtValorPago.TabIndex = 147;
            this.txtValorPago.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValorPago_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(179, 290);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 16);
            this.label1.TabIndex = 148;
            this.label1.Text = "Valor Pago";
            // 
            // txtValorTotal
            // 
            this.txtValorTotal.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValorTotal.Location = new System.Drawing.Point(71, 309);
            this.txtValorTotal.Name = "txtValorTotal";
            this.txtValorTotal.ReadOnly = true;
            this.txtValorTotal.Size = new System.Drawing.Size(104, 22);
            this.txtValorTotal.TabIndex = 145;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label14.Location = new System.Drawing.Point(68, 290);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(40, 16);
            this.label14.TabIndex = 146;
            this.label14.Text = "Valor";
            // 
            // dgvLotes
            // 
            this.dgvLotes.AllowUserToAddRows = false;
            dataGridViewCellStyle25.BackColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle25.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dgvLotes.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle25;
            this.dgvLotes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.dgvLotes.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvLotes.BackgroundColor = System.Drawing.Color.DarkSlateGray;
            this.dgvLotes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvLotes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle26.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle26.BackColor = System.Drawing.SystemColors.AppWorkspace;
            dataGridViewCellStyle26.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle26.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle26.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle26.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle26.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvLotes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle26;
            this.dgvLotes.ColumnHeadersHeight = 25;
            this.dgvLotes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle27.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle27.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle27.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle27.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle27.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle27.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle27.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvLotes.DefaultCellStyle = dataGridViewCellStyle27;
            this.dgvLotes.EnableHeadersVisualStyles = false;
            this.dgvLotes.GridColor = System.Drawing.SystemColors.GrayText;
            this.dgvLotes.Location = new System.Drawing.Point(6, 63);
            this.dgvLotes.Name = "dgvLotes";
            this.dgvLotes.ReadOnly = true;
            this.dgvLotes.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle28.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle28.BackColor = System.Drawing.SystemColors.AppWorkspace;
            dataGridViewCellStyle28.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle28.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle28.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle28.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle28.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvLotes.RowHeadersDefaultCellStyle = dataGridViewCellStyle28;
            this.dgvLotes.RowHeadersWidth = 20;
            this.dgvLotes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLotes.Size = new System.Drawing.Size(280, 220);
            this.dgvLotes.TabIndex = 144;
            this.dgvLotes.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLotes_CellDoubleClick);
            // 
            // gbFiltrados
            // 
            this.gbFiltrados.Controls.Add(this.bTodos);
            this.gbFiltrados.Controls.Add(this.pRodape);
            this.gbFiltrados.Controls.Add(this.dgvReceber);
            this.gbFiltrados.Controls.Add(this.cbbCliente);
            this.gbFiltrados.Controls.Add(this.label3);
            this.gbFiltrados.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbFiltrados.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.gbFiltrados.Location = new System.Drawing.Point(12, 86);
            this.gbFiltrados.Name = "gbFiltrados";
            this.gbFiltrados.Size = new System.Drawing.Size(673, 395);
            this.gbFiltrados.TabIndex = 140;
            this.gbFiltrados.TabStop = false;
            this.gbFiltrados.Text = "Filtrados";
            // 
            // bTodos
            // 
            this.bTodos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bTodos.BackColor = System.Drawing.Color.RoyalBlue;
            this.bTodos.FlatAppearance.BorderSize = 0;
            this.bTodos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bTodos.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.bTodos.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bTodos.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.bTodos.IconChar = FontAwesome.Sharp.IconChar.Undo;
            this.bTodos.IconColor = System.Drawing.Color.WhiteSmoke;
            this.bTodos.IconSize = 16;
            this.bTodos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bTodos.Location = new System.Drawing.Point(405, 33);
            this.bTodos.Name = "bTodos";
            this.bTodos.Rotation = 0D;
            this.bTodos.Size = new System.Drawing.Size(75, 24);
            this.bTodos.TabIndex = 145;
            this.bTodos.Text = "Todos";
            this.bTodos.UseVisualStyleBackColor = false;
            this.bTodos.Click += new System.EventHandler(this.bTodos_Click);
            // 
            // bDetalhes
            // 
            this.bDetalhes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bDetalhes.BackColor = System.Drawing.SystemColors.Highlight;
            this.bDetalhes.FlatAppearance.BorderSize = 0;
            this.bDetalhes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bDetalhes.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.bDetalhes.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bDetalhes.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.bDetalhes.IconChar = FontAwesome.Sharp.IconChar.Share;
            this.bDetalhes.IconColor = System.Drawing.Color.WhiteSmoke;
            this.bDetalhes.IconSize = 16;
            this.bDetalhes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bDetalhes.Location = new System.Drawing.Point(207, 31);
            this.bDetalhes.Name = "bDetalhes";
            this.bDetalhes.Rotation = 0D;
            this.bDetalhes.Size = new System.Drawing.Size(89, 24);
            this.bDetalhes.TabIndex = 144;
            this.bDetalhes.Text = "Detalhes";
            this.bDetalhes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bDetalhes.UseVisualStyleBackColor = false;
            this.bDetalhes.Click += new System.EventHandler(this.bDetalhes_Click);
            // 
            // pRodape
            // 
            this.pRodape.BackColor = System.Drawing.Color.PowderBlue;
            this.pRodape.Controls.Add(this.label8);
            this.pRodape.Controls.Add(this.bDetalhes);
            this.pRodape.Controls.Add(this.label2);
            this.pRodape.Controls.Add(this.lbTotalSelecionado);
            this.pRodape.Controls.Add(this.bCalcular);
            this.pRodape.Controls.Add(this.lbSomaSelect);
            this.pRodape.Controls.Add(this.label10);
            this.pRodape.Controls.Add(this.lbTotal);
            this.pRodape.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pRodape.Location = new System.Drawing.Point(3, 320);
            this.pRodape.Name = "pRodape";
            this.pRodape.Size = new System.Drawing.Size(667, 72);
            this.pRodape.TabIndex = 140;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Maroon;
            this.label8.Location = new System.Drawing.Point(331, 19);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 16);
            this.label8.TabIndex = 148;
            this.label8.Text = "Itens";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Maroon;
            this.label2.Location = new System.Drawing.Point(416, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 16);
            this.label2.TabIndex = 147;
            this.label2.Text = "Total Itens";
            // 
            // lbTotalSelecionado
            // 
            this.lbTotalSelecionado.AutoSize = true;
            this.lbTotalSelecionado.Font = new System.Drawing.Font("MS Reference Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotalSelecionado.ForeColor = System.Drawing.Color.Maroon;
            this.lbTotalSelecionado.Location = new System.Drawing.Point(341, 41);
            this.lbTotalSelecionado.Name = "lbTotalSelecionado";
            this.lbTotalSelecionado.Size = new System.Drawing.Size(18, 18);
            this.lbTotalSelecionado.TabIndex = 146;
            this.lbTotalSelecionado.Text = "0";
            this.lbTotalSelecionado.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // bCalcular
            // 
            this.bCalcular.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bCalcular.BackColor = System.Drawing.SystemColors.Highlight;
            this.bCalcular.FlatAppearance.BorderSize = 0;
            this.bCalcular.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bCalcular.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.bCalcular.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bCalcular.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.bCalcular.IconChar = FontAwesome.Sharp.IconChar.PlusCircle;
            this.bCalcular.IconColor = System.Drawing.Color.WhiteSmoke;
            this.bCalcular.IconSize = 16;
            this.bCalcular.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bCalcular.Location = new System.Drawing.Point(10, 31);
            this.bCalcular.Name = "bCalcular";
            this.bCalcular.Rotation = 0D;
            this.bCalcular.Size = new System.Drawing.Size(169, 24);
            this.bCalcular.TabIndex = 145;
            this.bCalcular.Text = "Calcular Selecionados";
            this.bCalcular.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bCalcular.UseVisualStyleBackColor = false;
            this.bCalcular.Click += new System.EventHandler(this.bCalcular_Click);
            // 
            // lbSomaSelect
            // 
            this.lbSomaSelect.AutoSize = true;
            this.lbSomaSelect.Font = new System.Drawing.Font("MS Reference Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSomaSelect.ForeColor = System.Drawing.Color.Maroon;
            this.lbSomaSelect.Location = new System.Drawing.Point(393, 41);
            this.lbSomaSelect.Name = "lbSomaSelect";
            this.lbSomaSelect.Size = new System.Drawing.Size(80, 18);
            this.lbSomaSelect.TabIndex = 4;
            this.lbSomaSelect.Text = "0.000,00";
            this.lbSomaSelect.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Maroon;
            this.label10.Location = new System.Drawing.Point(574, 19);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(76, 16);
            this.label10.TabIndex = 3;
            this.label10.Text = "Total Geral";
            // 
            // lbTotal
            // 
            this.lbTotal.AutoSize = true;
            this.lbTotal.Font = new System.Drawing.Font("MS Reference Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotal.ForeColor = System.Drawing.Color.Maroon;
            this.lbTotal.Location = new System.Drawing.Point(541, 42);
            this.lbTotal.Name = "lbTotal";
            this.lbTotal.Size = new System.Drawing.Size(80, 18);
            this.lbTotal.TabIndex = 2;
            this.lbTotal.Text = "0.000,00";
            this.lbTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dgvReceber
            // 
            this.dgvReceber.AllowUserToAddRows = false;
            this.dgvReceber.AllowUserToDeleteRows = false;
            dataGridViewCellStyle29.BackColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle29.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dgvReceber.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle29;
            this.dgvReceber.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.dgvReceber.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvReceber.BackgroundColor = System.Drawing.Color.DarkSlateGray;
            this.dgvReceber.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvReceber.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle30.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle30.BackColor = System.Drawing.SystemColors.AppWorkspace;
            dataGridViewCellStyle30.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle30.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle30.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle30.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle30.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvReceber.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle30;
            this.dgvReceber.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle31.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle31.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle31.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle31.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle31.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle31.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle31.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvReceber.DefaultCellStyle = dataGridViewCellStyle31;
            this.dgvReceber.EnableHeadersVisualStyles = false;
            this.dgvReceber.GridColor = System.Drawing.SystemColors.GrayText;
            this.dgvReceber.Location = new System.Drawing.Point(7, 63);
            this.dgvReceber.Name = "dgvReceber";
            this.dgvReceber.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle32.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle32.BackColor = System.Drawing.SystemColors.AppWorkspace;
            dataGridViewCellStyle32.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle32.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle32.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle32.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle32.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvReceber.RowHeadersDefaultCellStyle = dataGridViewCellStyle32;
            this.dgvReceber.RowHeadersWidth = 20;
            this.dgvReceber.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvReceber.Size = new System.Drawing.Size(659, 252);
            this.dgvReceber.TabIndex = 137;
            this.dgvReceber.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvReceber_CellClick);
            // 
            // cbbCliente
            // 
            this.cbbCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbbCliente.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbCliente.FormattingEnabled = true;
            this.cbbCliente.Location = new System.Drawing.Point(7, 33);
            this.cbbCliente.Name = "cbbCliente";
            this.cbbCliente.Size = new System.Drawing.Size(383, 24);
            this.cbbCliente.TabIndex = 139;
            this.cbbCliente.SelectionChangeCommitted += new System.EventHandler(this.cbbCliente_SelectionChangeCommitted);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label3.Location = new System.Drawing.Point(4, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 16);
            this.label3.TabIndex = 142;
            this.label3.Text = "Cliente";
            // 
            // gbFiltro
            // 
            this.gbFiltro.Controls.Add(this.bNovaBusca);
            this.gbFiltro.Controls.Add(this.label7);
            this.gbFiltro.Controls.Add(this.cbbTipoMovimento);
            this.gbFiltro.Controls.Add(this.label6);
            this.gbFiltro.Controls.Add(this.bFiltro);
            this.gbFiltro.Controls.Add(this.cbbProjeto);
            this.gbFiltro.Controls.Add(this.label5);
            this.gbFiltro.Controls.Add(this.label15);
            this.gbFiltro.Controls.Add(this.dtpVencFinal);
            this.gbFiltro.Controls.Add(this.dtpVencInicial);
            this.gbFiltro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbFiltro.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.gbFiltro.Location = new System.Drawing.Point(12, 6);
            this.gbFiltro.Name = "gbFiltro";
            this.gbFiltro.Size = new System.Drawing.Size(942, 79);
            this.gbFiltro.TabIndex = 138;
            this.gbFiltro.TabStop = false;
            this.gbFiltro.Text = "Filtro";
            // 
            // bNovaBusca
            // 
            this.bNovaBusca.BackColor = System.Drawing.Color.SeaGreen;
            this.bNovaBusca.FlatAppearance.BorderSize = 0;
            this.bNovaBusca.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bNovaBusca.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.bNovaBusca.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bNovaBusca.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.bNovaBusca.IconChar = FontAwesome.Sharp.IconChar.Check;
            this.bNovaBusca.IconColor = System.Drawing.Color.WhiteSmoke;
            this.bNovaBusca.IconSize = 16;
            this.bNovaBusca.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bNovaBusca.Location = new System.Drawing.Point(818, 35);
            this.bNovaBusca.Name = "bNovaBusca";
            this.bNovaBusca.Rotation = 0D;
            this.bNovaBusca.Size = new System.Drawing.Size(98, 25);
            this.bNovaBusca.TabIndex = 150;
            this.bNovaBusca.Text = "Nova busca";
            this.bNovaBusca.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bNovaBusca.UseVisualStyleBackColor = false;
            this.bNovaBusca.Click += new System.EventHandler(this.bNovaBusca_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label7.Location = new System.Drawing.Point(611, 17);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(106, 16);
            this.label7.TabIndex = 149;
            this.label7.Text = "Tipo Movimento";
            // 
            // cbbTipoMovimento
            // 
            this.cbbTipoMovimento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbTipoMovimento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbbTipoMovimento.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbTipoMovimento.FormattingEnabled = true;
            this.cbbTipoMovimento.Location = new System.Drawing.Point(614, 36);
            this.cbbTipoMovimento.Name = "cbbTipoMovimento";
            this.cbbTipoMovimento.Size = new System.Drawing.Size(117, 24);
            this.cbbTipoMovimento.TabIndex = 148;
            this.cbbTipoMovimento.SelectedValueChanged += new System.EventHandler(this.cbbTipoMovimento_SelectedValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label6.Location = new System.Drawing.Point(4, 17);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 16);
            this.label6.TabIndex = 146;
            this.label6.Text = "Projeto";
            // 
            // bFiltro
            // 
            this.bFiltro.BackColor = System.Drawing.Color.RoyalBlue;
            this.bFiltro.FlatAppearance.BorderSize = 0;
            this.bFiltro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bFiltro.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.bFiltro.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bFiltro.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.bFiltro.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.bFiltro.IconColor = System.Drawing.Color.WhiteSmoke;
            this.bFiltro.IconSize = 20;
            this.bFiltro.Location = new System.Drawing.Point(737, 36);
            this.bFiltro.Name = "bFiltro";
            this.bFiltro.Rotation = 0D;
            this.bFiltro.Size = new System.Drawing.Size(37, 24);
            this.bFiltro.TabIndex = 147;
            this.bFiltro.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bFiltro.UseVisualStyleBackColor = false;
            this.bFiltro.Click += new System.EventHandler(this.bFiltro_Click);
            // 
            // cbbProjeto
            // 
            this.cbbProjeto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbProjeto.DropDownWidth = 350;
            this.cbbProjeto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbbProjeto.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbProjeto.FormattingEnabled = true;
            this.cbbProjeto.Location = new System.Drawing.Point(7, 36);
            this.cbbProjeto.Name = "cbbProjeto";
            this.cbbProjeto.Size = new System.Drawing.Size(352, 24);
            this.cbbProjeto.TabIndex = 145;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label5.Location = new System.Drawing.Point(487, 17);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 16);
            this.label5.TabIndex = 143;
            this.label5.Text = "Vencimento Final";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label15.Location = new System.Drawing.Point(362, 17);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(121, 16);
            this.label15.TabIndex = 142;
            this.label15.Text = "Vencimento Inicial";
            // 
            // dtpVencFinal
            // 
            this.dtpVencFinal.CustomFormat = "";
            this.dtpVencFinal.Font = new System.Drawing.Font("MS Reference Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpVencFinal.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpVencFinal.Location = new System.Drawing.Point(490, 36);
            this.dtpVencFinal.Name = "dtpVencFinal";
            this.dtpVencFinal.Size = new System.Drawing.Size(119, 24);
            this.dtpVencFinal.TabIndex = 2;
            this.dtpVencFinal.Value = new System.DateTime(2020, 5, 18, 0, 0, 0, 0);
            this.dtpVencFinal.ValueChanged += new System.EventHandler(this.dtpVencFinal_ValueChanged);
            // 
            // dtpVencInicial
            // 
            this.dtpVencInicial.CustomFormat = "";
            this.dtpVencInicial.Font = new System.Drawing.Font("MS Reference Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpVencInicial.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpVencInicial.Location = new System.Drawing.Point(365, 36);
            this.dtpVencInicial.Name = "dtpVencInicial";
            this.dtpVencInicial.Size = new System.Drawing.Size(120, 24);
            this.dtpVencInicial.TabIndex = 1;
            this.dtpVencInicial.Value = new System.DateTime(2020, 5, 18, 0, 0, 0, 0);
            this.dtpVencInicial.ValueChanged += new System.EventHandler(this.dtpVencInicial_ValueChanged);
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
            this.bFechar.Location = new System.Drawing.Point(965, 10);
            this.bFechar.Name = "bFechar";
            this.bFechar.Rotation = 0D;
            this.bFechar.Size = new System.Drawing.Size(24, 24);
            this.bFechar.TabIndex = 1;
            this.bFechar.UseVisualStyleBackColor = true;
            // 
            // fCadRecebimento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(996, 493);
            this.Controls.Add(this.pCrud);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "fCadRecebimento";
            this.Text = "Recebimentos";
            this.Load += new System.EventHandler(this.fCadRecebimento_Load);
            this.pCrud.ResumeLayout(false);
            this.gbBaixaRecebimentos.ResumeLayout(false);
            this.gbBaixaRecebimentos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLotes)).EndInit();
            this.gbFiltrados.ResumeLayout(false);
            this.gbFiltrados.PerformLayout();
            this.pRodape.ResumeLayout(false);
            this.pRodape.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReceber)).EndInit();
            this.gbFiltro.ResumeLayout(false);
            this.gbFiltro.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pCrud;
        private FontAwesome.Sharp.IconButton bFechar;
        private System.Windows.Forms.GroupBox gbFiltro;
        private System.Windows.Forms.DateTimePicker dtpVencFinal;
        private System.Windows.Forms.DateTimePicker dtpVencInicial;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbbProjeto;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label15;
        private FontAwesome.Sharp.IconButton bFiltro;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbbTipoMovimento;
        private System.Windows.Forms.GroupBox gbBaixaRecebimentos;
        private System.Windows.Forms.GroupBox gbFiltrados;
        private FontAwesome.Sharp.IconButton bDetalhes;
        private System.Windows.Forms.Panel pRodape;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lbTotal;
        private System.Windows.Forms.DataGridView dgvReceber;
        private System.Windows.Forms.ComboBox cbbCliente;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvLotes;
        private System.Windows.Forms.TextBox txtValorPago;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtValorTotal;
        private System.Windows.Forms.Label label14;
        private FontAwesome.Sharp.IconButton bBaixa;
        private System.Windows.Forms.TextBox txtLotid;
        private System.Windows.Forms.Label label24;
        private FontAwesome.Sharp.IconButton bNovaBusca;
        private FontAwesome.Sharp.IconButton bTodos;
        private System.Windows.Forms.Label lbSomaSelect;
        private FontAwesome.Sharp.IconButton bCalcular;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbTotalSelecionado;
    }
}