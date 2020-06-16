using GPF.Helper;
using GPF.Model;
using GPF.Repository;
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Linq;
using GPF.Cache;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace GPF.View
{
    public partial class fCadCliLote : Form
    {
        public Lote Lote { get; set; }
        public Projeto Projeto { get; set; }
        public Cliente Cliente { get; set; }
        public Orcamento Orcamento { get; set; }
        public Receber Receber { get; set; }

        private bool editar = false;
        private int lot_id;
        private int cli_id;
        private int pro_id;

        LoteRepository repLote = new LoteRepository();
        ClienteRepository repCli = new ClienteRepository();
        ProjetoRepository repPro = new ProjetoRepository();
        ReceberRepository receberRepository = new ReceberRepository();
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
            Orcamento = new Orcamento();
            Receber = new Receber();
            carregarProjeto();
            carregarProjetoBusca();
            carregarCliente();
            AplicarEventos(txtValorTotal);
            AplicarEventos(txtEntrada);
            AplicarEventos(txtValorParcela);
            AplicarEventos(txtValorParcEntrada);
            cbbProjeto.SelectedItem = null;
            cbbCliente.SelectedItem = null;
            cbbBuscaProjeto.SelectedItem = null;
            dtpEntrada.Value = DateTime.Now;
            dtpDataVencimento.Value = DateTime.Now;
            cbbProjeto.Focus();
            AtualizarInterface();
            txtAddLote.Text = "0";
            txtDescEntrada.Text = "0";
            txtDescTotal.Text = "0";
            txtValorTotal.Enabled = false;
            txtEntrada.Enabled = false;
            pDadosLote.Visible = false;
            bGerarLotes.Visible = false;
            // HabilitarControles();
        }

        private void fCadCliLote_Load(object sender, EventArgs e)
        {
            CarregaDgv();
        }

        private void CarregaDgv()
        {
            int qtdlote, qtdGerado, i = 0;
            try
            {
                LoteRepository acc = new LoteRepository();
                dgvCadastro.DataSource = acc.GetDataView();
                dgvCadastro.Columns[0].Width = 150;
                dgvCadastro.Columns[1].Width = 200;
                dgvCadastro.Columns[2].Visible = false;
                dgvCadastro.Columns[3].Visible = false;
                if (dgvCadastro.RowCount > 0)
                {
                    foreach (DataGridViewRow dgvRow in dgvCadastro.Rows)
                    {
                        cli_id = Convert.ToInt32(dgvRow.Cells["cli_id"].Value);
                        qtdGerado = receberRepository.ClienteGerados(cli_id, 1);
                        qtdlote = repLote.ContaLote(cli_id);
                        if (qtdGerado == qtdlote)
                        {
                            dgvCadastro.Update();
                            dgvCadastro.Select();
                            dgvCadastro.Rows[i].Cells["Cliente"].Style.BackColor = Color.LightGreen;
                        }
                        else if (qtdGerado < qtdlote)
                        {
                            dgvCadastro.Update();
                            dgvCadastro.Select();
                            dgvCadastro.Rows[i].Cells["Cliente"].Style.BackColor = Color.Yellow;
                        }
                        else
                        {
                            dgvCadastro.Update();
                            dgvCadastro.Select();
                            dgvCadastro.Rows[i].Cells["Cliente"].Style.BackColor = Color.Red;
                        }
                        i++;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
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
        #region CalcularCampos
        private double CalcularParcelas()
        {
            double valor, valorParcela, entrada, diferenca, parcelaEntrada, qtd;
            int qtdeParcelas;
            try
            {
                valor = Convert.ToDouble(txtValorTotal.Text.Replace("R$", "").Trim());
                parcelaEntrada = Convert.ToDouble(txtValorParcEntrada.Text.Replace("R$", "").Trim());
                entrada = Convert.ToDouble(txtEntrada.Text.Replace("R$", "").Trim());
                qtd = Convert.ToInt32(numParcEntrada.Value);
                diferenca = entrada - (parcelaEntrada * qtd);
                valor -= parcelaEntrada * qtd;
                qtdeParcelas = Convert.ToInt32(numParcelas.Value);
                //valorParcela = valor / qtdeParcelas - diferenca;
                valorParcela = valor - diferenca;
                txtValorParcela.Text = double.Parse(Convert.ToString(valorParcela)).ToString("C2");

                return valorParcela;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void DividirValor()
        {
            double valor, qtdeParcelas, result;
            valor = CalcularParcelas();
            qtdeParcelas = Convert.ToInt32(numParcelas.Value);
            result = valor / qtdeParcelas;
            txtValorParcela.Text = double.Parse(Convert.ToString(result)).ToString("C2");
        }

        private double CalculaParcEntrada()
        {
            double entrada, valorParcEntrada, porcEntrada, total;
            int qtdeParcEntrada;
            try
            {
                entrada = Convert.ToDouble(txtEntrada.Text.Replace("R$", "").Trim());
                qtdeParcEntrada = Convert.ToInt32(numParcEntrada.Value);
                if (txtDescEntrada.Text != "0")
                {
                    porcEntrada = Convert.ToDouble(txtDescEntrada.Text) / 100;
                    entrada = (entrada - (entrada * porcEntrada));
                    valorParcEntrada = entrada / qtdeParcEntrada;
                    total = valorParcEntrada * qtdeParcEntrada;
                    txtValorParcEntrada.Text = double.Parse(Convert.ToString(valorParcEntrada)).ToString("C2");
                }
                else
                {
                    valorParcEntrada = entrada / qtdeParcEntrada;
                    txtValorParcEntrada.Text = double.Parse(Convert.ToString(valorParcEntrada)).ToString("C2");
                    total = valorParcEntrada * qtdeParcEntrada;
                }
                return total;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        private void txtEntrada_Leave(object sender, EventArgs e)
        {
            if (txtEntrada.Text != "0" && txtEntrada.Text != "")
            {
                try
                {
                    CalculaParcEntrada();
                    CalcularParcelas();
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }

        }

        private void txtDescEntrada_Leave(object sender, EventArgs e)
        {
            if (txtDescEntrada.Text != "")
            {
                try
                {
                    CalculaParcEntrada();
                    CalcularParcelas();
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
            else
            {
                txtDescEntrada.Text = "0";
            }
        }

        private void txtValorTotal_Leave(object sender, EventArgs e)
        {
            try
            {
                CalculaParcEntrada();
                CalcularParcelas();
            }

            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void txtQtdLote_Enter(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtLotid.Text))
            {
                txtLotid.SelectionStart = 0;
                txtLotid.SelectionLength = txtLotid.Text.Length;
            }
        }

        private void txtQtdLote_Leave(object sender, EventArgs e)
        {
            if (txtLotid.Text == "")
            {
                txtLotid.Text = "0";
            }
        }

        private void txtDescEntrada_Enter(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtDescEntrada.Text))
            {
                txtDescEntrada.SelectionStart = 0;
                txtDescEntrada.SelectionLength = txtDescEntrada.Text.Length;
            }
        }
        private void txtDescTotal_Enter(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtDescTotal.Text))
            {
                txtDescTotal.SelectionStart = 0;
                txtDescTotal.SelectionLength = txtDescTotal.Text.Length;
            }
        }

        private void numParcelas_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                DividirValor();
                //CalcularParcelas();
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

        private void numParcelas_Enter(object sender, EventArgs e)
        {
            try
            {
                if (!String.IsNullOrEmpty(numParcelas.Text))
                {
                    numParcelas.Select(0, numParcelas.Text.Length);
                }
                //  CalcularParcelas();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void numParcEntrada_Enter(object sender, EventArgs e)
        {
            try
            {
                if (!String.IsNullOrEmpty(numParcelas.Text))
                {
                    numParcEntrada.Select(0, numParcelas.Text.Length);
                }
                //CalculaParcEntrada();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void numParcEntrada_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                CalculaParcEntrada();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void txtEntrada_Enter(object sender, EventArgs e)
        {
            if (txtEntrada.Text == "0")
            {
                txtEntrada.Text = "";
                txtDescEntrada.Text = "0";
            }
            if (!String.IsNullOrEmpty(txtEntrada.Text))
            {
                txtEntrada.SelectionStart = 0;
                txtEntrada.SelectionLength = txtEntrada.Text.Length;
            }
        }
        #endregion

        private void LimpaTela()
        {
            txtNroLote.Text = "";
            txtNroQuadra.Text = "";
            txtCodLote.Text = "";
            txtMatricula.Text = "";
            txtLotid.Text = "";
            numParcelas.Value = 1;
            numParcEntrada.Value = 1;
            txtDescTotal.Text = "0";
            txtDescEntrada.Text = "0";
            dtpDataVencimento.Value = DateTime.Now;
            dtpEntrada.Value = DateTime.Now;
            // cbbProjeto.SelectedItem = null;
            // cbbCliente.SelectedItem = null;
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
        private void carregarProjetoBusca()
        {
            try
            {
                cbbBuscaProjeto.DataSource = repPro.GetAll("");// GetAll("").ToList();               
                cbbBuscaProjeto.DisplayMember = "pro_nome";
                cbbBuscaProjeto.ValueMember = "pro_id";
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

                txtEntrada.Text = Orcamento.orc_valorEntrada.ToString("C2");
                txtValorTotal.Text = Orcamento.orc_valor.ToString("C2");
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

        private bool AtualizarObjetoLote()
        {
            Ajudas ajudas = new Ajudas();
            if (Lote == null)
            {
                Lote = new Lote();
            }

            pro_id = Convert.ToInt32(cbbProjeto.SelectedValue);
            cli_id = Convert.ToInt32(cbbCliente.SelectedValue);

            //busca na tabela projeto, valor projeto e valor entrada;
            if (repPro.carregarValoresProjeto(pro_id))
            {
                Projeto.pro_vlrPorLote = Convert.ToDouble(ProjetoCache.pro_vlrPorLote);
                Projeto.pro_vlrEntrada = Convert.ToDouble(ProjetoCache.pro_vlrEntrada);

                // carregar nos campos 
                txtValorTotal.Text = Projeto.pro_vlrPorLote.ToString("C2");
                txtEntrada.Text = Projeto.pro_vlrEntrada.ToString("C2");
            }

            Lote.lot_matricula = txtMatricula.Text;
            Lote.lot_numero = txtNroLote.Text;
            Lote.lot_quadra = txtNroQuadra.Text;
            Orcamento.orc_valor = Convert.ToDouble(txtValorTotal.Text.Replace("R$", "").Trim());
            Orcamento.orc_valorEntrada = Convert.ToDouble(txtEntrada.Text.Replace("R$", "").Trim());
            Orcamento.orc_descEntrada = Convert.ToDouble(txtDescEntrada.Text);
            Orcamento.orc_descRestante = Convert.ToDouble(txtDescTotal.Text);
            Orcamento.orc_qtdParcelaEntrada = Convert.ToInt32(numParcEntrada.Value);
            Orcamento.orc_qtdParcelaRestante = Convert.ToInt32(numParcelas.Value);
            Orcamento.orc_dtorcamento = DateTime.Now;

            Projeto.pro_id = pro_id;
            Cliente.cli_id = cli_id;
            return true;
        }

        private bool validaObjeto()
        {
            /* if (txtNroLote.Text.Length > 10)
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
            */
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

        private void dgvCadastro_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvCadastro.SelectedRows.Count > 0)
            {
                cli_id = Convert.ToInt32(dgvCadastro.CurrentRow.Cells["cli_id"].Value);
                pro_id = Convert.ToInt32(dgvCadastro.CurrentRow.Cells["pro_id"].Value);

                try
                {
                    cbbProjeto.SelectedValue = pro_id;
                    cbbCliente.SelectedValue = cli_id;
                }
                catch (Exception ex)
                {
                    cbbProjeto.SelectedItem = null;
                    cbbCliente.SelectedItem = null;
                    //MessageBox.Show(ex.Message);                    
                }

                CarregarDgvLotes(pro_id, cli_id);
                CarregarGridComFiltros(pro_id, cli_id);
                dgvCadastro.CurrentRow.Selected = true;
                if (repPro.carregarValoresProjeto(pro_id))
                {
                    Projeto.pro_vlrPorLote = Convert.ToDouble(ProjetoCache.pro_vlrPorLote);
                    Projeto.pro_vlrEntrada = Convert.ToDouble(ProjetoCache.pro_vlrEntrada);

                    txtValorTotal.Text = Projeto.pro_vlrPorLote.ToString("C2");
                    txtEntrada.Text = Projeto.pro_vlrEntrada.ToString("C2");
                }

            }

        }
        private void CarregarDgvLotes(int pro_id, int cli_id)
        {
            int i = 0;
            LoteRepository loteRepository = new LoteRepository();
            dgvLoteCliente.DataSource = loteRepository.GetDataViewLote(cli_id, pro_id);
            dgvLoteCliente.Columns[0].Width = 60;
            dgvLoteCliente.Columns[1].Width = 60;
            dgvLoteCliente.Columns[5].Visible = false;
            if (dgvLoteCliente.RowCount > 0)
            {
                foreach (DataGridViewRow dgvRow in dgvLoteCliente.Rows)
                {
                    lot_id = Convert.ToInt32(dgvRow.Cells["CodLote"].Value);
                    if ((receberRepository.Gerados(lot_id, 1) && receberRepository.Gerados(lot_id, 0)) == false)
                    {
                        if (receberRepository.Gerados(lot_id, 1))
                        {
                            dgvLoteCliente.Update();
                            dgvLoteCliente.Select();
                            dgvLoteCliente.Rows[i].Cells["CodLote"].Style.BackColor = Color.Yellow;
                        }
                        else if (receberRepository.Gerados(lot_id, 0))
                        {
                            dgvLoteCliente.Update();
                            dgvLoteCliente.Select();
                            dgvLoteCliente.Rows[i].Cells["CodLote"].Style.BackColor = Color.LightGreen;
                        }
                        else
                        {
                            dgvLoteCliente.Update();
                            dgvLoteCliente.Select();
                            dgvLoteCliente.Rows[i].Cells["CodLote"].Style.BackColor = Color.Red;
                        }

                    }
                    else
                    {
                        dgvLoteCliente.Update();
                        dgvLoteCliente.Select();
                        dgvLoteCliente.Rows[i].Cells["CodLote"].Style.BackColor = Color.White;
                    }

                    i++;
                }
            }
        }

        private void txtDescricao_Enter(object sender, EventArgs e)
        {
            if (txtDescricao.Text == "Nome Cliente")
            {
                txtDescricao.Text = "";
                txtDescricao.ForeColor = Color.Black;
            }
        }

        private void bBuscar_Click(object sender, EventArgs e)
        {
            CarregarGridComFiltros();
        }

        private void CarregarGridComFiltros()
        {
            string nome;

            int projeto, qtdlote, qtdGerado, i = 0;
            nome = txtDescricao.Text;
            if (nome == "Nome Cliente")
                nome = "";

            projeto = (Convert.ToInt32(cbbBuscaProjeto.SelectedValue));
            try
            {
                dgvCadastro.DataSource = repLote.GetDataView(nome, projeto);
                dgvCadastro.Columns[0].Width = 150;
                dgvCadastro.Columns[1].Width = 200;
                dgvCadastro.Columns[2].Visible = false;
                dgvCadastro.Columns[3].Visible = false;
                if (dgvCadastro.RowCount > 0)
                {
                    foreach (DataGridViewRow dgvRow in dgvCadastro.Rows)
                    {
                        cli_id = Convert.ToInt32(dgvRow.Cells["cli_id"].Value);
                        qtdGerado = receberRepository.ClienteGerados(cli_id, 1);
                        qtdlote = repLote.ContaLote(cli_id);
                        if (qtdGerado == qtdlote)
                        {
                            dgvCadastro.Update();
                            dgvCadastro.Select();
                            dgvCadastro.Rows[i].Cells["Cliente"].Style.BackColor = Color.LightGreen;
                        }
                        else if (qtdGerado < qtdlote)
                        {
                            dgvCadastro.Update();
                            dgvCadastro.Select();
                            dgvCadastro.Rows[i].Cells["Cliente"].Style.BackColor = Color.Yellow;
                        }
                        else
                        {
                            dgvCadastro.Update();
                            dgvCadastro.Select();
                            dgvCadastro.Rows[i].Cells["Cliente"].Style.BackColor = Color.Red;
                        }
                        i++;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void CarregarGridComFiltros(int pro_id, int cli_id)
        {
            try
            {
                dgvCadastro.DataSource = repLote.GetDataView(pro_id, cli_id);
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
                txtDescricao.Text = "Nome Cliente";
                txtDescricao.ForeColor = Color.DarkGray;
            }
        }

        private void txtDescricao_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                bBuscar.PerformClick();
            }
        }

        private void cbbBuscaProjeto_SelectedIndexChanged(object sender, EventArgs e)
        {
            bBuscar.PerformClick();
        }

        private void bTodos_Click(object sender, EventArgs e)
        {
            if (pDadosLote.Visible == true)
            {
                pDadosLote.Visible = false;
            }
            cbbBuscaProjeto.SelectedItem = null;
            if (dgvLoteCliente.Rows.Count > 0)
            {
                dgvLoteCliente.DataSource = null;
            }

            CarregaDgv();
            LimpaTela();
        }

        private void bGerarLote_Click(object sender, EventArgs e)
        {
            if (dgvCadastro.SelectedRows.Count > 0)
            {
                if (pDadosLote.Visible == false)
                {
                    pDadosLote.Visible = true;
                }
                cli_id = Convert.ToInt32(dgvCadastro.CurrentRow.Cells["cli_id"].Value);
                pro_id = Convert.ToInt32(dgvCadastro.CurrentRow.Cells["pro_id"].Value);

                // var qtd = repLote.ContaLote(pro_id, cli_id);
                // txtQtdLote.Text = Convert.ToString(qtd);
                //busca na tabela projeto, valor projeto e valor entrada;
                if (repPro.carregarValoresProjeto(pro_id))
                {
                    Projeto.pro_vlrPorLote = Convert.ToDouble(ProjetoCache.pro_vlrPorLote);
                    Projeto.pro_vlrEntrada = Convert.ToDouble(ProjetoCache.pro_vlrEntrada);

                    // carregar nos campos 
                    txtValorTotal.Text = Projeto.pro_vlrPorLote.ToString("C2");
                    txtEntrada.Text = Projeto.pro_vlrEntrada.ToString("C2");
                    numParcelas.Value = 1;
                    numParcEntrada.Value = 1;
                    dtpDataVencimento.Value = DateTime.Now;
                    dtpEntrada.Value = DateTime.Now;
                    txtDescEntrada.Text = "0";
                    txtDescTotal.Text = "0";
                }
                CalculaParcEntrada();
                CalcularParcelas();
                // MessageBox.Show(Convert.ToString( cli_id), Convert.ToString(pro_id));
            }
            else
            {
                DialogHelper.Alerta("Nenhum cliente selecionado");
            }
        }

        private void cbValores_CheckedChanged(object sender, EventArgs e)
        {
            if (cbValores.Checked == true)
            {
                txtValorTotal.Enabled = true;
                txtEntrada.Enabled = true;
            }
            else
            {
                txtValorTotal.Enabled = false;
                txtEntrada.Enabled = false;
            }
        }

        private void bRemover_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("Confirma remover o cliente do projeto?", "Confirma Exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {
                if (dgvCadastro.SelectedRows.Count > 0)
                {
                    //  lot_id = Convert.ToInt32(dgvCadastro.CurrentRow.Cells["lot_id"].Value);
                    cli_id = Convert.ToInt32(dgvCadastro.CurrentRow.Cells["cli_id"].Value);
                    pro_id = Convert.ToInt32(dgvCadastro.CurrentRow.Cells["pro_id"].Value);
                    try
                    {
                        repLote.ExcluirCliente(cli_id, pro_id);

                        DialogHelper.Informacao("Cliente removido com sucesso.");//, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        CarregaDgv();//---> Atualiza Data grid view
                        dgvLoteCliente.DataSource = null;
                        cbbBuscaProjeto.SelectedItem = pro_id;
                        //Inicializar();

                    }
                    catch (Exception ex)
                    {
                        // MessageBox.Show("Cliente não pode ser removido." + ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        DialogHelper.Alerta("Cliente não pode ser removido. Existem contas a receber para o cliente!");
                    }
                }
            }
        }

        private void bAdd_Click(object sender, EventArgs e)
        {
            if (editar == false)//Salvar
            {
                try
                {
                    if (validaObjeto())
                    {
                        //AtualizarObjeto();
                        AtualizarObjetoLote();
                        if (repLote.VerificaCliente(Convert.ToInt32(cbbProjeto.SelectedValue), Convert.ToInt32(cbbCliente.SelectedValue)))
                        {
                            // repLote.Cadastrar(Lote, Projeto, Cliente);
                            repLote.CadastrarValoresLote(Lote, Projeto, Cliente, Orcamento);
                            CarregarDgvLotes(pro_id, cli_id);
                            CarregaDgv();
                            cbbBuscaProjeto.SelectedValue = cbbProjeto.SelectedValue;//atualizar a grid com o Id do projeto                             

                        }
                        else
                        {
                            DialogHelper.Informacao("Cliente já vinculado a esse projeto.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void bGerarLotes_Click(object sender, EventArgs e)
        {
            // Receber Receber = new Receber();
            foreach (DataGridViewRow dgvRow in dgvLoteCliente.Rows)// percorrer lotes ----- preciso do id cliente e id do lote e id do projeto
            {

                Receber.lot_id = Convert.ToInt32(dgvRow.Cells["CodLote"].Value);
                Receber.cli_id = Convert.ToInt32(dgvRow.Cells["CodCli"].Value);
                Receber.pro_id = Convert.ToInt32(dgvRow.Cells["pro_id"].Value);

                DateTime dataPrimeiroVencimento = dtpDataVencimento.Value;
                //dia do vencimento inicial 18/05 - somar 30 dias .. verificar datas de vencimento
                double geralEntrada = 0;
                double geralLote = 0;
                decimal valorTotal = Convert.ToDecimal(txtEntrada.Text.Replace("R$", "").Trim());
                decimal entrada = Convert.ToDecimal(txtEntrada.Text.Replace("R$", "").Trim());
                decimal desconto = Convert.ToDecimal(txtDescEntrada.Text) / 100;
                valorTotal -= valorTotal * desconto;
                decimal valorParcela = Math.Round(valorTotal / numParcEntrada.Value, 2);
                decimal valorDiferenca = valorTotal - valorParcela * numParcEntrada.Value;

                for (int i = 0; i < numParcEntrada.Value; i++)//parcela de entrada
                {
                    Receber.parcela = Convert.ToInt32((i + 1).ToString());
                    string valor = !(i + 1 == numParcEntrada.Value) ? valorParcela.ToString() : (valorParcela + valorDiferenca).ToString();
                    string dataVencimento = dataPrimeiroVencimento.AddMonths(i).ToShortDateString();
                    //-------
                    Receber.dtemissao = DateTime.Now;
                    Receber.dtvencimento = Convert.ToDateTime(dataVencimento);
                    Receber.valor = Convert.ToDouble(valor);
                    geralEntrada += Convert.ToDouble(valor);
                    Receber.entrada = 1;
                    // MessageBox.Show(Receber.parcela +"||"+ Receber.dtvencimento.Value.Day + "/" + Receber.dtvencimento.Value.Month + "|| " + Receber.valor);
                    //insert na receber
                    //entrada = 1
                }
               // MessageBox.Show(geralEntrada.ToString());
                decimal valorcheio = Convert.ToDecimal(txtValorTotal.Text.Replace("R$", "").Trim());
                decimal valorTotalRestante = valorcheio - valorTotal - (entrada * desconto);
                decimal descontoRestante = Convert.ToDecimal(txtDescTotal.Text) / 100;
                valorTotalRestante -= valorTotalRestante * descontoRestante;
                decimal valorParcelaRestante = Math.Round(valorTotalRestante / numParcelas.Value, 2);
                decimal valorDiferencaRestante = valorTotalRestante - valorParcelaRestante * numParcelas.Value;
                int j = Convert.ToInt32(numParcEntrada.Value);
                for (int i = 0; i < numParcelas.Value; i++, j++)//parcela restante da divida
                {
                    Receber.parcela = Convert.ToInt32((i + 1).ToString());
                    string valor = !(i + 1 == numParcEntrada.Value) ? valorParcelaRestante.ToString() : (valorParcelaRestante + valorDiferencaRestante).ToString();
                    string dataVencimento = dataPrimeiroVencimento.AddMonths(j).ToShortDateString();
                    //-------
                    Receber.dtemissao = DateTime.Now;
                    Receber.dtvencimento = Convert.ToDateTime(dataVencimento);
                    Receber.valor = Convert.ToDouble(valor);
                    geralLote += Convert.ToDouble(valor);
                    Receber.entrada = 0;
                    //  MessageBox.Show(Receber.parcela + "||" + Receber.dtvencimento.Value.Day + "/" + Receber.dtvencimento.Value.Month + "|| " + Receber.valor);
                    //insert na receber
                    //entrada = 0;
                }
                // MessageBox.Show(geralLote.ToString());
                // geralTotal += geralEntrada + geralLote;
                // MessageBox.Show(geralTotal.ToString());
            }
            // Salvar lotes com Id cliente e projeto, Se for menos de 1 não precisa, Mais de um lote Gerar qtd -1 

            //DialogHelper.Informacao("Falta fazer! gerar pagamentos para todos os lotes desse cliente");
        }

        private void bCancelarLote_Click(object sender, EventArgs e)
        {

            pDadosLote.Visible = false;
            if (dgvLoteCliente.Rows.Count > 0)
            {
                dgvLoteCliente.DataSource = null;
            }
        }

        private void bAlteraLote_Click(object sender, EventArgs e)
        {
            if (dgvLoteCliente.SelectedRows.Count > 0)
            {
                editar = true;
                txtCodLote.Text = dgvLoteCliente.CurrentRow.Cells["CodLote"].Value.ToString();
                txtLotid.Text = dgvLoteCliente.CurrentRow.Cells["CodLote"].Value.ToString();
                txtNroLote.Text = dgvLoteCliente.CurrentRow.Cells["Lote"].Value.ToString();
                txtNroQuadra.Text = dgvLoteCliente.CurrentRow.Cells["Quadra"].Value.ToString();
                txtMatricula.Text = dgvLoteCliente.CurrentRow.Cells["Matrícula"].Value.ToString();
                Projeto.pro_id = Convert.ToInt32(dgvLoteCliente.CurrentRow.Cells["pro_id"].Value);
                Cliente.cli_id = Convert.ToInt32(dgvLoteCliente.CurrentRow.Cells["CodCli"].Value);
                Lote.lot_id = Convert.ToInt32(dgvLoteCliente.CurrentRow.Cells["CodLote"].Value);
                lot_id = Convert.ToInt32(dgvLoteCliente.CurrentRow.Cells["CodLote"].Value);

                try
                {
                    var reader = receberRepository.Valor(cli_id, lot_id, pro_id, 1);
                    var read = receberRepository.Valor(cli_id, lot_id, pro_id, 0);
                    if (read == null && reader == null)
                    {
                        bGerarLote.PerformClick();
                    }

                    if (reader != null)
                    {
                        numParcEntrada.Value = reader.total_parcela;
                        txtDescEntrada.Text = reader.descontoEntrada.ToString();
                        txtEntrada.Text = reader.valorEntrada.ToString("C2");
                        txtValorTotal.Text = reader.valorLote.ToString("C2");
                        dtpEntrada.Value = reader.dtvencimento.Value;
                    }
                    if (read != null)
                    {
                        numParcelas.Value = read.total_parcela;
                        txtDescTotal.Text = read.descontoSaldo.ToString();
                        txtEntrada.Text = reader.valorEntrada.ToString("C2");
                        txtValorTotal.Text = reader.valorLote.ToString("C2");
                        dtpDataVencimento.Value = reader.dtvencimento.Value;
                    }
                    CalculaParcEntrada();
                    CalcularParcelas();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                DialogHelper.Informacao("Selecione um registro para alterar.");
            }
        }

        private void bAddLotes_Click(object sender, EventArgs e)
        {
            int qtd = Convert.ToInt32(txtAddLote.Text);
            if (qtd == 0)
            {
                DialogHelper.Informacao("Quantidade de lotes não pode ser zero.");
                txtAddLote.Focus();
            }
            else
            {
                try
                {
                    //  if (validaObjeto())
                    //   {
                    AtualizarObjetoLote();
                    for (int i = 0; i <= qtd - 1; i++)
                    {
                        repLote.CadastrarValoresLote(Lote, Projeto, Cliente, Orcamento);
                        CarregarDgvLotes(pro_id, cli_id);
                    }
                    //   }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

        }

        private void txtAddLote_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08)
            {
                e.Handled = true;
            }
            if (e.KeyChar == 13)
            {
                bAddLotes.PerformClick();
            }
        }

        private void txtAddLote_Enter(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtAddLote.Text))
            {
                txtAddLote.SelectionStart = 0;
                txtAddLote.SelectionLength = txtAddLote.Text.Length;
            }
        }

        private void bExcluiLote_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("Confirma exclusão deste lote ?", "Confirma Exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {
                if (dgvCadastro.SelectedRows.Count > 0)
                {
                    lot_id = Convert.ToInt32(dgvLoteCliente.CurrentRow.Cells["CodLote"].Value);
                    try
                    {
                        if (repLote.Excluir(lot_id, pro_id, cli_id))
                        {
                            CarregarDgvLotes(pro_id, cli_id);//---> Atualiza Data grid view
                            DialogHelper.Informacao("Lote excluido com sucesso.");//, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                                                                  // Inicializar();
                        }
                        else
                        {
                            DialogHelper.Informacao("Não foi possível excluir o lote.");
                        }


                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lote não pode ser excluido." + ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
        }

        private void bSalvarLote_Click(object sender, EventArgs e)
        {
            if (editar == true)//alterar
            {
                try
                {
                    if (validaObjeto())
                    {
                        AtualizarObjeto();
                        if (repLote.ProcurarLote(txtNroLote.Text, txtNroQuadra.Text, Convert.ToInt32(cbbProjeto.SelectedValue)))
                        {
                            DialogHelper.Informacao("Já existe lote para está quadra com esse número verifique o número e quadra do lote.");//Login já Cadastrado
                            txtNroLote.Focus();
                            return;
                        }
                        else
                        {
                            repLote.alterar(Lote, Projeto, Cliente);
                            CarregarDgvLotes(pro_id, cli_id);
                           // CarregaDgv();
                            //cbbBuscaProjeto.SelectedValue = cbbProjeto.SelectedValue;
                        }
                        //atualizar a grid com o Id do projeto                       
                        // Inicializar();
                        LimpaTela();
                       
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void GerarEntrada()
        {
            List<Receber> recebers = new List<Receber>();
            if (dgvLoteCliente.SelectedRows.Count > 0)
            {
                pro_id = Convert.ToInt32(dgvLoteCliente.CurrentRow.Cells["pro_id"].Value);
                cli_id = Convert.ToInt32(dgvLoteCliente.CurrentRow.Cells["CodCli"].Value);
                lot_id = Convert.ToInt32(dgvLoteCliente.CurrentRow.Cells["CodLote"].Value);

                if (!receberRepository.BuscaEntrada(cli_id, lot_id, pro_id, 1))
                {
                    DateTime dataPrimeiroVencimento = dtpEntrada.Value;
                    //dia do vencimento inicial 18/05 - somar 30 dias .. verificar datas de vencimento            
                    decimal valorTotal = Convert.ToDecimal(txtEntrada.Text.Replace("R$", "").Trim());
                    decimal entrada = Convert.ToDecimal(txtEntrada.Text.Replace("R$", "").Trim());
                    decimal desconto = Convert.ToDecimal(txtDescEntrada.Text) / 100;
                    valorTotal -= valorTotal * desconto;
                    decimal valorParcela = Math.Round(valorTotal / numParcEntrada.Value, 2);
                    decimal valorDiferenca = valorTotal - valorParcela * numParcEntrada.Value;

                    for (int i = 0; i < numParcEntrada.Value; i++)//parcela de entrada
                    {
                        string valor = !(i + 1 == numParcEntrada.Value) ? valorParcela.ToString() : (valorParcela + valorDiferenca).ToString();
                        string dataVencimento = dataPrimeiroVencimento.AddMonths(i).ToShortDateString();
                        var parcelas = new Receber()
                        {
                            lot_id = Convert.ToInt32(dgvLoteCliente.CurrentRow.Cells["CodLote"].Value),
                            cli_id = Convert.ToInt32(dgvLoteCliente.CurrentRow.Cells["CodCli"].Value),
                            pro_id = Convert.ToInt32(dgvLoteCliente.CurrentRow.Cells["pro_id"].Value),
                            parcela = Convert.ToInt32((i + 1).ToString()),
                            total_parcela = Convert.ToInt32(numParcEntrada.Value),
                            dtemissao = DateTime.Now,
                            dtvencimento = Convert.ToDateTime(dataVencimento),
                            valor = Convert.ToDouble(valor),
                            descontoEntrada = Convert.ToDouble(txtDescEntrada.Text),
                            valorEntrada = Convert.ToDouble(entrada),
                            valorLote = Convert.ToDouble(txtValorTotal.Text.Replace("R$", "").Trim()),
                            //valorpago = Convert.ToDouble(valor),
                            entrada = 1,
                        };
                        recebers.Add(parcelas);
                    }

                    if (receberRepository.Insert(recebers))
                    {
                        DialogHelper.Informacao("Entrada cadastrada com sucesso!");
                        LimpaTela();
                        CarregarDgvLotes(pro_id, cli_id);
                    }
                    else
                    {
                        DialogHelper.Erro("Não foi possível cadastrar entradas para esse lote");
                    }
                }
                else
                {
                    DialogHelper.Alerta("Não foi possível cadastrar entradas lote já possui entradas cadastradas!");
                }


            }
            else
            {
                DialogHelper.Alerta("Selecione um registro.");
            }
        }

        private void GerarSaldo()
        {
            List<Receber> recebers = new List<Receber>();
            if (dgvLoteCliente.SelectedRows.Count > 0)
            {
                pro_id = Convert.ToInt32(dgvLoteCliente.CurrentRow.Cells["pro_id"].Value);
                cli_id = Convert.ToInt32(dgvLoteCliente.CurrentRow.Cells["CodCli"].Value);
                lot_id = Convert.ToInt32(dgvLoteCliente.CurrentRow.Cells["CodLote"].Value);

                if (!receberRepository.BuscaEntrada(cli_id, lot_id, pro_id, 0))
                {
                    decimal valorTotal = Convert.ToDecimal(txtEntrada.Text.Replace("R$", "").Trim());
                    decimal entrada = Convert.ToDecimal(txtEntrada.Text.Replace("R$", "").Trim());
                    decimal desconto = Convert.ToDecimal(txtDescEntrada.Text) / 100;
                    DateTime dataPrimeiroVencimento = dtpDataVencimento.Value;
                    //dia do vencimento inicial 18/05 - somar 30 dias .. verificar datas de vencimento            
                    decimal valorcheio = Convert.ToDecimal(txtValorTotal.Text.Replace("R$", "").Trim());
                    decimal valorTotalRestante = valorcheio - valorTotal - (entrada * desconto);
                    decimal descontoRestante = Convert.ToDecimal(txtDescTotal.Text) / 100;
                    valorTotalRestante -= valorTotalRestante * descontoRestante;
                    decimal valorParcelaRestante = Math.Round(valorTotalRestante / numParcelas.Value, 2);
                    decimal valorDiferencaRestante = valorTotalRestante - valorParcelaRestante * numParcelas.Value;

                    for (int i = 0; i < numParcelas.Value; i++)//parcela de entrada
                    {
                        string valor = !(i + 1 == numParcelas.Value) ? valorParcelaRestante.ToString() : (valorParcelaRestante + valorDiferencaRestante).ToString();
                        string dataVencimento = dataPrimeiroVencimento.AddMonths(i).ToShortDateString();
                        var parcelas = new Receber()
                        {
                            lot_id = Convert.ToInt32(dgvLoteCliente.CurrentRow.Cells["CodLote"].Value),
                            cli_id = Convert.ToInt32(dgvLoteCliente.CurrentRow.Cells["CodCli"].Value),
                            pro_id = Convert.ToInt32(dgvLoteCliente.CurrentRow.Cells["pro_id"].Value),
                            parcela = Convert.ToInt32((i + 1).ToString()),
                            total_parcela = Convert.ToInt32(numParcelas.Value),
                            dtemissao = DateTime.Now,
                            dtvencimento = Convert.ToDateTime(dataVencimento),
                            valor = Convert.ToDouble(valor),
                            descontoSaldo = Convert.ToDouble(txtDescTotal.Text),
                            valorEntrada = Convert.ToDouble(entrada),
                            valorLote = Convert.ToDouble(txtValorTotal.Text.Replace("R$", "").Trim()),
                            //valorpago = Convert.ToDouble(valor),
                            entrada = 0,
                        };
                        recebers.Add(parcelas);
                    }

                    if (receberRepository.Insert(recebers))
                    {
                        DialogHelper.Informacao("Recebimentos cadastrados com sucesso!");
                        LimpaTela();
                        CarregarDgvLotes(pro_id, cli_id);
                    }
                    else
                    {
                        DialogHelper.Erro("Não foi possível cadastrar recebimentos para esse lote");
                    }
                }
                else
                {
                    DialogHelper.Alerta("Não foi possível cadastrar parcelas para o lote já possui saldo cadastrado!");
                }


            }
            else
            {
                DialogHelper.Informacao("Selecione um registro.");
            }
        }

        private void bGerarEntrada_Click(object sender, EventArgs e)
        {
            try
            {
                GerarEntrada();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void bGerarSaldo_Click(object sender, EventArgs e)
        {
            try
            {
                GerarSaldo();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvCadastro_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            DataGridView gridView;
            gridView = (DataGridView)sender;
            gridView.ClearSelection();
        }

        private void dgvLoteCliente_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            DataGridView gridView;
            gridView = (DataGridView)sender;
            gridView.ClearSelection();
        }

        private void bAlterarEntrada_Click(object sender, EventArgs e)
        {
            if (txtLotid.Text == "")
            {
                DialogHelper.Alerta("Selecione um lote para excluir pagamentos");
            }
            else
            {
                lot_id = Convert.ToInt32(dgvLoteCliente.CurrentRow.Cells["CodLote"].Value);
                DialogResult resultado = MessageBox.Show("Confirma exclusão de pagamentos deste lote ?", "Confirma Exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (resultado == DialogResult.Yes)
                {
                    if (receberRepository.TemPagamento(lot_id, 1))
                    {
                        DialogHelper.Alerta("Não foi possível exluir pagamentos já há pagamentos efetuados");
                    }
                    else
                    {
                        if (receberRepository.ExcluirParcelas(cli_id, lot_id, pro_id, 1))//excluir tudo com o cli_id, lot_id, pro_id, entrada = 1
                        {
                            DialogHelper.Informacao("Pagamentos excluidos com sucesso. Gerar um novo pagamento!");
                            CarregarDgvLotes(pro_id, cli_id);
                        }
                        else
                        {
                            DialogHelper.Informacao("Não foi possível exluir pagamentos");
                        }
                    }

                }
            }
        }

        private void bAlterarSaldo_Click(object sender, EventArgs e)
        {
            if (txtLotid.Text == "")
            {
                DialogHelper.Alerta("Selecione um lote para excluir pagamentos");
            }
            else
            {
                lot_id = Convert.ToInt32(dgvLoteCliente.CurrentRow.Cells["CodLote"].Value);
                DialogResult resultado = MessageBox.Show("Confirma exclusão de pagamentos deste lote ?", "Confirma Exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (resultado == DialogResult.Yes)
                {
                    //Conferir se tem recebimento se não tiver 
                    if (receberRepository.TemPagamento(lot_id, 0))
                    {
                        DialogHelper.Informacao("Não foi possível exluir pagamentos já há pagamentos efetuados");
                    }
                    else
                    {
                        if (receberRepository.ExcluirParcelas(cli_id, lot_id, pro_id, 0))//excluir tudo com o cli_id, lot_id, pro_id, entrada = 0
                        {
                            DialogHelper.Informacao("Pagamentos excluidos com sucesso. Gerar um novo pagamento!");
                            CarregarDgvLotes(pro_id, cli_id);
                        }
                        else
                        {
                            DialogHelper.Informacao("Não foi possível exluir pagamentos");
                        }
                    }


                }
            }
        }

        private void dgvLoteCliente_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {            
            if (dgvLoteCliente.SelectedRows.Count > 0)
            {
                editar = true;
                txtCodLote.Text = dgvLoteCliente.CurrentRow.Cells["CodLote"].Value.ToString();
                txtLotid.Text = dgvLoteCliente.CurrentRow.Cells["CodLote"].Value.ToString();
                txtNroLote.Text = dgvLoteCliente.CurrentRow.Cells["Lote"].Value.ToString();
                txtNroQuadra.Text = dgvLoteCliente.CurrentRow.Cells["Quadra"].Value.ToString();
                txtMatricula.Text = dgvLoteCliente.CurrentRow.Cells["Matrícula"].Value.ToString();
                Projeto.pro_id = Convert.ToInt32(dgvLoteCliente.CurrentRow.Cells["pro_id"].Value);
                Cliente.cli_id = Convert.ToInt32(dgvLoteCliente.CurrentRow.Cells["CodCli"].Value);
                Lote.lot_id = Convert.ToInt32(dgvLoteCliente.CurrentRow.Cells["CodLote"].Value);
                lot_id = Convert.ToInt32(dgvLoteCliente.CurrentRow.Cells["CodLote"].Value);

                try
                {
                    var reader = receberRepository.Valor(cli_id, lot_id, pro_id, 1);
                    var read = receberRepository.Valor(cli_id, lot_id, pro_id, 0);
                    if (read == null && reader == null)
                    {
                        bGerarLote.PerformClick();
                    }

                    if (reader != null)
                    {
                        numParcEntrada.Value = reader.total_parcela;
                        txtDescEntrada.Text = reader.descontoEntrada.ToString();
                        txtEntrada.Text = reader.valorEntrada.ToString("C2");
                        txtValorTotal.Text = reader.valorLote.ToString("C2");
                        dtpEntrada.Value = reader.dtvencimento.Value;
                    }
                    if (read != null)
                    {
                        numParcelas.Value = read.total_parcela;
                        txtDescTotal.Text = read.descontoSaldo.ToString();
                        txtEntrada.Text = reader.valorEntrada.ToString("C2");
                        txtValorTotal.Text = reader.valorLote.ToString("C2");
                        dtpDataVencimento.Value = reader.dtvencimento.Value;
                    }
                    CalculaParcEntrada();
                    CalcularParcelas();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                DialogHelper.Informacao("Selecione um registro para alterar.");
            }
        }
    }
}
