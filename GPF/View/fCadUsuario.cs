using GPF.Helper;
using GPF.Model;
using GPF.Repository;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace GPF.View
{
    public partial class fCadUsuario : Form
    {
        public Usuario Usuario { get; set; }
        public Funcionario Funcionario { get; set; }   

        UsuarioRepository repUso = new UsuarioRepository();

        FuncionarioRepository repFun = new FuncionarioRepository();

        private int uso_id;
        private bool editar = false;
        private int flag;
        private string flagNome;
        public fCadUsuario()
        {
            InitializeComponent();
            Inicializar();
        }

        private void Inicializar()
        {
            Usuario = new Usuario();
            Funcionario = new Funcionario();
            carregarFuncionario();
            CbbFuncionario.SelectedItem = null;
            CbbFuncionario.Focus();
            AtualizarInterface();
            
            // HabilitarControles();
        }

        private void LimpaTela()
        {
            txtNomeUsuario.Text = "";
            txtLogin.Text = "";
            txtSenha.Text = "";
            cbAtivo.Checked = true;// ? 1 : 0;            
            CbbFuncionario.SelectedItem = null;
        }
        private void fCadUsuario_Load(object sender, EventArgs e)
        {
            MostrarUsuarios();
        }

        private void MostrarUsuarios()
        {
            try
            {
                DataGridViewCheckBoxColumn column = new DataGridViewCheckBoxColumn();
                
                    
                UsuarioRepository acc = new UsuarioRepository();
                dgvCadastro.DataSource = acc.GetDataView();
                dgvCadastro.Columns[0].Visible = false;
                dgvCadastro.Columns[1].Visible = false;
                dgvCadastro.Columns[2].Visible = false;
               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        private void carregarFuncionario()
        {
            try
            {
                CbbFuncionario.DataSource = repFun.GetAll("");// GetAll("").ToList();
                CbbFuncionario.DisplayMember = "fun_nome";
                CbbFuncionario.ValueMember = "fun_id";
            }
            catch (Exception ex)
            {
                throw ex;
            }
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
                Funcionario = new Funcionario();
            }
            else
            {
                txtNomeUsuario.Text = Usuario.uso_nome.ToString();
                txtLogin.Text = Usuario.uso_login.ToString();
                txtSenha.Text = Usuario.uso_senha.ToString();
                cbAtivo.CheckState = CheckState.Checked;
                try
                {
                    CbbFuncionario.SelectedValue = Funcionario.fun_id;
                }
                catch (Exception ex)
                {
                    CbbFuncionario.SelectedItem = null;
                }
            }
        }

        private bool AtualizarObjeto()
        {
            if (Usuario == null)
            {
                Usuario = new Usuario();
            }

            Usuario.uso_login = txtLogin.Text;
            Usuario.uso_senha = txtSenha.Text;
            Usuario.uso_nome = txtNomeUsuario.Text;
            Usuario.uso_ativo = cbAtivo.Checked ? 1 : 0;
            Funcionario.fun_id = Convert.ToInt32(CbbFuncionario.SelectedValue.ToString());
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

            if (CbbFuncionario.SelectedItem == null)
            {
                DialogHelper.Alerta("Selecione um funcionário.");
                CbbFuncionario.Focus();
                return false;
            }

            return true;
        }

        private void bSalvar_Click(object sender, EventArgs e)
        {

            if (editar == false)//Salvar
            {
                try
                {
                    if (validaObjeto())
                    {
                        AtualizarObjeto();
                        if (repUso.ProcurarLogin(txtLogin.Text))
                        {
                            DialogHelper.Informacao("Já existe usuário com esse Login.");//Login já Cadastrado
                            txtLogin.Focus();
                            return;
                        }
                        // repCli.cadastrar(Cliente);
                        repUso.Cadastrar(Usuario);
                        MostrarUsuarios();//---> Atualiza Data grid view
                       // DialogHelper.Informacao("Usuário incluido com sucesso.");
                        Inicializar();
                        LimpaTela();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            if (editar == true)//alterar
            {
                if (flag != (cbAtivo.Checked ? 1 : 0) && txtNomeUsuario.Text == flagNome)
                {

                    try
                    {
                        if (validaObjeto())
                        {
                            AtualizarObjeto();
                            repUso.alterar(Usuario);
                            MostrarUsuarios();//---> Atualiza Data grid view
                            DialogHelper.Informacao("Usuário alterado com sucesso.");//, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            Inicializar();
                            LimpaTela();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                else
                {
                    try
                    {
                        if (validaObjeto())
                        {
                            AtualizarObjeto();

                            if (repUso.ProcurarLogin(txtLogin.Text))
                            {
                                DialogHelper.Informacao("Já existe um usuário cadastrado com este login. Tente outro nome para o perfil.");//, "Perfil já Cadastrado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                txtLogin.Focus();
                                return;
                            }
                            repUso.alterar(Usuario);
                            MostrarUsuarios();//---> Atualiza Data grid view
                          //  DialogHelper.Alerta("Usuário alterado com sucesso.");//, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            Inicializar();
                            LimpaTela();

                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }

            }

        }

        private void bAlterar_Click(object sender, EventArgs e)
        {
            if (dgvCadastro.SelectedRows.Count > 0)
            {
                editar = true;
                txtNomeUsuario.Text = dgvCadastro.CurrentRow.Cells["Usuário"].Value.ToString();
                txtLogin.Text = dgvCadastro.CurrentRow.Cells["Login"].Value.ToString();
                txtSenha.Text = dgvCadastro.CurrentRow.Cells["uso_senha"].Value.ToString();
                Usuario.uso_id = Convert.ToInt32(dgvCadastro.CurrentRow.Cells["uso_id"].Value);
                cbAtivo.Checked = Convert.ToBoolean(dgvCadastro.CurrentRow.Cells["Ativo"].Value);
                flag = Convert.ToInt32(dgvCadastro.CurrentRow.Cells["Ativo"].Value);
                flagNome = dgvCadastro.CurrentRow.Cells["Usuário"].Value.ToString();

                try
                {                    

                    CbbFuncionario.DataSource = repFun.GetAll("");
                    CbbFuncionario.DisplayMember = "fun_nome";
                    CbbFuncionario.ValueMember = "fun_id";
                    CbbFuncionario.SelectedValue = Convert.ToInt32(dgvCadastro.CurrentRow.Cells["fun_id"].Value.ToString());
                }
                catch (Exception ex)
                {
                    CbbFuncionario.SelectedItem = null;
                    //MessageBox.Show(ex.Message);                    
                }
            }
            else
            {
                DialogHelper.Informacao("Selecione um registro para alterar.");
            }
        }
        private void bExcluir_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("Confirma exclusão deste usuário ?", "Confirma Exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {
                if (dgvCadastro.SelectedRows.Count > 0)
                {
                    uso_id = Convert.ToInt32(dgvCadastro.CurrentRow.Cells["usoid"].Value);
                    try
                    {
                        repUso.excluir(uso_id);
                        MostrarUsuarios();//---> Atualiza Data grid view
                        DialogHelper.Informacao("Usuário excluido com sucesso.");//, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        Inicializar();

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Usuário não pode ser excluido, desative o usuário." + ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
        }

        private void bNovo_Click(object sender, EventArgs e)
        {
            Inicializar();
           // HabilitarControles(editando: true);
        }


        private void bCancelar_Click(object sender, EventArgs e)
        {
            Inicializar();
        }

        private void bBuscar_Click(object sender, EventArgs e)
        {
            string nome = "";
            nome = txtDescricao.Text;
            try
            {
                dgvCadastro.DataSource = repUso.GetDataView(nome);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtDescricao_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                bBuscar.PerformClick();
            }
        }

        private void txtDescricao_Enter(object sender, EventArgs e)
        {
            if(txtDescricao.Text == "Nome de usuário ou login")
            {
                txtDescricao.Text = "";
                txtDescricao.ForeColor = Color.Black;
            }
        }

        private void txtDescricao_Leave(object sender, EventArgs e)
        {
            if (txtDescricao.Text == "")
            {
                txtDescricao.Text = "Nome de usuário ou login";
                txtDescricao.ForeColor = Color.DarkGray;
            }
        }

        private void dgvCadastro_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            editar = true;
            txtNomeUsuario.Text = dgvCadastro.CurrentRow.Cells["Usuário"].Value.ToString();
            txtLogin.Text = dgvCadastro.CurrentRow.Cells["Login"].Value.ToString();
            txtSenha.Text = dgvCadastro.CurrentRow.Cells["uso_senha"].Value.ToString();
            Usuario.uso_id = Convert.ToInt32(dgvCadastro.CurrentRow.Cells["uso_id"].Value);
            cbAtivo.Checked = Convert.ToBoolean(dgvCadastro.CurrentRow.Cells["Ativo"].Value);
            flag = Convert.ToInt32(dgvCadastro.CurrentRow.Cells["Ativo"].Value);
            flagNome = dgvCadastro.CurrentRow.Cells["Usuário"].Value.ToString();

            try
            {

                CbbFuncionario.DataSource = repFun.GetAll("");
                CbbFuncionario.DisplayMember = "fun_nome";
                CbbFuncionario.ValueMember = "fun_id";
                CbbFuncionario.SelectedValue = Convert.ToInt32(dgvCadastro.CurrentRow.Cells["fun_id"].Value.ToString());
            }
            catch (Exception ex)
            {
                CbbFuncionario.SelectedItem = null;
                //MessageBox.Show(ex.Message);                    
            }
        }
    }
}
