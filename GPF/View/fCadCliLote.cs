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
    public partial class fCadCliLote : Form
    {
        public Lote Lote { get; set; }
        public Projeto Projeto { get; set; }

        public Cliente Cliente { get; set; }

        private bool editar = false;
        private int lot_id;

        LoteRepository repLote = new LoteRepository();
        ClienteRepository repCli = new ClienteRepository();
        ProjetoRepository repPro = new ProjetoRepository();
        public fCadCliLote()
        {
            InitializeComponent();
            Inicializar();
        }

        private void Inicializar()
        {
            Lote = new Lote();
            Projeto = new Projeto();
            Cliente = new Cliente();
            carregarProjeto();
            carregarCliente();
            cbbProjeto.SelectedItem = null;
            cbbCliente.SelectedItem = null;
            cbbProjeto.Focus();
            AtualizarInterface();

            // HabilitarControles();
        }

        private void fCadCliLote_Load(object sender, EventArgs e)
        {
            CarregaDgv();
        }

        private void CarregaDgv()
        {
            try
            {
                LoteRepository acc = new LoteRepository();
                dgvCadastro.DataSource = acc.GetDataView();
                dgvCadastro.Columns[5].Visible = false;
                dgvCadastro.Columns[6].Visible = false;
                dgvCadastro.Columns[7].Visible = false;

                    //dgvCadastro.CurrentRow.Cells["Número"].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        private void LimpaTela()
        {
            txtNroLote.Text = "";
            txtNroQuadra.Text = "";
            cbbProjeto.SelectedItem = null;
            cbbCliente.SelectedItem = null;
        }
        private void carregarProjeto()
        {
            try
            {
                cbbProjeto.DataSource = repPro.GetAll("");// GetAll("").ToList();
                cbbProjeto.DisplayMember = "pro_nome";
                cbbProjeto.ValueMember = "pro_id";
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void carregarCliente()
        {
            try
            {
                cbbCliente.DataSource = repCli.GetAll("");// GetAll("").ToList();
                cbbCliente.DisplayMember = "cli";
                cbbCliente.ValueMember = "cli_id";
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void AtualizarInterface()
        {
            if (Lote == null)
            {
                Lote = new Lote();
                Projeto = new Projeto();
                Cliente = new Cliente();
            }
            else
            {
                txtNroLote.Text = Lote.lot_numero.ToString();
                txtNroQuadra.Text = Lote.lot_quadra.ToString();
                txtMatricula.Text = Lote.lot_matricula.ToString();
                try
                {
                    cbbProjeto.SelectedValue = Projeto.pro_id;
                    cbbCliente.SelectedValue = Cliente.cli_id;
                }
                catch (Exception ex)
                {
                    cbbProjeto.SelectedItem = null;
                    cbbCliente.SelectedItem = null;
                }
            }
        }

        private bool AtualizarObjeto()
        {
            if (Lote == null)
            {
                Lote = new Lote();
            }

            Lote.lot_matricula = txtMatricula.Text;
            Lote.lot_numero = txtNroLote.Text;
            Lote.lot_quadra = txtNroQuadra.Text;
            Projeto.pro_id = Convert.ToInt32(cbbProjeto.SelectedValue.ToString());
            Cliente.cli_id = Convert.ToInt32(cbbCliente.SelectedValue.ToString());
            return true;
        }

        private bool validaObjeto()
        {
            if (txtNroLote.Text.Length > 10)
            {
                DialogHelper.Alerta("O número do lote não pode ter mais que dez caracteres");
                txtNroLote.Focus();
                return false;
            }
      
            if (txtNroLote.Text == String.Empty)
            {
                DialogHelper.Alerta("Informe o número do lote");
                txtNroLote.Focus();
                return false;
            }

            if (txtNroQuadra.Text.Length > 10)
            {
                DialogHelper.Alerta("O número da quadra não pode ter mais que dez caracteres");
                txtNroQuadra.Focus();
                return false;
            }

            if (txtNroQuadra.Text == String.Empty)
            {
                DialogHelper.Alerta("Informe o número da quadra");
                txtNroQuadra.Focus();
                return false;
            }           

            if (cbbProjeto.SelectedItem == null)
            {
                DialogHelper.Alerta("Selecione um projeto.");
                cbbProjeto.Focus();
                return false;
            }

            if (cbbCliente.SelectedItem == null)
            {
                DialogHelper.Alerta("Selecione um cliente.");
                cbbCliente.Focus();
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
                        if (repLote.VerificaSeTemLote(Convert.ToInt32(cbbProjeto.SelectedValue)))
                        {
                            if (repLote.ProcurarLote(txtNroLote.Text, txtNroQuadra.Text,Convert.ToInt32(cbbProjeto.SelectedValue)))
                            {
                                DialogHelper.Informacao("Já existe lote para está quadra com esse número verifique o número e quadra do lote.");//Login já Cadastrado
                                txtNroLote.Focus();
                                return;
                            }
                            // repCli.cadastrar(Cliente);
                            repLote.Cadastrar(Lote,Projeto,Cliente);
                            CarregaDgv();//---> Atualiza Data grid view
                                         // DialogHelper.Informacao("Usuário incluido com sucesso.");
                            Inicializar();
                            LimpaTela();
                        }
                        else
                        {
                            DialogHelper.Informacao("Quantidade de lotes desse Projeto já esta completa.");
                        }
                       
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
                        repLote.alterar(Lote, Projeto, Cliente);
                        CarregaDgv();//---> Atualiza Data grid view
                       // DialogHelper.Informacao("Usuário alterado com sucesso.");//, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

        private void bAlterar_Click(object sender, EventArgs e)
        {
            if (dgvCadastro.SelectedRows.Count > 0)
            {
                editar = true;
                txtNroLote.Text = dgvCadastro.CurrentRow.Cells["Lote"].Value.ToString();
                txtNroQuadra.Text = dgvCadastro.CurrentRow.Cells["Quadra"].Value.ToString();
                txtMatricula.Text = dgvCadastro.CurrentRow.Cells["Matrícula"].Value.ToString();
                Projeto.pro_id = Convert.ToInt32(dgvCadastro.CurrentRow.Cells["pro_id"].Value);
                Cliente.cli_id = Convert.ToInt32(dgvCadastro.CurrentRow.Cells["cli_id"].Value);
                Lote.lot_id = Convert.ToInt32(dgvCadastro.CurrentRow.Cells["lot_id"].Value);               

                try
                {

                    cbbProjeto.DataSource = repPro.GetAll("");
                    cbbProjeto.DisplayMember = "pro_nome";
                    cbbProjeto.ValueMember = "pro_id";
                    cbbProjeto.SelectedValue = Convert.ToInt32(dgvCadastro.CurrentRow.Cells["pro_id"].Value.ToString());

                    cbbCliente.DataSource = repCli.GetAll("");// GetAll("").ToList();
                    cbbCliente.DisplayMember = "cli";
                    cbbCliente.ValueMember = "cli_id";
                    cbbCliente.SelectedValue = Convert.ToInt32(dgvCadastro.CurrentRow.Cells["cli_id"].Value.ToString());
                }
                catch (Exception ex)
                {
                    cbbProjeto.SelectedItem = null;
                    //MessageBox.Show(ex.Message);                    
                }
            }
            else
            {
                DialogHelper.Informacao("Selecione um registro para alterar.");
            }
        }

        private void bNovo_Click(object sender, EventArgs e)
        {
            Inicializar();
        }

        private void bExcluir_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("Confirma exclusão deste lote ?", "Confirma Exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {
                if (dgvCadastro.SelectedRows.Count > 0)
                {
                    lot_id = Convert.ToInt32(dgvCadastro.CurrentRow.Cells["lot_id"].Value);
                    try
                    {
                        repLote.excluir(lot_id);
                        CarregaDgv();//---> Atualiza Data grid view
                        DialogHelper.Informacao("Lote excluido com sucesso.");//, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        Inicializar();

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lote não pode ser excluido." + ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
        }

        private void bCancelar_Click(object sender, EventArgs e)
        {
            Inicializar();
        }

        private void dgvCadastro_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            editar = true;
            txtNroLote.Text = dgvCadastro.CurrentRow.Cells["Lote"].Value.ToString();
            txtNroQuadra.Text = dgvCadastro.CurrentRow.Cells["Quadra"].Value.ToString();
            txtMatricula.Text = dgvCadastro.CurrentRow.Cells["Matrícula"].Value.ToString();
            Projeto.pro_id = Convert.ToInt32(dgvCadastro.CurrentRow.Cells["pro_id"].Value);
            Cliente.cli_id = Convert.ToInt32(dgvCadastro.CurrentRow.Cells["cli_id"].Value);
            Lote.lot_id = Convert.ToInt32(dgvCadastro.CurrentRow.Cells["lot_id"].Value);

            try
            {

                cbbProjeto.DataSource = repPro.GetAll("");
                cbbProjeto.DisplayMember = "pro_nome";
                cbbProjeto.ValueMember = "pro_id";
                cbbProjeto.SelectedValue = Convert.ToInt32(dgvCadastro.CurrentRow.Cells["pro_id"].Value.ToString());

                cbbCliente.DataSource = repCli.GetAll("");// GetAll("").ToList();
                cbbCliente.DisplayMember = "cli";
                cbbCliente.ValueMember = "cli_id";
                cbbCliente.SelectedValue = Convert.ToInt32(dgvCadastro.CurrentRow.Cells["cli_id"].Value.ToString());
            }
            catch (Exception ex)
            {
                cbbProjeto.SelectedItem = null;
                //MessageBox.Show(ex.Message);                    
            }
        }

        private void txtDescricao_Enter(object sender, EventArgs e)
        {
            if (txtDescricao.Text == "Projeto ou Cliente")
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
                dgvCadastro.DataSource = repLote.GetDataView(nome);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtDescricao_Leave(object sender, EventArgs e)
        {
            if (txtDescricao.Text == "")
            {
                txtDescricao.Text = "Projeto ou Cliente";
                txtDescricao.ForeColor = Color.Black;
            }
        }

        private void txtDescricao_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                bBuscar.PerformClick();
            }
        }
    }
}
