using GPF.Helper;
using GPF.Model;
using GPF.Repository;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GPF.View
{
    public partial class fCadRecebimento : Form
    {
        public Lote Lote { get; set; }
        public Projeto Projeto { get; set; }
        public Cliente Cliente { get; set; }

        private int recebimento_id;

        LoteRepository repLote = new LoteRepository();
        ClienteRepository repCli = new ClienteRepository();
        ProjetoRepository repPro = new ProjetoRepository();
        ReceberRepository receberRepository = new ReceberRepository();
        StringBuilder sql = new StringBuilder();
        List<Dados> selecionados = new List<Dados>();

        private void fCadRecebimento_Load(object sender, EventArgs e)
        {
            dgvLotes.ColumnCount = 5;

            dgvLotes.Columns[0].Name = "CodRec";
            dgvLotes.Columns[1].Name = "CodLote";
            dgvLotes.Columns[2].Name = "CodCli";
            dgvLotes.Columns[3].Name = "CodPro";
            dgvLotes.Columns[4].Name = "Valor";

            //Styles
            dgvLotes.Columns[4].DefaultCellStyle.Format = "C2";
            dgvLotes.Columns[3].Visible = false;
            dgvLotes.Columns[0].Width = 50;
            dgvLotes.Columns[1].Width = 50;
            dgvLotes.Columns[2].Width = 50;
        }

        private struct Dados
        {
            public int codRec { get; set; }
            public int codLote { get; set; }
            public int codCli { get; set; }
            public int codPro { get; set; }
            public decimal valor { get; set; }

            public Dados(int codRec, int codLote, int codCli, int codPro, decimal valor) : this()
            {
                this.codRec = codRec;
                this.codLote = codLote;
                this.codCli = codCli;
                this.codPro = codPro;
                this.valor = valor;
            }

        }

        public fCadRecebimento()
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
            carregarTipos();
            dtpVencInicial.Value = DateTime.Now;
            dtpVencFinal.Value = DateTime.Now;
            cbbProjeto.SelectedItem = null;
            cbbCliente.SelectedItem = null;
            cbbTipoMovimento.SelectedIndex = 0;
        }



        private void carregarTipos()
        {
            cbbTipoMovimento.Items.Insert(0, "Todos");
            // cbbTipoMovimento.Items.Insert(1, "Entrada");
            cbbTipoMovimento.Items.Insert(1, "Em aberto");
            cbbTipoMovimento.Items.Insert(2, "Vencidos");
        }


        private void LimpaTela()
        {
            cbbProjeto.SelectedItem = null;
            cbbCliente.SelectedItem = null;
            dgvReceber.DataSource = null;

        }

        private void FiltroPagamentos(string onde)
        {
            if (dgvReceber.Columns.Count > 0)
            {
                dgvReceber.DataSource = null;
                dgvReceber.Columns.Clear();
            }
            var col = new DataGridViewCheckBoxColumn
            {
                Name = "Op",
                HeaderText = "Op",
                FalseValue = "0",
                TrueValue = "1",
                Width = 20,
                ValueType = typeof(bool)
            };

            col.CellTemplate.Value = false;
            col.CellTemplate.Style.NullValue = false;

            dgvReceber.Columns.Insert(0, col);


            dgvReceber.DataSource = receberRepository.FiltroRecebimentos(onde);
            dgvReceber.Columns[1].Width = 60;
            dgvReceber.Columns[2].Width = 60;
            dgvReceber.Columns[3].Visible = false;
            dgvReceber.Columns[4].Visible = false;
            dgvReceber.Columns[5].Visible = false;
            dgvReceber.Columns[6].Width = 150;
            dgvReceber.Columns[7].Width = 60;
            dgvReceber.Columns[8].DefaultCellStyle.Format = "C2";

            foreach (DataGridViewColumn dc in dgvReceber.Columns)
            {
                if (dc.Index.Equals(0))
                {
                    dc.ReadOnly = false;
                }
                else
                {
                    dc.ReadOnly = true;
                }
            }

        }

        private void FiltroPagamentosCliente(string onde, int cli_id)
        {
            dgvReceber.DataSource = null;
            dgvReceber.Columns.Clear();
            var col = new DataGridViewCheckBoxColumn
            {
                Name = "Op",
                HeaderText = "Op",
                FalseValue = "0",
                TrueValue = "1",
                Width = 20,
                ValueType = typeof(bool)
            };
            col.CellTemplate.Value = false;
            col.CellTemplate.Style.NullValue = false;

            dgvReceber.Columns.Insert(0, col);

            dgvReceber.DataSource = receberRepository.GetRecebimentos(onde, cli_id);
            dgvReceber.Columns[1].Width = 60;
            dgvReceber.Columns[2].Width = 60;
            dgvReceber.Columns[3].Visible = false;
            dgvReceber.Columns[4].Visible = false;
            dgvReceber.Columns[5].Visible = false;
            dgvReceber.Columns[6].Width = 150;
            dgvReceber.Columns[7].Width = 60;
            dgvReceber.Columns[8].DefaultCellStyle.Format = "C2";

            foreach (DataGridViewColumn dc in dgvReceber.Columns)
            {
                if (dc.Index.Equals(0))
                {
                    dc.ReadOnly = false;
                }
                else
                {
                    dc.ReadOnly = true;
                }
            }
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

        private void carregarClientes()
        {
            try
            {
                cbbCliente.DataSource = repCli.GetClienteProjeto(Convert.ToInt32(cbbProjeto.SelectedValue));
                cbbCliente.DisplayMember = "cli";
                cbbCliente.ValueMember = "cli_id";
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        private void dtpVencInicial_ValueChanged(object sender, EventArgs e)
        {
            dtpVencInicial.Format = DateTimePickerFormat.Custom;
            dtpVencInicial.CustomFormat = "dd/MM/yyyy";
        }

        private void dtpVencFinal_ValueChanged(object sender, EventArgs e)
        {
            dtpVencFinal.Format = DateTimePickerFormat.Custom;
            dtpVencFinal.CustomFormat = "dd/MM/yyyy";
        }

        private void bFiltro_Click(object sender, EventArgs e)
        {
            if (cbbProjeto.SelectedItem == null)
            {
                DialogHelper.Alerta("Selecione um projeto.");
                cbbProjeto.Focus();
            }
            else
            {

                var opcao = 1;
                if (cbbProjeto.SelectedIndex >= 0)// todos entre as datas
                {
                    opcao = 1;
                }
                if (cbbTipoMovimento.SelectedIndex == 1)//Em aberto
                {
                    opcao = 2;
                }
                if (cbbTipoMovimento.SelectedIndex == 2)//vencidos
                {
                    opcao = 3;
                }

                switch (opcao)
                {
                    case 1:
                        {
                            sql.Clear();
                            sql.Append(" where r.pro_id = " + cbbProjeto.SelectedValue + " and dtvencimento >= " + "'" + dtpVencInicial.Value + "'" + " and dtvencimento <= " + "'" + dtpVencFinal.Value + "'");
                        }
                        break;
                    case 2:
                        {
                            sql.Clear();
                            sql.Append(" where r.pro_id = " + cbbProjeto.SelectedValue + " and valorpago = 0");
                        }
                        break;

                    case 3:
                        {
                            sql.Clear();
                            sql.Append(" where r.pro_id = " + cbbProjeto.SelectedValue + " and dtvencimento <=  " + "'" + dtpVencFinal.Value + "'" + " and valorpago = 0");
                        }
                        break;
                }
                FiltroPagamentos(sql.ToString());
                carregarClientes();
                cbbCliente.SelectedItem = null;
                SomarValor();
                //---
                cbbProjeto.Enabled = false;
                cbbTipoMovimento.Enabled = false;

            }

        }

        private void SomarValor()
        {
            decimal valor = 0;

            if (dgvReceber.RowCount > 0)
            {
                foreach (DataGridViewRow dgvRow in dgvReceber.Rows)
                {
                    valor += Convert.ToDecimal(dgvRow.Cells["Valor"].Value);
                }
            }

            lbTotal.Text = valor.ToString("C2");
        }

        private void CalcularSelecionado()
        {
            decimal valor = 0;
            int cont = 0;
            foreach (DataGridViewRow row in dgvReceber.Rows)
            {
                int op = Convert.ToInt32(row.Cells["Op"].Value);
                if (op == 1)
                {
                    cont++;
                    valor += Convert.ToDecimal(row.Cells["Valor"].Value);
                    lbSomaSelect.Text = valor.ToString("C2");
                    lbTotalSelecionado.Text = cont.ToString();
                    //Add Na lista selecionados para carregar grid lotes
                    selecionados.Add(
                        new Dados(Convert.ToInt32(row.Cells["CodRec"].Value),
                        Convert.ToInt32(row.Cells["CodLote"].Value),
                        Convert.ToInt32(row.Cells["pro_id"].Value),
                        Convert.ToInt32(row.Cells["cli_id"].Value),
                        Convert.ToDecimal(row.Cells["Valor"].Value)
                            )
                        );
                }
            }
        }

        private void cbbTipoMovimento_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cbbTipoMovimento.SelectedIndex == 1)
            {
                dtpVencInicial.Format = DateTimePickerFormat.Custom;
                dtpVencInicial.CustomFormat = " ";

                dtpVencFinal.Format = DateTimePickerFormat.Custom;
                dtpVencFinal.CustomFormat = " ";

                dtpVencFinal.Enabled = false;
                dtpVencInicial.Enabled = false;
            }
            else if (cbbTipoMovimento.SelectedIndex == 2)
            {
                dtpVencInicial.Format = DateTimePickerFormat.Custom;
                dtpVencInicial.CustomFormat = " ";
                dtpVencFinal.Value = DateTime.Now;
                dtpVencInicial.Enabled = false;
            }
            else
            {
                dtpVencFinal.Enabled = true;
                dtpVencInicial.Enabled = true;
                dtpVencFinal.Value = DateTime.Now;
                dtpVencInicial.Value = DateTime.Now;
            }
        }

        private void bNovaBusca_Click(object sender, EventArgs e)
        {
            cbbProjeto.Enabled = true;
            cbbTipoMovimento.Enabled = true;
            cbbTipoMovimento.SelectedIndex = 0;
            bFiltro.Enabled = true;
            lbTotal.Text = "0.000,00";
            lbSomaSelect.Text = "0.000,00";
            lbTotalSelecionado.Text = "0";
            dgvLotes.Rows.Clear();
            LimpaTela();
            cbbProjeto.Focus();

        }

        private void cbbCliente_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (cbbCliente.SelectedItem != null)
            {
                try
                {
                    var cli_id = Convert.ToInt32(cbbCliente.SelectedValue);
                    FiltroPagamentosCliente(sql.ToString(), cli_id);
                    SomarValor();
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        private void bTodos_Click(object sender, EventArgs e)
        {
            if (bFiltro.Enabled == true)
            {
                cbbCliente.SelectedItem = null;
                bFiltro.PerformClick();
            }
        }

        private void dgvReceber_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (dgvReceber.Columns[0].Selected == true)
            {
                dgvReceber.Columns[0].CellTemplate.Value = false;
                dgvReceber.Columns[0].CellTemplate.Style.NullValue = false;
                //  dgvReceber.CurrentRow.Selected = false;
            }
            else
            {
                dgvReceber.Columns[0].CellTemplate.Value = true;
                dgvReceber.Columns[0].CellTemplate.Style.NullValue = true;
                // dgvReceber.CurrentRow.Selected = true;               
            }

        }

        private void bCalcular_Click(object sender, EventArgs e)
        {
            lbSomaSelect.Text = "0.000,00";
            lbTotalSelecionado.Text = "0";
            dgvLotes.Rows.Clear();
            selecionados.Clear();
            CalcularSelecionado();
        }

        private void bDetalhes_Click(object sender, EventArgs e)
        {
            dgvLotes.Rows.Clear();

            foreach (Dados dados in selecionados)
            {
                dgvLotes.Rows.Add(dados.codRec, dados.codLote, dados.codPro, dados.codCli, dados.valor);
            }

        }

        private void dgvLotes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvLotes.SelectedRows.Count > 0)
            {
                txtValorTotal.Text = dgvLotes.CurrentRow.Cells["Valor"].Value.ToString();
                txtLotid.Text = dgvLotes.CurrentRow.Cells["CodLote"].Value.ToString();
                Projeto.pro_id = Convert.ToInt32(dgvLotes.CurrentRow.Cells["CodPro"].Value);
                Cliente.cli_id = Convert.ToInt32(dgvLotes.CurrentRow.Cells["CodCli"].Value);
                Lote.lot_id = Convert.ToInt32(dgvLotes.CurrentRow.Cells["CodLote"].Value);
                recebimento_id = Convert.ToInt32(dgvLotes.CurrentRow.Cells["CodRec"].Value);               
            }
            else
            {
                DialogHelper.Informacao("Selecione um registro.");
            }
        }

        private void txtValorPago_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
            {
                e.Handled = true;               
            }
        }
    }
}
