using GPF.Model;
using GPF.Helper;
using GPF.Repository;
using System;
using System.Windows.Forms;
using System.Drawing;

namespace GPF.View
{
    public partial class fCadCliente : Form
    {
        public Cliente Cliente { get; set; }
        public Endereco Endereco { get; set; }
        public Cidade Cidade { get; set; }
        public Uf Uf { get; set; }

        private int cliid;
        private int endid;       
        private bool editar = false;

        UfRepository repUF = new UfRepository();
        CidadeRepository repCid = new CidadeRepository();
        ClienteRepository repCli = new ClienteRepository();       
        public fCadCliente()
        {
            InitializeComponent();
            Inicializa();
        }

        private void Mostracrud()
        {
            pCrud.Visible = true;
        }
        private void Escondecrud()
        {
            pCrud.Visible = false;
        }

        private void Inicializa()
        {
            Endereco = new Endereco();
            Cliente = new Cliente();            
            pCrud.Visible = false;
            pConjunge.Visible = false;
            dtpDataNasc.Value = DateTime.Now;
            carregarUf();
            CbbUf.SelectedItem = null;
            CbbCidade.SelectedItem = null;
            AtualizarInterface(Cliente);
            editar = false;
           
        }

        private void LimpaTela()
        {
            txtNome.Text = "";
            txtSobrenome.Text = "";
            txtCpf.Text = "";
            txtRG.Text = "";
            dtpDataNasc.Text = "";
            txtTelefone1.Text = "";
            txtTelefone2.Text = "";
            cbCasado.Checked = false;// ? 1 : 0;  
            txtNomeConjuge.Text = "";
            txtCpfConjuge.Text = "";
            txtConjugeRg.Text = "";
            CbbCidade.SelectedItem = null;
            CbbUf.SelectedItem = null;
            txtLogradouro.Text = "";
            txtBairro.Text = "";
        }

        private void fCadCliente_Load(object sender, EventArgs e)
        {
            MostrarClientes();
        }

