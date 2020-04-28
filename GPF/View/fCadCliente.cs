using GPF.Model;
using GPF.Helper;
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
    public partial class fCadCliente : Form
    {
        public Cliente Cliente { get; set; }
        public Endereco Endereco { get; set; }
        public Cidade Cidade { get; set; }
        public Uf Uf { get; set; }

        private int cliid;
        private int endid;
        private int cidid;
        private string uf;
        private int flag;
        private string flagNome;
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
            pCrud.Visible = false;
            pConjunge.Visible = false;
            carregarUf();
            CbbUf.SelectedItem = null;
            CbbCidade.SelectedItem = null;
            AtualizarInterface(Cliente);
            Endereco = new Endereco();         

        }

        private void LimpaTela()
        {
            txtNome.Text = "";
            txtSobrenome.Text = "";
            txtCpf.Text = "";
            txtDataNasc.Text = "";
            txtTelefone1.Text = "";
            txtTelefone2.Text = "";
            cbCasado.Checked = false;// ? 1 : 0;  
            txtNomeConjuge.Text = "";
            txtCpfConjuge.Text = "";        
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
                txtDataNasc.Text = Cliente.cli_dtnasc.ToString();
                txtTelefone1.Text = Cliente.cli_telefone1.ToString();
                txtTelefone2.Text = Cliente.cli_telefone2.ToString();
                cbCasado.CheckState = CheckState.Checked;// ? 1 : 0;  
                txtNomeConjuge.Text = Cliente.cli_conjuge.ToString();
                txtCpfConjuge.Text = Cliente.cli_conjuge_cpf.ToString();
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
            Cliente.cli_dtnasc = ajudas.AtualizaData(txtDataNasc.Text); 
            Cliente.cli_telefone1 = txtTelefone1.Text;
            Cliente.cli_telefone2 = txtTelefone2.Text;
            Cliente.cli_casado = casado;
            Cliente.cli_conjuge = txtNomeConjuge.Text.ToUpper();
            Cliente.cli_conjuge_cpf = txtCpfConjuge.Text;
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

            if (txtDataNasc.Text == String.Empty)
            {
                DialogHelper.Alerta("Informe uma data de nascimento para o cliente");
                txtDataNasc.Focus();
                return false;
            }

            if (!txtDataNasc.MaskCompleted)
            {
                DialogHelper.Alerta("Informe corretamente a data de nascimento Ex: 27/04/2020");
                txtDataNasc.Focus();
                return false;
            }
            else if (!ajudas.ValidaData(txtDataNasc.Text))
            {
                DialogHelper.Alerta("Informe uma data de nascimento menor que o dia de hoje para o cliente");
                txtDataNasc.Focus();
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
                        if (repCli.cadastrar(Cliente, Endereco))
                        {
                            MostrarClientes();//---> Atualiza Data grid view
                            DialogHelper.Informacao("Cliente incluido com sucesso.");
                            Inicializa();
                            LimpaTela();
                        }
                        else
                        {
                            DialogHelper.Alerta("Tente novamente.");
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
                        if (repCli.alterar(Cliente, Endereco))
                        {
                            MostrarClientes();//---> Atualiza Data grid view
                            DialogHelper.Informacao("Cliente alterado com sucesso.");
                            Inicializa();
                            LimpaTela();
                        }
                        else
                        {
                            DialogHelper.Alerta("Tente novamente.");
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
                txtDataNasc.Text = dgvCadastro.CurrentRow.Cells["cli_dtnasc"].Value.ToString();
                txtTelefone1.Text = dgvCadastro.CurrentRow.Cells["cli_telefone1"].Value.ToString();
                txtTelefone2.Text = dgvCadastro.CurrentRow.Cells["cli_telefone2"].Value.ToString();
                cbCasado.Checked = Convert.ToBoolean(dgvCadastro.CurrentRow.Cells["cli_casado"].Value);
                txtNomeConjuge.Text = dgvCadastro.CurrentRow.Cells["cli_conjuge"].Value.ToString();
                txtCpfConjuge.Text = dgvCadastro.CurrentRow.Cells["cli_conjuge_cpf"].Value.ToString();
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
                //  flag = Convert.ToInt32(dgvCadastro.CurrentRow.Cells["cli_casado"].Value);
                // flagNome = dgvCadastro.CurrentRow.Cells["cli_cpf"].Value.ToString();                             
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

     
    }
}
