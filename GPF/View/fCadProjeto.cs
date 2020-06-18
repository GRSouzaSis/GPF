using GPF.Helper;
using GPF.Model;
using GPF.Repository;
using System;
using System.Drawing;
using System.Linq;
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
        LoteRepository loteRepository = new LoteRepository();
        ProjetoRepository projetoRepository = new ProjetoRepository();
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
            dtpDataInicio.Focus();
            // AplicarEventos(txtEntrada);
            //  AplicarEventos(txtValorPorLote);
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
                dgvCadastro.DataSource = projetoRepository.GetDataView();
                dgvCadastro.Columns[0].Visible = false;
                dgvCadastro.Columns[1].Visible = false;
                dgvCadastro.Columns[2].Visible = false;
                dgvCadastro.Columns[3].Width = 150;
                dgvCadastro.Columns[4].DefaultCellStyle.Format = "c2";
                dgvCadastro.Columns[5].DefaultCellStyle.Format = "c2";
                dgvCadastro.Columns[6].Width = 80;
                dgvCadastro.Columns[7].Width = 200;
                dgvCadastro.Columns[8].Width = 40;
                dgvCadastro.Columns[9].Width = 200;
                dgvCadastro.Columns[10].Width = 150;
                dgvCadastro.Columns[11].Width = 40;
                dgvCadastro.Columns[12].Width = 80;
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
                cbFinalizado.CheckState = CheckState.Unchecked;// ? 1 : 0;                 
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

            if (editar == false)
            {
                if (projetoRepository.ProcurarPorNome(txtNomeProjeto.Text))
                {
                    DialogHelper.Informacao("Já existe projeto cadastrado com este nome.");
                    txtNomeProjeto.Focus();
                    return false;
                }
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
                        if (projetoRepository.Cadastrar(Projeto, Endereco))
                        {
                            CarregarDgv();//---> Atualiza Data grid view
                                          //  DialogHelper.Informacao("Cliente incluido com sucesso.");
                            Inicializa();
                            LimpaTela();
                        }
                        else
                        {
                            DialogHelper.Erro("Cadastro não concluído.");
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
                        if (projetoRepository.Alterar(Projeto, Endereco))
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
            if(dgvCadastro.SelectedRows.Count > 0)
            {
                proid = Convert.ToInt32(dgvCadastro.CurrentRow.Cells["pro_id"].Value);
                if (!loteRepository.VerificaSeTemLote(proid))//verifica se tem lotes vinculados
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
                                if (projetoRepository.Excluir(proid, endid))
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
                else
                {
                    DialogHelper.Alerta("Há lotes vinculados a esse projeto. Não é possível excluir.");
                }
            }
        }

        private void bAlterar_Click(object sender, EventArgs e)
        {
            if (dgvCadastro.SelectedRows.Count >= 0)
            {
                editar = true;
                try
                {
                    var ativo = dgvCadastro.CurrentRow.Cells["Ativo"].Value.ToString();
                    if (ativo.ToString() == "SIM")
                    {
                        cbAtivo.Checked = true;
                    }
                    else
                    {
                        cbAtivo.Checked = false;
                    }

                    var finalizado = dgvCadastro.CurrentRow.Cells["Finalizado"].Value.ToString();
                    if (finalizado.ToString() == "SIM")
                    {
                        cbFinalizado.Checked = true;
                    }
                    else
                    {
                        cbFinalizado.Checked = false;
                    }
                }
                catch (Exception ex)
                {
                    dgvCadastro.Focus();
                    //MessageBox.Show(ex.Message);                    
                }


                txtNomeProjeto.Text = dgvCadastro.CurrentRow.Cells["Projeto"].Value.ToString();
                txtValorPorLote.Text = dgvCadastro.CurrentRow.Cells["VlrLote"].Value.ToString();
                txtEntrada.Text = dgvCadastro.CurrentRow.Cells["VlrEntrada"].Value.ToString();
                // cbAtivo.Checked = Convert.ToBoolean(dgvCadastro.CurrentRow.Cells["Ativo"].Value);// converter para 1 ou 0
                // cbFinalizado.Checked = Convert.ToBoolean(dgvCadastro.CurrentRow.Cells["Finalizado"].Value);
                dtpDataInicio.Text = dgvCadastro.CurrentRow.Cells["Início"].Value.ToString();
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
                txtLogradouro.Text = dgvCadastro.CurrentRow.Cells["Logradouro"].Value.ToString();
                txtBairro.Text = dgvCadastro.CurrentRow.Cells["Bairro"].Value.ToString();

                Projeto.pro_id = Convert.ToInt32(dgvCadastro.CurrentRow.Cells["pro_id"].Value);
                Endereco.end_id = Convert.ToInt32(dgvCadastro.CurrentRow.Cells["end_id"].Value);
            }
            else
            {
                DialogHelper.Informacao("Selecione um registro para alterar.");
            }
        }

        private void txtValorPorLote_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08 && e.KeyChar != 44)
            {
                e.Handled = true;
            }
        }

        private void txtEntrada_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08 && e.KeyChar != 44)
            {
                e.Handled = true;
            }
        }

        private void txtDescricao_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                bBuscar.PerformClick();
            }
        }

        private void txtDescricao_Leave(object sender, EventArgs e)
        {
            if (txtDescricao.Text == "")
            {
                txtDescricao.Text = "Nome Projeto";
                txtDescricao.ForeColor = Color.DarkGray;
            }
        }

        private void txtDescricao_Enter(object sender, EventArgs e)
        {
            if (txtDescricao.Text == "Nome Projeto")
            {
                txtDescricao.Text = "";
                txtDescricao.ForeColor = Color.Black;
            }
        }

        private void bBuscar_Click(object sender, EventArgs e)
        {
            string nome = "";
            nome = txtDescricao.Text;
            try
            {
                dgvCadastro.DataSource = projetoRepository.GetDataView(nome);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
