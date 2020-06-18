using GPF.View;
using System;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using GPF.Cache;
using System.IO;
using GPF.Repository;

namespace GPF
{
    public partial class fPrincipal : Form
    {
        ParametrizacaoRepository acc = new ParametrizacaoRepository();
        public fPrincipal()
        {
            InitializeComponent();
            customizarDesing();
        }
        //------------------------------
        #region movimentarTela
     
         [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);


        private void pCabecalho_MouseMove(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        #endregion
        //------------------------------

        private void fPrincipal_Load(object sender, EventArgs e)
        {
            LoadParametrizacao();
            LoadUsuario();
        }

        private void LoadUsuario()
        {
            lbNomeUsuario.Text = "Usuário: "+ UsuarioLoginCache.uso_nome;
        }
        public void LoadParametrizacao()
        {
            acc.carregarParametrizacao();
            lbNomeEmpresa.Text = ParametrizacaoCache.nome;
            lbCnpj.Text = ParametrizacaoCache.cnpj;
            byte[] imagem = ParametrizacaoCache.logo;
            MemoryStream memory = new MemoryStream(imagem);

            picFundo.Image = Image.FromStream(memory);
            picPrincipal.Image = Image.FromStream(memory);
          //  picRelatorio.Image = Image.FromStream(memory);

        }
       

        private void customizarDesing()
        {
            pSubCadastro.Visible = false;
            pSubGerProjeto.Visible = false;
            pSubPagamento.Visible = false;
            pSubConfiguracoes.Visible = false;
        }

        private void hideSubMenu()
        {
            if (pSubCadastro.Visible == true)
                pSubCadastro.Visible = false;
            if (pSubGerProjeto.Visible == true)
                pSubGerProjeto.Visible = false;
            if (pSubPagamento.Visible == true)
                pSubPagamento.Visible = false;
            if (pSubConfiguracoes.Visible == true)
                pSubConfiguracoes.Visible = false;
        }

        private void showSubMenu(Panel panel)
        {
            if(panel.Visible == false)
            {
                hideSubMenu();
                panel.Visible = true;
            }
            else
            {
                panel.Visible = false;
            }
        }


        private void bGerProjeto_Click(object sender, EventArgs e)
        {
            showSubMenu(pSubGerProjeto);
        }

        private void bCadastro_Click(object sender, EventArgs e)
        {
            showSubMenu(pSubCadastro);
        }

        private void bPagamento_Click(object sender, EventArgs e)
        {
            showSubMenu(pSubPagamento);
        }

        private void bSobre_Click(object sender, EventArgs e)
        {           
            showSubMenu(pSubConfiguracoes);                     
           // hideSubMenu();            
        }

        private void AbrirForm<MiForm>() where MiForm : Form, new()
        {
            Form formulario;
            formulario = pFilhoForm.Controls.OfType<MiForm>().FirstOrDefault();//Busca na lista se o formulario já esta aberto
            if (formulario == null)
            {
                formulario = new MiForm();
                formulario.TopLevel = false;
             //   formulario.FormBorderStyle = FormBorderStyle.None;
               // formulario.Dock = DockStyle.Fill;
                pFilhoForm.Controls.Add(formulario);
                pFilhoForm.Tag = formulario;
                formulario.Show();
                formulario.BringToFront();
            }
            //se formulario já existe
            else
            {
                formulario.BringToFront();
            }
        }

        private void bCadUsuario_Click(object sender, EventArgs e)
        {          
             AbrirForm<fCadUsuario>();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbRelogio.Text = DateTime.Now.ToString("HH:mm:ss");//d/M/yyyy 
            lbData.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }

        private void bLogout_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja fazer logout?", "Logout",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
               this.Close();                
            }               
          
        }  

        private void bCadPerfil_Click(object sender, EventArgs e)
        {
            AbrirForm<fCadPerfil>();
        }

        private void bCadParametrizacao_Click(object sender, EventArgs e)
        {
            AbrirForm<fCadParametrizacao>();
        }

        private void bCadCliente_Click(object sender, EventArgs e)
        {
            AbrirForm<fCadCliente>();
        }

        private void bOrcamento_Click(object sender, EventArgs e)
        {
           // AbrirForm<fCadRecebimento>();
        }

        private void bClienteXLote_Click(object sender, EventArgs e)
        {
            AbrirForm<fCadCliLote>();
        }

        private void bNovoProjeto_Click(object sender, EventArgs e)
        {
            AbrirForm<fCadProjeto>();
        }

        private void bBaixaRecebimento_Click(object sender, EventArgs e)
        {
            AbrirForm<fCadRecebimento>();
        }
    }
}
