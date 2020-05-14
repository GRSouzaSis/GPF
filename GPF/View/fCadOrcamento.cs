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
    public partial class fCadOrcamento : Form
    {
        public Orcamento Orcamento { get; set; }
        public Lote Lote { get; set; }
        public Projeto Projeto { get; set; }

        public Cliente Cliente { get; set; }

        private bool editar = false;
        private int orc_id;

        LoteRepository repLote = new LoteRepository();
        ClienteRepository repCli = new ClienteRepository();
        ProjetoRepository repPro = new ProjetoRepository();
        OrcamentoRepository repOrc = new OrcamentoRepository();
        public fCadOrcamento()
        {
            InitializeComponent();
            AplicarEventos(txtValorTotal);
            PreencherDataVencimento();
            Inicializar();
        }

        private void Inicializar()
        {
            Lote = new Lote();
            Projeto = new Projeto();
            Cliente = new Cliente();
            Orcamento = new Orcamento();
            carregarProjeto();
            cbbProjeto.SelectedItem = null;
            cbbCliente.SelectedItem = null;
            cbbLote.SelectedItem = null;
            cbbVencimento.SelectedItem = null;
            txtDataOrcamento.Focus();
            AtualizarInterface();
            // HabilitarControles();
        }


        private void LimpaTela()
        {
            txtDataOrcamento.Text = "";
            txtMulta.Text = "";
            txtValorParcela.Text = "";
            txtValorTotal.Text = "";
            txtDataInicio.Text = "";
            numParcelas.Value = 1;
            cbbProjeto.SelectedItem = null;
            cbbCliente.SelectedItem = null;
            cbbLote.SelectedItem = null;
            cbbVencimento.SelectedItem = null;
            dgvLote.Rows.Clear();
            cbAprovado.Checked = false;
        }

        private void carregarProjeto()
        {
            try
            {
                cbbProjeto.DataSource = repPro.GetAll("");// GetAll("").ToList();
                cbbProjeto.Text = "[Selecione]";
                cbbProjeto.DisplayMember = "pro_nome";
                cbbProjeto.ValueMember = "pro_id";
                cbbLote.SelectedItem = null;
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
                int pro_id = Convert.ToInt32(cbbProjeto.SelectedValue);
                cbbCliente.DataSource = repCli.GetClienteProjeto(pro_id);// GetAll("").ToList();
                cbbCliente.Text = "[Selecione]";
                cbbCliente.DisplayMember = "cli";
                cbbCliente.ValueMember = "cli_id";
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private void carregarLote()
        {
            try
            {
                int cli_id = Convert.ToInt32(cbbCliente.SelectedValue);
                int pro_id = Convert.ToInt32(cbbProjeto.SelectedValue);
                cbbLote.DataSource = repLote.GetLotes(cli_id, pro_id);// GetAll("").ToList();
                cbbCliente.Text = "[Selecione]";
                cbbLote.DisplayMember = "lote";
                cbbLote.ValueMember = "lot_id";
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void AtualizarInterface()
        {
            if (Orcamento == null)
            {
                Lote = new Lote();
                Projeto = new Projeto();
                Cliente = new Cliente();
                Orcamento = new Orcamento();
            }
            else
            {
                txtDataOrcamento.Text = Orcamento.orc_dtorcamento.ToString();
                txtDataInicio.Text = Orcamento.orc_dtiniciopag.ToString();
               // txtMulta.Text = Orcamento.orc_porc_multa.ToString();
                txtValorTotal.Text = Orcamento.orc_valor.ToString();
                cbAprovado.CheckState = CheckState.Checked;
                try
                {
                    cbbProjeto.SelectedValue = Projeto.pro_id;
                    cbbCliente.SelectedValue = Cliente.cli_id;
                    cbbVencimento.SelectedValue = Lote.lot_id;
                    cbbVencimento.SelectedValue = Orcamento.orc_dtvencimento;//erro
                }
                catch (Exception ex)
                {
                    cbbProjeto.SelectedItem = null;
                    cbbCliente.SelectedItem = null;
                    cbbLote.SelectedItem = null;
                    cbbVencimento.SelectedItem = null;
                }
            }
        }

        private bool AtualizarObjeto()
        {
            Ajudas ajudas = new Ajudas();
            int aprovado = cbAprovado.Checked ? 1 : 0;
            double mult;
            string multa = txtMulta.Text;
            if (multa == string.Empty)
            {
                mult = 0;
            }
            else
            {
                try
                {
                    mult = Convert.ToDouble(txtMulta.Text);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }

            if (Orcamento == null)
            {
                Orcamento = new Orcamento();
            }
            try
            {
               // Orcamento.orc_aprovado = aprovado;
                Orcamento.orc_dtiniciopag = ajudas.AtualizaData(txtDataInicio.Text);
                Orcamento.orc_dtorcamento = ajudas.AtualizaData(txtDataOrcamento.Text);
                Orcamento.orc_dtvencimento = ajudas.AtualizaDataDia(cbbVencimento.SelectedItem.ToString());//erro
                //Orcamento.orc_porc_multa = mult;
              //  Orcamento.orc_qtdparcela = Convert.ToInt32(numParcelas.Value);
                Orcamento.orc_valor = Convert.ToDouble(txtValorTotal);
                Projeto.pro_id = Convert.ToInt32(cbbProjeto.SelectedValue.ToString());
                Cliente.cli_id = Convert.ToInt32(cbbCliente.SelectedValue.ToString());
                Lote.lot_id = Convert.ToInt32(cbbLote.SelectedValue.ToString());
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return true;
        }

        private bool validaObjeto()
        {
            Ajudas ajudas = new Ajudas();

            if (txtValorTotal.Text == String.Empty)
            {
                DialogHelper.Alerta("Informe um valor para o orçamento.");
                txtValorTotal.Focus();
                return false;
            }

            if (dgvLote.Rows == null)
            {
                DialogHelper.Alerta("Adcione um lote.");
                cbbLote.Focus();
                return false;
            }

            if (!txtDataOrcamento.MaskCompleted)
            {
                DialogHelper.Alerta("Informe corretamente a data para o orçamento Ex: 27/04/2020");
                txtDataOrcamento.Focus();
                return false;
            }
            else if (!ajudas.ValidaData(txtDataOrcamento.Text))
            {
                DialogHelper.Alerta("Informe uma data de orçamento igual ou menor que o dia de hoje.");
                txtDataOrcamento.Focus();
                return false;
            }

            if (!txtDataInicio.MaskCompleted)
            {
                DialogHelper.Alerta("Informe corretamente a data de início Ex: 27/04/2020.");
                txtDataInicio.Focus();
                return false;
            }
            else if (!ajudas.ValidaData(txtDataInicio.Text))
            {
                DialogHelper.Alerta("Informe uma data de início igual ou menor que o dia de hoje para o orçamento.");
                txtDataInicio.Focus();
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

            if (cbbLote.SelectedItem == null)
            {
                DialogHelper.Alerta("Selecione um lote.");
                cbbLote.Focus();
                return false;
            }

            if (cbbVencimento.SelectedItem == null)
            {
                DialogHelper.Alerta("Selecione um dia pra o vencimento.");
                cbbVencimento.Focus();
                return false;
            }

            return true;
        }


        public void PreencherDataVencimento()
        {

            for (int i = 1; i <= 31; i++)
            {
                cbbVencimento.Items.Add(i);
            }
        }

        private void cbbCliente_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {
                dgvLote.Rows.Clear();
                carregarLote();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void cbbProjeto_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                cbbLote.SelectedItem = null;
                carregarCliente();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void CalcularParcelas()
        {
            double valor, valorParcela;
            int qtdeParcelas;
            try
            {
                valor = Convert.ToDouble(txtValorTotal.Text.Replace("R$", "").Trim());
                qtdeParcelas = Convert.ToInt32(numParcelas.Value);
                valorParcela = valor / qtdeParcelas;
                txtValorParcela.Text = double.Parse(Convert.ToString(valorParcela)).ToString("C2");
            }
            catch (Exception ex)
            {
                throw ex;
            }

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
                    txtValorTotal.Focus();
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
                txtValorTotal.Focus();
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
        #region CalculaParcelas

        private void numParcelas_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                CalcularParcelas();
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        private void txtValorTotal_Enter(object sender, EventArgs e)
        {
            if (txtValorTotal.Text == "0")
            {
                txtValorTotal.Text = "";
            }
        }

        private void txtValorTotal_TextChanged(object sender, EventArgs e)
        {
            txtValorParcela.Text = txtValorTotal.Text;
        }

        private void numParcelas_Enter(object sender, EventArgs e)
        {
            try
            {
                CalcularParcelas();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion
        #region DataGrid Lote
        private void AddDgv()
        {
            try
            {
                string a;
                dgvLote.Columns[0].Name = "lot_id";
                dgvLote.Columns[1].Name = "Lote";
                dgvLote.Columns[2].Name = "Quadra";
                dgvLote.Columns[0].Visible = false;
                if (cbbLote.SelectedIndex > -1)
                {
                    a = cbbLote.Text;
                    var array = a.Split('|');
                    dgvLote.Rows.Add(cbbLote.SelectedValue, array[0], array[1]);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        private void bAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvLote.Rows.Count > 0)
                {
                    for (int i = 0; i < dgvLote.Rows.Count; i++)
                    {

                        var cli_id = Convert.ToInt32(dgvLote.Rows[i].Cells[0].Value.ToString());
                        if (cli_id != Convert.ToInt32(cbbLote.SelectedValue))
                        {
                            //dgvLote.Rows[i].Cells[0].Style.ForeColor = Color.Red;
                            AddDgv();
                        }
                        else
                        {
                            DialogHelper.Informacao("Lote já cadastrado");
                        }

                    }
                }
                else
                {
                    AddDgv();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }


        }

        private void bRemover_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvLote.Rows.Count > 0)
                {
                    dgvLote.Rows.RemoveAt(dgvLote.CurrentRow.Index);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }


        }
        #endregion

        private void bSalvar_Click(object sender, EventArgs e)
        {
            // CalcularParcelas();
        }


    }
}
