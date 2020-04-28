using GPF.Helper;
using GPF.Model;
using GPF.Repository;
using System;
using System.Linq;
using System.Windows.Forms;

namespace GPF.View
{
    public partial class fCadUsuario : Form
    {
        public UsuarioRepository UsuarioRepository { get; set; }
        public Usuario Usuario { get;private set; }
        public fCadUsuario()
        {
            InitializeComponent();
            Inicializar();
        }

        private void Inicializar()
        {
            Usuario = new Usuario();          
            HabilitarControles();
            AtualizarInterface();
        }

        public void HabilitarControles(bool editando = false, bool visualizando = false)
        {
            txtNomeUsuario.Enabled = editando;
            txtLogin.Enabled = editando;
            txtSenha.Enabled = editando;
            cbAtivo.Enabled = editando;

            bNovo.Enabled = !editando || visualizando;
            bSalvar.Enabled = editando;
            bCancelar.Enabled = editando || visualizando;
            bExcluir.Enabled = visualizando;
            bBuscar.Enabled = !editando || visualizando;
            bAlterar.Enabled = visualizando;

            if (editando)
            {
                txtNomeUsuario.Focus();
            }
            else
            {
                if (visualizando)
                {
                    bAlterar.Focus();
                }
                else
                {
                    bNovo.Focus();
                }
            }
        }
    
        private void AtualizarInterface()
        {
            if (Usuario == null)
            {
                Usuario = new Usuario();
            }
            else
            {
                txtNomeUsuario.Text = Usuario.uso_nome.ToString();
                txtLogin.Text = Usuario.uso_login.ToString();
                txtSenha.Text = Usuario.uso_senha.ToString();
               
                //cbAtivo.Checked = Convert.ToBoolean(Usuario.pes_id.pes_ativo);
            }
        }

        private bool AtualizarObjeto()
        {           

            string nome = txtNomeUsuario.Text.Trim();
            if (nome == string.Empty)
            {
                DialogHelper.Alerta("Informe um nome de usuário.");
                txtNomeUsuario.Focus();
                return false;
            }

            string login = txtLogin.Text.Trim();
            if (login == string.Empty)
            {
                DialogHelper.Alerta("Informe um login de usuário.");
                txtLogin.Focus();
                return false;
            }

            string senha = txtSenha.Text;
            if (senha == string.Empty)
            {
                DialogHelper.Alerta("Informe uma senha de usuário.");
                txtSenha.Focus();
                return false;
            }
            int ativo = cbAtivo.Checked ? 1 : 0;


            if (Usuario == null)
            {
                Usuario = new Usuario();
            }

            Usuario.uso_login = login;
            Usuario.uso_senha = senha;
            Usuario.uso_nome = nome;
            Usuario.uso_ativo = ativo;             
            return true;
        }

        private bool validaObjeto()
        {
            if (txtNomeUsuario.Text.Length > 20)
            {
                DialogHelper.Alerta("O nome de usuário não pode ter mais que 20 caracteres");
                txtNomeUsuario.Focus();
                return false;
            }
            if (txtNomeUsuario.Text == String.Empty)
            {
                DialogHelper.Alerta("Informe um nome de usuário");
                txtNomeUsuario.Focus();
                return false;
            }
            if (txtLogin.Text.Length > 20)
            {
                DialogHelper.Alerta("O login de usuário não pode ter mais que 20 caracteres");
                txtLogin.Focus();
                return false;
            }
            if (txtLogin.Text == String.Empty)
            {
                DialogHelper.Alerta("Informe um login de usuário");
                txtLogin.Focus();
                return false;
            }
            if (txtSenha.Text.Length > 25)
            {
                DialogHelper.Alerta("A senha de usuário não pode ter mais que 25 caracteres");
                txtSenha.Focus();
                return false;
            }
            if (txtSenha.Text == String.Empty)
            {
                DialogHelper.Alerta("Informe uma senha de usuário");
                txtSenha.Focus();
                return false;
            }
            return true;
        }


        private void bNovo_Click_1(object sender, EventArgs e)
        {
            Inicializar();
            HabilitarControles(editando: true);
        }

        private void bSalvar_Click_1(object sender, EventArgs e)
        {
            if (validaObjeto())
            {
                if (AtualizarObjeto())
                {
                   
                }
            }
        }

        private void bCancelar_Click_1(object sender, EventArgs e)
        {
            Inicializar();
        }

        private void bExcluir_Click_1(object sender, EventArgs e)
        {
            if (AtualizarObjeto())
            {
                
            }
        }

        private void bBuscar_Click_1(object sender, EventArgs e)
        {
            string nome = txtDescricao.Text;
          //  dgvCadastro.DataSource = UsuarioRepository.GetAll().ToList();
        }

        private void bAlterar_Click_1(object sender, EventArgs e)
        {
            HabilitarControles();
        }

        private void dgvCadastro_DoubleClick_1(object sender, EventArgs e)
        {
            Usuario = dgvCadastro.CurrentRow?.DataBoundItem as Usuario;
            if (Usuario != null)
            {
                DialogResult = DialogResult.OK;
                // Close();
            }
        }
    }
}