        private void MostrarClientes()
        {
            try
            {
                ClienteRepository acc = new ClienteRepository();
                dgvCadastro.DataSource = acc.GetDataView();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void AtualizarInterface(Cliente cliente)
        {
            if (Cliente == null)
            {
                Cliente = new Cliente();
                Endereco = new Endereco();                
            }
            else
            {
                txtNome.Text = Cliente.cli_nome.ToString();
                txtSobrenome.Text = Cliente.cli_sobrenome.ToString();
                txtCpf.Text = Cliente.cli_cpf.ToString();
                txtRG.Text = Cliente.cli_rg.ToString();
                dtpDataNasc.Text = Cliente.cli_dtnasc.ToString();
                txtTelefone1.Text = Cliente.cli_telefone1.ToString();
                txtTelefone2.Text = Cliente.cli_telefone2.ToString();
                cbCasado.CheckState = CheckState.Checked;// ? 1 : 0;  
                txtNomeConjuge.Text = Cliente.cli_conjuge.ToString();
                txtCpfConjuge.Text = Cliente.cli_conjuge_cpf.ToString();
                txtConjugeRg.Text = Cliente.cli_conjuge_rg.ToString();
                try
                {
                    CbbUf.SelectedValue = Endereco.cid_id;
                    CbbCidade.SelectedValue = Endereco.end_uf;  
                }
                catch(Exception ex)
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
            int casado = cbCasado.Checked ? 1 : 0;


            if (Cliente == null)
            {
                Cliente = new Cliente();               
            }

            Cliente.cli_nome = txtNome.Text.ToUpper();
            Cliente.cli_sobrenome = txtSobrenome.Text.ToUpper();
            Cliente.cli_cpf = txtCpf.Text;
            Cliente.cli_rg = txtRG.Text;
            Cliente.cli_dtnasc = dtpDataNasc.Value; 
            Cliente.cli_telefone1 = txtTelefone1.Text;
            Cliente.cli_telefone2 = txtTelefone2.Text;
            Cliente.cli_casado = casado;
            Cliente.cli_conjuge = txtNomeConjuge.Text.ToUpper();
            Cliente.cli_conjuge_cpf = txtCpfConjuge.Text;
            Cliente.cli_conjuge_rg = txtConjugeRg.Text;
            Endereco.end_logradouro = txtLogradouro.Text.ToUpper();
            Endereco.end_bairro = txtBairro.Text.ToUpper();
            Endereco.cid_id = Convert.ToInt32(CbbCidade.SelectedValue.ToString());           
            Endereco.end_uf = CbbUf.SelectedValue.ToString();
           

            return true;
        }

        private bool validaObjeto()
        {
            Ajudas ajudas = new Ajudas();

            string nome = txtNome.Text.Trim();
            if (nome == string.Empty)
            {
                DialogHelper.Alerta("Informe um nome para o cliente.");
                txtNome.Focus();
                return false;
            }

            if (txtNome.Text.Length > 50 || txtNome.Text.Length < 2)
            {
                DialogHelper.Alerta("O nome não pode ter mais que cinquenta caracteres e ser menor que dois caracteres");
                txtNome.Focus();
                return false;
            }

            string sobrenome = txtSobrenome.Text.Trim();
            if (sobrenome == string.Empty)
            {
                DialogHelper.Alerta("Informe o sobrenome do cliente.");
                txtSobrenome.Focus();
                return false;
            }

            if (txtSobrenome.Text.Length > 50 || txtSobrenome.Text.Length < 2)
            {
                DialogHelper.Alerta("O sobrenome não pode ter mais que cinquenta caracteres e ser menor que dois caracteres");
                txtSobrenome.Focus();
                return false;
            }

            if (txtCpf.Text == String.Empty)
            {
                DialogHelper.Alerta("Informe um CPF para o cliente");
                txtCpf.Focus();
                return false;
            }

            if (!ajudas.ValidaCpf(txtCpf.Text))
            {
                DialogHelper.Alerta("Informe um CPF valido para o cliente");
                txtCpf.Focus();
                return false;
            }

            if (txtRG.Text == String.Empty)
            {
                DialogHelper.Alerta("Informe um RG para o cliente");
                txtRG.Focus();
                return false;
            }

            if (dtpDataNasc.Text == String.Empty)
            {
                DialogHelper.Alerta("Informe uma data de nascimento para o cliente");
                dtpDataNasc.Focus();
                return false;
            }
           
            else if (!ajudas.ValidaData(dtpDataNasc.Text))
            {
                DialogHelper.Alerta("Informe uma data de nascimento menor que o dia de hoje para o cliente");
                dtpDataNasc.Focus();
                return false;
            }

            if (txtTelefone1.Text == String.Empty)
            {
                DialogHelper.Alerta("Informe um número de telefone para o cliente");
                txtTelefone1.Focus();
                return false;
            }

            if (cbCasado.Checked == true)
            {
                string conjuge = txtNomeConjuge.Text.Trim();
                if (conjuge == string.Empty)
                {
                    DialogHelper.Alerta("Informe o nome do cônjuge do cliente.");
                    txtNomeConjuge.Focus();
                    return false;
                }

                if (txtCpfConjuge.Text == String.Empty)
                {
                    DialogHelper.Alerta("Informe um CPF para o cônjuge");
                    txtCpfConjuge.Focus();
                    return false;
                }

                if (!ajudas.ValidaCpf(txtCpfConjuge.Text))
                {
                    DialogHelper.Alerta("Informe um CPF valido para o cônjuge");
                    txtCpfConjuge.Focus();
                    return false;
                }
                if (repCli.ProcurarPorCPF(txtCpfConjuge.Text))
                {
                    DialogHelper.Alerta("CPF do cônjuge já cadastrado");
                    txtCpfConjuge.Focus();
                    return false;
                }
                if (txtConjugeRg.Text == String.Empty)
                {
                    DialogHelper.Alerta("Informe um RG para o cônjuge");
                    txtCpfConjuge.Focus();
                    return false;
                }
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

                DialogHelper.Alerta("Informe um endereço para o cliente.");
                txtLogradouro.Focus();
                return false;
            }

            string bairro = txtBairro.Text.Trim();
            if (bairro == string.Empty)
            {
                DialogHelper.Alerta("Informe um bairro para o cliente.");
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

        private void cbCasado_CheckedChanged(object sender, EventArgs e)
        {
            if (cbCasado.Checked == true)
            {
                pConjunge.Visible = true;

            }
            else
            {
                pConjunge.Visible = false;
                txtCpfConjuge.Text = "";
                txtNomeConjuge.Text = "";
                txtConjugeRg.Text = "";
            }
        }

        private void txtNome_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) && e.KeyChar != 08)
            {
                e.Handled = true;
            }
            if (e.KeyChar == 13)
            {
                txtSobrenome.Focus();
            }
        }

        private void txtSobrenome_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) && e.KeyChar != 08)
            {
                e.Handled = true;
            }
            if (e.KeyChar == 13)
            {
                txtCpf.Focus();
            }
        }

