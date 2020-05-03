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
        public int orc_qtdparcela { get; set; }
        public DateTime? orc_dtorcamento { get; set; }
        public DateTime? orc_dtvencimento { get; set; }
        public DateTime? orc_dtmulta { get; set; }
        public DateTime? orc_dtiniciopag { get; set; }
        public double orc_porc_multa { get; set; }
        public int orc_aprovado { get; set; }

        public Orcamento() : this (null,null,null,null,0,0,null,null,null,null,0,0)
        {
        }

        public Orcamento(int? orc_id, Cliente cli_id, Lote lot_id, Projeto pro_id, 
            double orc_valor, int orc_qtdparcela, DateTime? 
            orc_dtorcamento, DateTime? orc_dtvencimento, DateTime? orc_dtmulta,
            DateTime? orc_dtiniciopag, double orc_porc_multa, int orc_aprovado)
        {
            this.orc_id = orc_id;
            this.cli_id = cli_id;
            this.lot_id = lot_id;
            this.pro_id = pro_id;
            this.orc_valor = orc_valor;
            this.orc_qtdparcela = orc_qtdparcela;
            this.orc_dtorcamento = orc_dtorcamento;
            this.orc_dtvencimento = orc_dtvencimento;
            this.orc_dtmulta = orc_dtmulta;
            this.orc_dtiniciopag = orc_dtiniciopag;
            this.orc_porc_multa = orc_porc_multa;
            this.orc_aprovado = orc_aprovado;
        }
    }
}
