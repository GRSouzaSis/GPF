using GPF.Helper;
using GPF.Model;
using GPF.Repository;
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Configuration;
using System.Linq;
using GPF.Cache;
using System.Data.SqlTypes;

namespace GPF.View
{
    public partial class fCadCliLote : Form
    {
        public Lote Lote { get; set; }
        public Projeto Projeto { get; set; }
        public Cliente Cliente { get; set; }
        public Orcamento Orcamento { get; set; }

        private bool editar = false;
        private int lot_id;
        private int cli_id;
        private int pro_id;

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
            Orcamento = new Orcamento();
            carregarProjeto();
            carregarProjetoBusca();
            carregarCliente();
            PreencherDataVencimento();
            AplicarEventos(txtValorTotal);
            AplicarEventos(txtEntrada);
            AplicarEventos(txtSaldoTotal);
            AplicarEventos(txtValorParcela);
            AplicarEventos(txtValorParcEntrada);
            AplicarEventos(txtSomaTotal);
            cbbVencimento.SelectedItem = null;
            cbbProjeto.SelectedItem = null;
            cbbCliente.SelectedItem = null;
            cbbBuscaProjeto.SelectedItem = null;
            cbbProjeto.Focus();
            AtualizarInterface();
            txtDescTotal.Text = "0";
            txtDescEntrada.Text = "0";
            txtValorParcela.Text = "R$ 0,00";
            txtValorParcEntrada.Text = "R$ 0,00";
            txtAddLote.Text = "0";
            txtSomaTotal.Text = "R$ 0,00";
            txtSaldoTotal.Text = "R$ 0,00";
            txtValorTotal.Enabled = false;
            txtEntrada.Enabled = false;
            pDadosLote.Visible = false;
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
                dgvCadastro.Columns[0].Width = 150;
                dgvCadastro.Columns[1].Width = 200;
                dgvCadastro.Columns[2].Visible = false;
                dgvCadastro.Columns[3].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        public void PreencherDataVencimento()
        {

            for (int i = 1; i <= 31; i++)
            {
                cbbVencimento.Items.Add(i);
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

        private double CalcularSaldo()
        {
            double valorParcela, entrada, saldo, porcSaldo;
            int qtdentrada, qtdevalor;

            try
            {
                valorParcela = Convert.ToDouble(txtValorParcela.Text.Replace("R$", "").Trim());
                qtdevalor = Convert.ToInt32(numParcelas.Value);

                entrada = Convert.ToDouble(txtValorParcEntrada.Text.Replace("R$", "").Trim());
                qtdentrada = Convert.ToInt32(numParcEntrada.Value);

                saldo = (valorParcela * qtdevalor) + (entrada * qtdentrada);
                if (txtDescTotal.Text != "0")
                {
                    porcSaldo = Convert.ToDouble(txtDescTotal.Text) / 100;
                    saldo = (saldo - (saldo * porcSaldo));
                    txtSaldoTotal.Text = double.Parse(Convert.ToString(saldo)).ToString("C2");
                    return saldo;
                }
                else
                {
                    txtSaldoTotal.Text = double.Parse(Convert.ToString(saldo)).ToString("C2");
                    return saldo;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        private void SaldoTotal()
        {
            double saldo, resultado;
            int qtd;
            qtd = Convert.ToInt32(txtQtdLote.Text);
            saldo = CalcularSaldo();
            if (qtd > 0)
            {
                resultado = saldo * qtd;
                txtSomaTotal.Text = double.Parse(Convert.ToString(resultado)).ToString("C2");
            }
            else
            {
                txtSomaTotal.Text = double.Parse(Convert.ToString(saldo)).ToString("C2");
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

        private void txtDescTotal_Leave(object sender, EventArgs e)
        {
            if (txtDescTotal.Text != "")
            {
                try
                {
                    CalcularSaldo();
                    SaldoTotal();
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
            else
            {
                txtDescTotal.Text = "0";
            }
        }

        private void numParcelas_Leave(object sender, EventArgs e)
        {
            try
            {
                CalcularSaldo();
                SaldoTotal();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void txtQtdLote_Enter(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtQtdLote.Text))
            {
                txtQtdLote.SelectionStart = 0;
                txtQtdLote.SelectionLength = txtQtdLote.Text.Length;
            }
        }

        private void txtQtdLote_Leave(object sender, EventArgs e)
        {
            if (txtQtdLote.Text == "")
            {
                txtQtdLote.Text = "0";
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

        private void numParcEntrada_Enter_1(object sender, EventArgs e)
        {

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

        private void txtValorTotal_TextChanged(object sender, EventArgs e)
        {
            txtValorParcela.Text = txtValorTotal.Text;
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

        private void txtEntrada_TextChanged(object sender, EventArgs e)
        {

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
           // cbbProjeto.SelectedItem = null;
           // cbbCliente.SelectedItem = null;
        }
        private void carregarProjeto()
        {
            try
            {
                cbbProjeto.DataSource = repPro.GetAll("");// GetAll("").ToList();
                cbbProjeto.Text = "[Selecione]";
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
                cbbBuscaProjeto.Text = "[Selecione]";
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
                cbbCliente.Text = "[Selecione]";
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

        private void bSalvar_Click(object sender, EventArgs e)
        {
            if (editar == false)//Salvar
            {
                try
                {
                    if (validaObjeto())
                    {
                        AtualizarObjeto();
                        if (repLote.VerificaCliente(Convert.ToInt32(cbbProjeto.SelectedValue), Convert.ToInt32(cbbCliente.SelectedValue)))
                        {
                            repLote.Cadastrar(Lote, Projeto, Cliente);
                            cbbBuscaProjeto.SelectedValue = cbbProjeto.SelectedValue;
                            //CarregaDgv();
                        }
                        else
                        {
                            DialogHelper.Informacao("Cliente já vinculado a esse projeto.");
                        }

                        //------------------------

                        // if (repLote.VerificaSeTemLote(Convert.ToInt32(cbbProjeto.SelectedValue)))
                        //   {
                        //       if (repLote.ProcurarLote(txtNroLote.Text, txtNroQuadra.Text, Convert.ToInt32(cbbProjeto.SelectedValue)))
                        //       {
                        //           DialogHelper.Informacao("Já existe lote para está quadra com esse número verifique o número e quadra do lote.");//Login já Cadastrado
                        //           txtNroLote.Focus();
                        //          return;
                        //       }
                        // repCli.cadastrar(Cliente);
                        //  repLote.Cadastrar(Lote, Projeto, Cliente);
                        //  CarregaDgv();//---> Atualiza Data grid view
                        // DialogHelper.Informacao("Usuário incluido com sucesso.");
                        //  Inicializar();
                        //  LimpaTela();
                        //  }
                        //  else
                        //   {
                        //       DialogHelper.Informacao("Quantidade de lotes desse Projeto já esta completa.");
                        //   }
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

        }

        private void bCancelar_Click(object sender, EventArgs e)
        {
            Inicializar();
        }

        private void dgvCadastro_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            LoteRepository loteRepository = new LoteRepository();

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
            LoteRepository loteRepository = new LoteRepository();
            dgvLoteCliente.DataSource = loteRepository.GetDataViewLote(cli_id, pro_id);
            dgvLoteCliente.Columns[0].Width = 60;
            dgvLoteCliente.Columns[1].Width = 60;
            dgvLoteCliente.Columns[5].Visible = false;
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

            int projeto;
            nome = txtDescricao.Text;
            if (nome == "Nome Cliente")
                nome = "";

            projeto = (Convert.ToInt32(cbbBuscaProjeto.SelectedValue));
            try
            {
                dgvCadastro.DataSource = repLote.GetDataView(nome, projeto);
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
            cbbBuscaProjeto.SelectedItem = null;
            CarregaDgv();
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

                var qtd = repLote.ContaLote(pro_id, cli_id);
                txtQtdLote.Text = Convert.ToString(qtd);
                //busca na tabela projeto, valor projeto e valor entrada;
                if (repPro.carregarValoresProjeto(pro_id))
                {
                    Projeto.pro_vlrPorLote = Convert.ToDouble(ProjetoCache.pro_vlrPorLote);
                    Projeto.pro_vlrEntrada = Convert.ToDouble(ProjetoCache.pro_vlrEntrada);

                    // carregar nos campos 
                    txtValorTotal.Text = Projeto.pro_vlrPorLote.ToString("C2");
                    txtEntrada.Text = Projeto.pro_vlrEntrada.ToString("C2");
                }
                CalculaParcEntrada();
                CalcularParcelas();
                CalcularSaldo();
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
                        repLote.excluirCliente(cli_id, pro_id);

                        DialogHelper.Informacao("Cliente removido com sucesso.");//, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        CarregaDgv();//---> Atualiza Data grid view
                        dgvLoteCliente.DataSource = null;
                        cbbBuscaProjeto.SelectedItem = pro_id;
                        //Inicializar();

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Cliente não pode ser removido." + ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
            // Salvar lotes com Id cliente e projeto, Se for menos de 1 não precisa, Mais de um lote Gerar qtd -1 
            DialogHelper.Informacao("Falta fazer! gerar pagamentos para todos os lotes desse cliente");
        }

        private void bCancelarLote_Click(object sender, EventArgs e)
        {
            pDadosLote.Visible = false;
        }

        private void bAlteraLote_Click(object sender, EventArgs e)
        {
            if (dgvCadastro.SelectedRows.Count > 0)
            {
                editar = true;
                txtCodLote.Text = dgvLoteCliente.CurrentRow.Cells["CodLote"].Value.ToString();
                txtNroLote.Text = dgvLoteCliente.CurrentRow.Cells["Lote"].Value.ToString();
                txtNroQuadra.Text = dgvLoteCliente.CurrentRow.Cells["Quadra"].Value.ToString();
                txtMatricula.Text = dgvLoteCliente.CurrentRow.Cells["Matrícula"].Value.ToString();
                Projeto.pro_id = Convert.ToInt32(dgvLoteCliente.CurrentRow.Cells["pro_id"].Value);
                Cliente.cli_id = Convert.ToInt32(dgvLoteCliente.CurrentRow.Cells["CodCli"].Value);
                Lote.lot_id = Convert.ToInt32(dgvLoteCliente.CurrentRow.Cells["CodLote"].Value);
            }
            else
            {
                DialogHelper.Informacao("Selecione um registro para alterar.");
            }
        }

        private void bAddLotes_Click(object sender, EventArgs e)
        {
            int qtd = Convert.ToInt32(txtAddLote.Text);
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
                        if (repLote.excluir(lot_id, pro_id, cli_id))
                        {
                            CarregarDgvLotes(pro_id, cli_id);//---> Atualiza Data grid view
                            DialogHelper.Informacao("Lote excluido com sucesso.");//, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            Inicializar();
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
           /* if (editar == false)//Salvar
            {
                try
                {
                    if (validaObjeto())
                    {
                        //AtualizarObjeto();
                        AtualizarObjetoLote();
                        if (repLote.ProcurarLote(txtNroLote.Text, txtNroQuadra.Text, Convert.ToInt32(cbbProjeto.SelectedValue)))
                        {
                            DialogHelper.Informacao("Já existe lote para está quadra com esse número verifique o número e quadra do lote.");//Lote já Cadastrado
                            txtNroLote.Focus();
                            return;
                        }
                        // repLote.Cadastrar(Lote, Projeto, Cliente);
                        repLote.CadastrarValoresLote(Lote, Projeto, Cliente, Orcamento);
                        CarregarDgvLotes(pro_id, cli_id);
                        CarregaDgv();
                        cbbBuscaProjeto.SelectedValue = cbbProjeto.SelectedValue;//atualizar a grid com o Id do projeto 
                        LimpaTela();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }*/
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
                            CarregaDgv();
                            cbbBuscaProjeto.SelectedValue = cbbProjeto.SelectedValue;
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
    }
}
