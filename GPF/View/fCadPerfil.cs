using GPF.Helper;
using GPF.Model;
using GPF.Repository;
using System;
using System.Windows.Forms;

namespace GPF.View
{
    public partial class fCadPerfil : Form
    { 
        public Perfil Perfil { get; set; }
        PerfilRepository acc = new PerfilRepository();
        private int per_id;
        private int flag;
        private string flagNome;
        private bool editar = false;

        public fCadPerfil()
        {
            InitializeComponent();
            Inicializar();
        }

        private void Inicializar()
        {
           
           // HabilitarControles();
            AtualizarInterface();
        }
        private void LimpaTela()
        {
            txtNome.Text = "";           
            cbAtivo.Checked = true;// ? 1 : 0;              
        }


        private void fCadPerfil_Load(object sender, EventArgs e)
        {
            MostrarPerfis();           
        }

        private void MostrarPerfis()
        {
            try
            {
                PerfilRepository acc = new PerfilRepository();
               dgvCadastro.DataSource = acc.GetDataView();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        public void HabilitarControles(bool editando = false, bool visualizando = false)
        {
          //  txtDescricao.Enabled = editando;
            txtNome.Enabled = editando;
            cbAtivo.Enabled = editando;

            bNovo.Enabled = !editando || visualizando;
            bSalvar.Enabled = editando;
            bCancelar.Enabled = editando || visualizando;
            bExcluir.Enabled = visualizando;
            bBuscar.Enabled = !editando || visualizando;
            bAlterar.Enabled = !editando || visualizando;

            if (editando)
            {
                txtNome.Focus();
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
            if (Perfil == null)
            {
                Perfil = new Perfil();
            }
            else
            {
                txtNome.Text = Perfil.per_nome.ToString();
                cbAtivo.CheckState = CheckState.Checked;// ? 1 : 0;                
            }
        }

        private bool AtualizarObjeto()
        {

            string nome = txtNome.Text.Trim();
           
            
            int ativo = cbAtivo.Checked ? 1 : 0;


            if (Perfil == null)
            {
                Perfil = new Perfil();
            }

            Perfil.per_id = per_id;
            Perfil.per_nome = nome.ToUpper();
            Perfil.per_ativo = ativo;
           
            return true;
        }

        private bool validaObjeto()
        {
            if (txtNome.Text.Length > 20)
            {
                DialogHelper.Alerta("O nome de perfil não pode ter mais que 20 caracteres");
                txtNome.Focus();
                return false;
            }
            if (txtNome.Text == String.Empty)
            {
                DialogHelper.Alerta("Informe um nome para o perfil");
                txtNome.Focus();
                return false;
            }
 
            return true;
        }

        private void bNovo_Click(object sender, EventArgs e)
        {
            Inicializar();
            //HabilitarControles(editando: true);
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
                        if (acc.ProcurarPorNome(txtNome.Text))
                        {
                            DialogHelper.Informacao("Já existe perfil cadastrado com este nome. Tente outro nome para o perfil.");//, "Perfil já Cadastrado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            txtNome.Focus();
                            return;
                        }
                        acc.cadastraPerfil(Perfil);
                        MostrarPerfis();//---> Atualiza Data grid view
                        DialogHelper.Alerta("Perfil incluido com sucesso.");//, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        Inicializar();
                        LimpaTela();

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            if(editar == true)//alterar
            {
                if (flag != (cbAtivo.Checked ? 1 : 0) && txtNome.Text == flagNome)
                {
                
                    try
                    {
                        if (validaObjeto())
                        {
                            AtualizarObjeto();  
                            acc.alterarPerfil(Perfil);
                            MostrarPerfis();//---> Atualiza Data grid view
                            DialogHelper.Informacao("Perfil alterado com sucesso.");//, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

                            if (acc.ProcurarPorNome(txtNome.Text))
                            {
                                DialogHelper.Informacao("Já existe perfil cadastrado com este nome. Tente outro nome para o perfil.");//, "Perfil já Cadastrado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                txtNome.Focus();
                                return;
                            }
                            acc.alterarPerfil(Perfil);
                            MostrarPerfis();//---> Atualiza Data grid view
                            DialogHelper.Alerta("Perfil alterado com sucesso.");//, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                txtNome.Text = dgvCadastro.CurrentRow.Cells["per_nome"].Value.ToString();
                per_id =Convert.ToInt32( dgvCadastro.CurrentRow.Cells["codigo"].Value);               
                cbAtivo.Checked = Convert.ToBoolean(dgvCadastro.CurrentRow.Cells["per_ativo"].Value);
                flag = Convert.ToInt32(dgvCadastro.CurrentRow.Cells["per_ativo"].Value);
                flagNome = dgvCadastro.CurrentRow.Cells["per_nome"].Value.ToString();
            }
            else
            {
                DialogHelper.Informacao("Selecione um registro para alterar.");
            }
        }

        private void bExcluir_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("Confirma exclusão deste perfil ?", "Confirma Exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {
                if (dgvCadastro.SelectedRows.Count > 0)
                {
                    per_id = Convert.ToInt32(dgvCadastro.CurrentRow.Cells["per_id"].Value);
                    try
                    {                       
                        acc.excluirPerfil(per_id);
                        MostrarPerfis();//---> Atualiza Data grid view
                        DialogHelper.Informacao("Perfil excluido com sucesso.");//, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        Inicializar();
                        
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Perfil não pode ser excluido, desative seu perfil." + ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
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
                dgvCadastro.DataSource = acc.GetDataView(nome);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
           }
        }

        private void txtNome_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) && e.KeyChar != 08)
            {
                e.Handled = true;
            }
        }

        private void txtDescricao_KeyPress(object sender, KeyPressEventArgs e)
        {
            string nome = "";
            nome = txtDescricao.Text;
            try
            {
                dgvCadastro.DataSource = acc.GetDataView(nome);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
    
}