        private void txtNomeConjuge_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) && e.KeyChar != 08)
            {
                e.Handled = true;
            }
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
                        if (repCli.ProcurarPorCPF(txtCpf.Text))
                        {
                            DialogHelper.Informacao("Já existe cliente cadastrado com este CPF.");//CPF já Cadastrado
                            txtCpf.Focus();
                            return;
                        }
                        // repCli.cadastrar(Cliente);
                        if (repCli.Cadastrar(Cliente, Endereco))
                        {
                            MostrarClientes();//---> Atualiza Data grid view
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
                        if (repCli.Alterar(Cliente, Endereco))
                        {
                            MostrarClientes();//---> Atualiza Data grid view
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

        private void bAlterar_Click(object sender, EventArgs e)
        {
            if(pCrud.Visible == false)
            {
                pCrud.Visible = true;
            }
            if (dgvCadastro.SelectedRows.Count > 0)
            {
                editar = true;
                txtNome.Text = dgvCadastro.CurrentRow.Cells["cli_nome"].Value.ToString();
                txtSobrenome.Text = dgvCadastro.CurrentRow.Cells["cli_sobrenome"].Value.ToString();
                txtCpf.Text = dgvCadastro.CurrentRow.Cells["cli_cpf"].Value.ToString();
                txtRG.Text = dgvCadastro.CurrentRow.Cells["cli_rg"].Value.ToString();
                dtpDataNasc.Text = dgvCadastro.CurrentRow.Cells["cli_dtnasc"].Value.ToString();
                txtTelefone1.Text = dgvCadastro.CurrentRow.Cells["cli_telefone1"].Value.ToString();
                txtTelefone2.Text = dgvCadastro.CurrentRow.Cells["cli_telefone2"].Value.ToString();
                cbCasado.Checked = Convert.ToBoolean(dgvCadastro.CurrentRow.Cells["cli_casado"].Value);
                txtNomeConjuge.Text = dgvCadastro.CurrentRow.Cells["cli_conjuge"].Value.ToString();
                txtCpfConjuge.Text = dgvCadastro.CurrentRow.Cells["cli_conjuge_cpf"].Value.ToString();
                txtConjugeRg.Text = dgvCadastro.CurrentRow.Cells["cli_conjuge_rg"].Value.ToString();
                try
                {
                    var uf = dgvCadastro.CurrentRow.Cells["end_uf"].Value.ToString();
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

                Cliente.cli_id = Convert.ToInt32(dgvCadastro.CurrentRow.Cells["cli_id"].Value);
                Endereco.end_id = Convert.ToInt32(dgvCadastro.CurrentRow.Cells["end_id"].Value);                                          
            }
            else
            {
                DialogHelper.Informacao("Selecione um registro para alterar.");
            }
        }

        private void bNovo_Click(object sender, EventArgs e)
        {
            Inicializa();
            Mostracrud();
        }

        private void bCancelar_Click(object sender, EventArgs e)
        {
            Inicializa();
            Escondecrud();
        }

        private void bExcluir_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("Confirma exclusão deste cliente ?", "Confirma Exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {           
                if (dgvCadastro.SelectedRows.Count > 0)
                { 
                    cliid = Convert.ToInt32(dgvCadastro.CurrentRow.Cells["cli_id"].Value);
                    endid = Convert.ToInt32(dgvCadastro.CurrentRow.Cells["end_id"].Value);
                    try
                    {
                       if( repCli.Excluir(cliid, endid))
                       {
                            MostrarClientes();//---> Atualiza Data grid view
                          //  DialogHelper.Informacao("Cliente excluido com sucesso.");//, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            Inicializa();
                            Escondecrud();
                       }
                        else
                        {
                            DialogHelper.Alerta("Não é possível excluir esse cliente.");
                        }
                        Inicializa();
                        LimpaTela();

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Cliente não pode ser excluido." + ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
        }

        private void bBuscar_Click(object sender, EventArgs e)
        {
            string nome = "";
            nome = txtDescricao.Text;
            try
            {
                dgvCadastro.DataSource = repCli.GetDataView(nome);
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
            if(txtDescricao.Text == "Nome ou Sobrenome ou CPF ex: 123.456.789-25")
            {
                txtDescricao.Text = "";
                txtDescricao.ForeColor = Color.Black;
            }
        }

        private void txtDescricao_Leave(object sender, EventArgs e)
        {
            if (txtDescricao.Text == "")
            {
                txtDescricao.Text = "Nome ou Sobrenome ou CPF ex: 123.456.789-25";
                txtDescricao.ForeColor = Color.DarkGray;
            }
        }

        private void txtRG_KeyPress(object sender, KeyPressEventArgs e)
        {
           // var tecla =(Convert.ToByte( e.KeyChar));
           // MessageBox.Show(tecla.ToString());

            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08 && e.KeyChar != 46 && e.KeyChar != 45 && e.KeyChar != 88 && e.KeyChar != 120)
            {
                e.Handled = true;
            }
        }

        private void txtConjugeRg_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08 && e.KeyChar != 46 && e.KeyChar != 45 && e.KeyChar != 88 && e.KeyChar != 120)
            {
                e.Handled = true;
            }
        }

        private void dgvCadastro_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (pCrud.Visible == false)
            {
                pCrud.Visible = true;
            }
            editar = true;
            txtNome.Text = dgvCadastro.CurrentRow.Cells["cli_nome"].Value.ToString();
            txtSobrenome.Text = dgvCadastro.CurrentRow.Cells["cli_sobrenome"].Value.ToString();
            txtCpf.Text = dgvCadastro.CurrentRow.Cells["cli_cpf"].Value.ToString();
            txtRG.Text = dgvCadastro.CurrentRow.Cells["cli_rg"].Value.ToString();
            dtpDataNasc.Text = dgvCadastro.CurrentRow.Cells["cli_dtnasc"].Value.ToString();
            txtTelefone1.Text = dgvCadastro.CurrentRow.Cells["cli_telefone1"].Value.ToString();
            txtTelefone2.Text = dgvCadastro.CurrentRow.Cells["cli_telefone2"].Value.ToString();
            cbCasado.Checked = Convert.ToBoolean(dgvCadastro.CurrentRow.Cells["cli_casado"].Value);
            txtNomeConjuge.Text = dgvCadastro.CurrentRow.Cells["cli_conjuge"].Value.ToString();
            txtCpfConjuge.Text = dgvCadastro.CurrentRow.Cells["cli_conjuge_cpf"].Value.ToString();
            txtConjugeRg.Text = dgvCadastro.CurrentRow.Cells["cli_conjuge_rg"].Value.ToString();
            try
            {
                var uf = dgvCadastro.CurrentRow.Cells["end_uf"].Value.ToString();
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

            Cliente.cli_id = Convert.ToInt32(dgvCadastro.CurrentRow.Cells["cli_id"].Value);
            Endereco.end_id = Convert.ToInt32(dgvCadastro.CurrentRow.Cells["end_id"].Value);
        }
    }
}
