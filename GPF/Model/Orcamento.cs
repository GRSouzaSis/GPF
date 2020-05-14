using System;

namespace GPF.Model
{
    public class Orcamento
    {
        public int? orc_id { get; set; }
        public Cliente cli_id { get; set; }
        public Lote lot_id { get; set; }
        public Projeto pro_id { get; set; }
        public double orc_valor { get; set; }
        public double orc_valorEntrada { get; set; }
        public double orc_descEntrada { get; set; }
        public double orc_descRestante { get; set; }
        public int orc_qtdParcelaEntrada { get; set; }
        public int orc_qtdParcelaRestante { get; set; }
        public DateTime? orc_dtorcamento { get; set; }
        public DateTime? orc_dtvencimento { get; set; }       
        public DateTime? orc_dtiniciopag { get; set; }       

        public Orcamento() : this (null,null,null,null,0,0,0,0,0,0,null,null,null)
        {
        }

        public Orcamento(int? orc_id, Cliente cli_id, Lote lot_id, Projeto pro_id, double orc_valor, double orc_valorEntrada, double orc_descEntrada, double orc_descRestante,
            int orc_qtdParcelaEntrada, int orc_qtdParcelaRestante,
            DateTime? orc_dtorcamento, DateTime? orc_dtvencimento, DateTime? orc_dtiniciopag)
        {
            this.orc_id = orc_id;
            this.cli_id = cli_id;
            this.lot_id = lot_id;
            this.pro_id = pro_id;
            this.orc_valor = orc_valor;
            this.orc_valorEntrada = orc_valorEntrada;
            this.orc_descEntrada = orc_descEntrada;
            this.orc_descRestante = orc_descRestante;
            this.orc_qtdParcelaEntrada = orc_qtdParcelaEntrada;
            this.orc_qtdParcelaRestante = orc_qtdParcelaRestante;
            this.orc_dtorcamento = orc_dtorcamento;
            this.orc_dtvencimento = orc_dtvencimento;
            this.orc_dtiniciopag = orc_dtiniciopag;
        }
    }
}
