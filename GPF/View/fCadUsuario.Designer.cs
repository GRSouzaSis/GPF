﻿namespace GPF.View
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
            this.pCrud = new System.Windows.Forms.Panel();
            this.bMinimizar = new FontAwesome.Sharp.IconButton();
            this.bFechar = new FontAwesome.Sharp.IconButton();
            this.label5 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.bCancelar = new FontAwesome.Sharp.IconButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbAtivo = new System.Windows.Forms.CheckBox();
            this.bSalvar = new FontAwesome.Sharp.IconButton();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.txtNomeUsuario = new System.Windows.Forms.TextBox();
            this.pButtons = new System.Windows.Forms.Panel();
            this.bExcluir = new FontAwesome.Sharp.IconButton();
            this.bAlterar = new FontAwesome.Sharp.IconButton();
            this.bNovo = new FontAwesome.Sharp.IconButton();
            this.pDgvLocaliza = new System.Windows.Forms.Panel();
            this.pBuscas = new System.Windows.Forms.Panel();
            this.bBuscar = new FontAwesome.Sharp.IconButton();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.dgvCadastro = new System.Windows.Forms.DataGridView();
            this.pCrud.SuspendLayout();
            this.pButtons.SuspendLayout();
            this.pDgvLocaliza.SuspendLayout();
            this.pBuscas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCadastro)).BeginInit();
            this.SuspendLayout();
            // 
            // pCrud
            // 
            this.pCrud.BackColor = System.Drawing.Color.DarkCyan;
            this.pCrud.Controls.Add(this.bMinimizar);
            this.pCrud.Controls.Add(this.bFechar);
            this.pCrud.Controls.Add(this.label5);
            this.pCrud.Controls.Add(this.txtId);
            this.pCrud.Controls.Add(this.bCancelar);
            this.pCrud.Controls.Add(this.label4);
            this.pCrud.Controls.Add(this.label3);
            this.pCrud.Controls.Add(this.label1);
            this.pCrud.Controls.Add(this.cbAtivo);
            this.pCrud.Controls.Add(this.bSalvar);
            this.pCrud.Controls.Add(this.label2);
            this.pCrud.Controls.Add(this.txtSenha);
            this.pCrud.Controls.Add(this.txtLogin);
            this.pCrud.Controls.Add(this.txtNomeUsuario);
            this.pCrud.Dock = System.Windows.Forms.DockStyle.Right;
            this.pCrud.Location = new System.Drawing.Point(505, 0);
            this.pCrud.Name = "pCrud";
            this.pCrud.Size = new System.Drawing.Size(279, 461);
            this.pCrud.TabIndex = 1;
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
            this.bMinimizar.Location = new System.Drawing.Point(222, 8);
            this.bMinimizar.Name = "bMinimizar";
            this.bMinimizar.Rotation = 0D;
            this.bMinimizar.Size = new System.Drawing.Size(24, 24);
            this.bMinimizar.TabIndex = 16;
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
            this.bFechar.IconSize = 24;
            this.bFechar.Location = new System.Drawing.Point(248, 7);
            this.bFechar.Name = "bFechar";
            this.bFechar.Rotation = 0D;
            this.bFechar.Size = new System.Drawing.Size(24, 24);
            this.bFechar.TabIndex = 15;
            this.bFechar.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label5.Location = new System.Drawing.Point(19, 72);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(22, 16);
            this.label5.TabIndex = 14;
            this.label5.Text = "ID";
            // 
            // txtId
            // 
            this.txtId.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtId.Location = new System.Drawing.Point(21, 91);
            this.txtId.MaxLength = 50;
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(46, 21);
            this.txtId.TabIndex = 13;
            // 
            // bCancelar
            // 
            this.bCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bCancelar.BackColor = System.Drawing.Color.OrangeRed;
            this.bCancelar.FlatAppearance.BorderSize = 0;
            this.bCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bCancelar.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.bCancelar.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bCancelar.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.bCancelar.IconChar = FontAwesome.Sharp.IconChar.None;
            this.bCancelar.IconColor = System.Drawing.Color.Black;
            this.bCancelar.IconSize = 16;
            this.bCancelar.Location = new System.Drawing.Point(21, 294);
            this.bCancelar.Name = "bCancelar";
            this.bCancelar.Rotation = 0D;
            this.bCancelar.Size = new System.Drawing.Size(230, 23);
            this.bCancelar.TabIndex = 5;
            this.bCancelar.Text = "Cancelar";
            this.bCancelar.UseVisualStyleBackColor = false;
            this.bCancelar.Click += new System.EventHandler(this.bCancelar_Click_1);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label4.Location = new System.Drawing.Point(19, 115);
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
            this.label3.Location = new System.Drawing.Point(19, 201);
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
            this.label1.Location = new System.Drawing.Point(19, 158);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 16);
            this.label1.TabIndex = 10;
            this.label1.Text = "Login";
            // 
            // cbAtivo
            // 
            this.cbAtivo.AutoSize = true;
            this.cbAtivo.BackColor = System.Drawing.Color.DarkCyan;
            this.cbAtivo.Checked = true;
            this.cbAtivo.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbAtivo.FlatAppearance.BorderSize = 0;
            this.cbAtivo.Font = new System.Drawing.Font("MS Reference Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbAtivo.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.cbAtivo.Location = new System.Drawing.Point(184, 90);
            this.cbAtivo.Name = "cbAtivo";
            this.cbAtivo.Size = new System.Drawing.Size(68, 22);
            this.cbAtivo.TabIndex = 0;
            this.cbAtivo.Text = "Ativo";
            this.cbAtivo.UseVisualStyleBackColor = false;
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
            this.bSalvar.IconChar = FontAwesome.Sharp.IconChar.None;
            this.bSalvar.IconColor = System.Drawing.Color.Black;
            this.bSalvar.IconSize = 16;
            this.bSalvar.Location = new System.Drawing.Point(21, 259);
            this.bSalvar.Name = "bSalvar";
            this.bSalvar.Rotation = 0D;
            this.bSalvar.Size = new System.Drawing.Size(230, 23);
            this.bSalvar.TabIndex = 4;
            this.bSalvar.Text = "Salvar";
            this.bSalvar.UseVisualStyleBackColor = false;
            this.bSalvar.Click += new System.EventHandler(this.bSalvar_Click_1);
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
            this.txtSenha.Location = new System.Drawing.Point(21, 220);
            this.txtSenha.MaxLength = 50;
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(230, 21);
            this.txtSenha.TabIndex = 3;
            // 
            // txtLogin
            // 
            this.txtLogin.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLogin.Location = new System.Drawing.Point(21, 177);
            this.txtLogin.MaxLength = 50;
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(230, 21);
            this.txtLogin.TabIndex = 2;
            // 
            // txtNomeUsuario
            // 
            this.txtNomeUsuario.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeUsuario.Location = new System.Drawing.Point(22, 134);
            this.txtNomeUsuario.MaxLength = 20;
            this.txtNomeUsuario.Name = "txtNomeUsuario";
            this.txtNomeUsuario.Size = new System.Drawing.Size(230, 21);
            this.txtNomeUsuario.TabIndex = 1;
            // 
            // pButtons
            // 
            this.pButtons.BackColor = System.Drawing.Color.LightSeaGreen;
            this.pButtons.Controls.Add(this.bExcluir);
            this.pButtons.Controls.Add(this.bAlterar);
            this.pButtons.Controls.Add(this.bNovo);
            this.pButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pButtons.Location = new System.Drawing.Point(0, 419);
            this.pButtons.Name = "pButtons";
            this.pButtons.Size = new System.Drawing.Size(505, 42);
            this.pButtons.TabIndex = 2;
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
            this.bExcluir.IconChar = FontAwesome.Sharp.IconChar.None;
            this.bExcluir.IconColor = System.Drawing.Color.Black;
            this.bExcluir.IconSize = 16;
            this.bExcluir.Location = new System.Drawing.Point(424, 9);
            this.bExcluir.Name = "bExcluir";
            this.bExcluir.Rotation = 0D;
            this.bExcluir.Size = new System.Drawing.Size(75, 23);
            this.bExcluir.TabIndex = 2;
            this.bExcluir.Text = "Remover";
            this.bExcluir.UseVisualStyleBackColor = false;
            this.bExcluir.Click += new System.EventHandler(this.bExcluir_Click_1);
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
            this.bAlterar.IconChar = FontAwesome.Sharp.IconChar.None;
            this.bAlterar.IconColor = System.Drawing.Color.Black;
            this.bAlterar.IconSize = 16;
            this.bAlterar.Location = new System.Drawing.Point(343, 9);
            this.bAlterar.Name = "bAlterar";
            this.bAlterar.Rotation = 0D;
            this.bAlterar.Size = new System.Drawing.Size(75, 23);
            this.bAlterar.TabIndex = 1;
            this.bAlterar.Text = "Alterar";
            this.bAlterar.UseVisualStyleBackColor = false;
            this.bAlterar.Click += new System.EventHandler(this.bAlterar_Click_1);
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
            this.bNovo.IconChar = FontAwesome.Sharp.IconChar.None;
            this.bNovo.IconColor = System.Drawing.Color.Black;
            this.bNovo.IconSize = 16;
            this.bNovo.Location = new System.Drawing.Point(262, 9);
            this.bNovo.Name = "bNovo";
            this.bNovo.Rotation = 0D;
            this.bNovo.Size = new System.Drawing.Size(75, 23);
            this.bNovo.TabIndex = 0;
            this.bNovo.Text = "Novo";
            this.bNovo.UseVisualStyleBackColor = false;
            this.bNovo.Click += new System.EventHandler(this.bNovo_Click_1);
            // 
            // pDgvLocaliza
            // 
            this.pDgvLocaliza.BackColor = System.Drawing.Color.LightSeaGreen;
            this.pDgvLocaliza.Controls.Add(this.pBuscas);
            this.pDgvLocaliza.Controls.Add(this.dgvCadastro);
            this.pDgvLocaliza.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pDgvLocaliza.Location = new System.Drawing.Point(0, 0);
            this.pDgvLocaliza.Name = "pDgvLocaliza";
            this.pDgvLocaliza.Size = new System.Drawing.Size(505, 419);
            this.pDgvLocaliza.TabIndex = 3;
            // 
            // pBuscas
            // 
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
            this.bBuscar.IconChar = FontAwesome.Sharp.IconChar.None;
            this.bBuscar.IconColor = System.Drawing.Color.Black;
            this.bBuscar.IconSize = 16;
            this.bBuscar.Location = new System.Drawing.Point(422, 7);
            this.bBuscar.Name = "bBuscar";
            this.bBuscar.Rotation = 0D;
            this.bBuscar.Size = new System.Drawing.Size(75, 29);
            this.bBuscar.TabIndex = 1;
            this.bBuscar.Text = "Buscar";
            this.bBuscar.UseVisualStyleBackColor = false;
            this.bBuscar.Click += new System.EventHandler(this.bBuscar_Click_1);
            // 
            // txtDescricao
            // 
            this.txtDescricao.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDescricao.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescricao.Location = new System.Drawing.Point(12, 12);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(405, 21);
            this.txtDescricao.TabIndex = 0;
            // 
            // dgvCadastro
            // 
            this.dgvCadastro.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvCadastro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCadastro.Location = new System.Drawing.Point(12, 48);
            this.dgvCadastro.Name = "dgvCadastro";
            this.dgvCadastro.Size = new System.Drawing.Size(487, 365);
            this.dgvCadastro.TabIndex = 0;
            this.dgvCadastro.DoubleClick += new System.EventHandler(this.dgvCadastro_DoubleClick_1);
            // 
            // fCadUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.pDgvLocaliza);
            this.Controls.Add(this.pButtons);
            this.Controls.Add(this.pCrud);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MaximumSize = new System.Drawing.Size(800, 500);
            this.MinimumSize = new System.Drawing.Size(600, 430);
            this.Name = "fCadUsuario";
            this.Text = "Cadastro Usuário";
            this.pCrud.ResumeLayout(false);
            this.pCrud.PerformLayout();
            this.pButtons.ResumeLayout(false);
            this.pDgvLocaliza.ResumeLayout(false);
            this.pBuscas.ResumeLayout(false);
            this.pBuscas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCadastro)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pCrud;
        private System.Windows.Forms.Panel pButtons;
        private System.Windows.Forms.Panel pDgvLocaliza;
        private System.Windows.Forms.Panel pBuscas;
        private FontAwesome.Sharp.IconButton bBuscar;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.DataGridView dgvCadastro;
        private FontAwesome.Sharp.IconButton bExcluir;
        private FontAwesome.Sharp.IconButton bAlterar;
        private FontAwesome.Sharp.IconButton bNovo;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.TextBox txtNomeUsuario;
        private System.Windows.Forms.Label label2;
        private FontAwesome.Sharp.IconButton bSalvar;
        private System.Windows.Forms.CheckBox cbAtivo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton bCancelar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtId;
        private FontAwesome.Sharp.IconButton bMinimizar;
        private FontAwesome.Sharp.IconButton bFechar;
    }
}