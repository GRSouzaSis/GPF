using GPF.Helper;
using GPF.Model;
using GPF.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GPF.View
{
    public partial class fCadProjeto : Form
    {
        public Projeto Projeto { get; set; }

        public Endereco Endereco { get; set; }

        private int proid;
        private int endid;
        private bool editar = false;

        UfRepository repUF = new UfRepository();
        CidadeRepository repCid = new CidadeRepository();
        ProjetoRepository repPro = new ProjetoRepository();
        public fCadProjeto()
        {
            InitializeComponent();
            Inicializa();
        }

        private void Inicializa()
        {
            //pCrud.Visible = false; 
            editar = false;
            dtpDataInicio.Value = DateTime.Now;
            Endereco = new Endereco();
            Projeto = new Projeto();            
            carregarUf();
            CbbUf.SelectedItem = null;
            CbbCidade.SelectedItem = null;
            AtualizarInterface();           
            
            AplicarEventos(txtEntrada);
            AplicarEventos(txtValorPorLote);
        }

        #region Mascára dinheiro 

        private void RetornarMascara(object sender, EventArgs e)
        {
            TextBox txt = (TextBox)sender;
            if (txt.Text == "")
            {

            }
            else
            {
                try
                {
                    txt.Text = double.Parse(txt.Text).ToString("C2");
                }
                catch (Exception ex)
                {
                    DialogHelper.Alerta(ex.Message);
                    txtEntrada.Focus();
                    // throw ex;
                }
            }
        }
        private void TirarMascara(object sender, EventArgs e)
        {
            try
            {
                TextBox txt = (TextBox)sender;
                txt.Text = txt.Text.Replace("R$", "").Trim();
            }
            catch (Exception ex)
            {
                DialogHelper.Alerta(ex.Message);
                txtEntrada.Focus();
                // throw ex;
            }


        }
        private void ApenasValorNumerico(object sender, KeyPressEventArgs e)
        {
            try
            {
                TextBox txt = (TextBox)sender;
                if (!char.IsDigit(e.KeyChar) && e.KeyChar != Convert.ToChar(Keys.Back))
                {
                    if (e.KeyChar == ',')
                    {
                        e.Handled = (txt.Text.Contains(','));
                    }
                    else
                        e.Handled = true;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        private void AplicarEventos(TextBox txt)
        {
            try
            {
                txt.Enter += TirarMascara;
                txt.Leave += RetornarMascara;
                txt.KeyPress += ApenasValorNumerico;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }


        #endregion
        private void LimpaTela()
        {
            txtNomeProjeto.Text = "";
            txtEntrada.Text = "";
            txtValorPorLote.Text = "";
            txtQtdLotes.Text = "";            
            dtpDataInicio.Text = "";
            cbAtivo.Checked = true;// ? 1 : 0;  
            cbFinalizado.Checked = false;// ? 1 : 0;            
            CbbCidade.SelectedItem = null;
            CbbUf.SelectedItem = null;
            txtLogradouro.Text = "";
            txtBairro.Text = "";
        }

        private void fCadProjeto_Load(object sender, EventArgs e)
        {
            CarregarDgv();
        }

        private void CarregarDgv()
        {
            try
            {
                ProjetoRepository acc = new ProjetoRepository();
                dgvCadastro.DataSource = acc.GetDataView();
                dgvCadastro.Columns[0].Visible = false;
                dgvCadastro.Columns[1].Visible = false;
                dgvCadastro.Columns[3].DefaultCellStyle.Format = "c";
                dgvCadastro.Columns[4].DefaultCellStyle.Format = "c";
                dgvCadastro.Columns[2].Width = 150;
                dgvCadastro.Columns[6].Width = 50;
                dgvCadastro.Columns[7].Visible = false;
                dgvCadastro.Columns[8].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void AtualizarInterface()
        {
            if (Projeto == null)
            {
                Projeto = new Projeto();
                Endereco = new Endereco();
            }
            else
            {
                txtNomeProjeto.Text = Projeto.pro_nome.ToString();
                txtEntrada.Text = Projeto.pro_vlrEntrada.ToString("C2");
                txtValorPorLote.Text = Projeto.pro_vlrPorLote.ToString("C2");
                txtQtdLotes.Text = Projeto.qtdlotes.ToString();               
                dtpDataInicio.Text = Projeto.dtinicio.ToString();               
                cbAtivo.CheckState = CheckState.Checked;// ? 1 : 0;  
                cbFinalizado.CheckState = CheckState.Checked;// ? 1 : 0;                 
                try
                {
                    CbbUf.SelectedValue = Endereco.cid_id;
                    CbbCidade.SelectedValue = Endereco.end_uf;
                }
                catch (Exception ex)
                {
                    CbbUf.SelectedItem = null;
                    CbbCidade.SelectedItem = null;
                    //MessageBox.Show(ex.Message);                    
                }
                txtLogradouro.Text = Endereco.end_logradouro.ToString();
                txtBairro.Text = Endereco.end_bairro.ToString();

            }
        }

        private bool AtualizarObjeto()
        {
            Ajudas ajudas = new Ajudas();
            int ativo = cbAtivo.Checked ? 1 : 0;
            int finalizado = cbFinalizado.Checked ? 1 : 0;


            if (Projeto == null)
            {
                Projeto = new Projeto();
            }

            Projeto.pro_nome = txtNomeProjeto.Text.ToUpper();
            Projeto.pro_vlrEntrada = Convert.ToDouble(txtEntrada.Text.Replace("R$", "").Trim());
            Projeto.pro_vlrPorLote = Convert.ToDouble(txtValorPorLote.Text.Replace("R$", "").Trim());           
            Projeto.dtinicio = dtpDataInicio.Value;      
            Projeto.pro_ativo = ativo;
            Projeto.pro_finalizado = finalizado;           
            Endereco.end_logradouro = txtLogradouro.Text.ToUpper();
            Endereco.end_bairro = txtBairro.Text.ToUpper();
            Endereco.cid_id = Convert.ToInt32(CbbCidade.SelectedValue.ToString());
            Endereco.end_uf = CbbUf.SelectedValue.ToString();

            return true;
        }

        private bool validaObjeto()
        {
            Ajudas ajudas = new Ajudas();

            string nome = txtNomeProjeto.Text.Trim();
            if (nome == string.Empty)
            {
                DialogHelper.Alerta("Informe um nome para o projeto.");
                txtNomeProjeto.Focus();
                return false;
            }

            if (repPro.ProcurarPorNome(txtNomeProjeto.Text))
            {
                DialogHelper.Informacao("Já existe projeto cadastrado com este nome.");//CPF já Cadastrado
                txtNomeProjeto.Focus();
                return false;
            }

            if (txtNomeProjeto.Text.Length > 149 || txtNomeProjeto.Text.Length < 2)
            {
                DialogHelper.Alerta("O nome do projeto deve ter entre 150 e ser menor que 2 caracteres");
                txtNomeProjeto.Focus();
                return false;
            } 

            if (CbbUf.SelectedItem == null)
            {
                DialogHelper.Alerta("Selecione o estado.");
                CbbUf.Focus();
                return false;
            }

            if (CbbCidade.SelectedItem == null)
            {
                DialogHelper.Alerta("Selecione a cidade.");
                CbbCidade.Focus();
                return false;
            }

            string endereco = txtLogradouro.Text.Trim();
            if (endereco == string.Empty)
            {

                DialogHelper.Alerta("Informe um endereço para o projeto.");
                txtLogradouro.Focus();
                return false;
            }

            string bairro = txtBairro.Text.Trim();
            if (bairro == string.Empty)
            {
                DialogHelper.Alerta("Informe um bairro para o projeto.");
                txtBairro.Focus();
                return false;
            }

            return true;
        }
        private void carregarUf()
        {
            try
            {
                CbbUf.DataSource = repUF.GetAll("");// GetAll("").ToList();
                CbbUf.DisplayMember = "uf_nome";
                CbbUf.ValueMember = "uf";
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        private void CbbUf_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                carregarCidade();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void carregarCidade()
        {
            try
            {
                string teste = Convert.ToString(CbbUf.SelectedValue);
                CbbCidade.DataSource = repCid.GetAll(teste);
                CbbCidade.DisplayMember = "cid_nome";
                CbbCidade.ValueMember = "cid_id";
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        private void bNovo_Click(object sender, EventArgs e)
        {
            Inicializa();
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
                        // repCli.cadastrar(Cliente);
                        if (repPro.Cadastrar(Projeto, Endereco))
                        {
                           CarregarDgv();//---> Atualiza Data grid view
                                              //  DialogHelper.Informacao("Cliente incluido com sucesso.");
                            Inicializa();
                            LimpaTela();
                        }
                        else
                        {
                            DialogHelper.Alerta("Reinicie a tela de cadastro.");
                        }
                        Inicializa();
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
                try
                {
                    if (validaObjeto())
                    {
                        AtualizarObjeto();
                        if (repPro.Alterar(Projeto, Endereco))
                        {
                            CarregarDgv();//---> Atualiza Data grid view
                                              // DialogHelper.Informacao("Cliente alterado com sucesso.");
                            Inicializa();
                            LimpaTela();
                        }
                        else
                        {
                            DialogHelper.Alerta("Reinicie a tela de cadastro.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void bCancelar_Click(object sender, EventArgs e)
        {
            Inicializa();
        }

        private void bExcluir_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("Confirma exclusão deste projeto?", "Confirma Exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {
                if (dgvCadastro.SelectedRows.Count > 0)
                {
                    proid = Convert.ToInt32(dgvCadastro.CurrentRow.Cells["pro_id"].Value);
                    endid = Convert.ToInt32(dgvCadastro.CurrentRow.Cells["end_id"].Value);
                    try
                    {
                        if (repPro.Excluir(proid, endid))
                        {
                           CarregarDgv();//---> Atualiza Data grid view
                                              //  DialogHelper.Informacao("Cliente excluido com sucesso.");//, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            Inicializa();
                        }
                        else
                        {
                            DialogHelper.Alerta("Não é possível excluir o projeto.");
                        }
                        Inicializa();
                        LimpaTela();

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Projeto não pode ser excluido." + ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
        }

        private void bAlterar_Click(object sender, EventArgs e)
        {
            if (dgvCadastro.SelectedRows.Count > 0)
            {
                editar = true;
                txtNomeProjeto.Text = dgvCadastro.CurrentRow.Cells["Projeto"].Value.ToString();
                txtValorPorLote.Text = dgvCadastro.CurrentRow.Cells["VlrLote"].Value.ToString();
                txtEntrada.Text = dgvCadastro.CurrentRow.Cells["Entrada"].Value.ToString();
                cbAtivo.Checked = Convert.ToBoolean(dgvCadastro.CurrentRow.Cells["Ativo"].Value);
                cbFinalizado.Checked = Convert.ToBoolean(dgvCadastro.CurrentRow.Cells["Finalizado"].Value);
                dtpDataInicio.Value = Convert.ToDateTime( dgvCadastro.CurrentRow.Cells["pro_dtinicio"].Value);
                try
                {
                    var uf = dgvCadastro.CurrentRow.Cells["UF"].Value.ToString();
                    CbbUf.DataSource = repUF.GetAll("");
                    CbbUf.DisplayMember = "uf_nome";
                    CbbUf.ValueMember = "uf";
                    CbbUf.SelectedValue = uf;

                    CbbCidade.DataSource = repCid.GetAll(uf);
                    CbbCidade.DisplayMember = "cid_nome";
                    CbbCidade.ValueMember = "cid_id";
                    CbbCidade.SelectedValue = Convert.ToInt32(dgvCadastro.CurrentRow.Cells["cid_id"].Value.ToString());
                }
                catch (Exception ex)
                {
                    CbbUf.SelectedItem = null;
                    CbbCidade.SelectedItem = null;
                    //MessageBox.Show(ex.Message);                    
                }
                txtLogradouro.Text = dgvCadastro.CurrentRow.Cells["end_logradouro"].Value.ToString();
                txtBairro.Text = dgvCadastro.CurrentRow.Cells["end_bairro"].Value.ToString();

                Projeto.pro_id = Convert.ToInt32(dgvCadastro.CurrentRow.Cells["pro_id"].Value);
                Endereco.end_id = Convert.ToInt32(dgvCadastro.CurrentRow.Cells["end_id"].Value);
            }
            else
            {
                DialogHelper.Informacao("Selecione um registro para alterar.");
            }
        }
    }
}
