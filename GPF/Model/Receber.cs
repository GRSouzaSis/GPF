using System;

namespace GPF.Model
{
    public class Receber
    {
        public int? id_receber { get; set; }
        public int? cli_id { get; set; }
        public int? pro_id { get; set; }
        public int? uso_id { get; set; }
        public int? lot_id { get; set; }
        public int parcela { get; set; }
        public int total_parcela { get; set; }
        public DateTime? dtemissao { get; set; }
        public DateTime? dtvencimento { get; set; }
        public double valor { get; set; }
        public double valorpago { get; set; }
        public double valorLote { get; set; }
        public double valorEntrada { get; set; }
        public double descontoEntrada { get; set; }
        public double descontoSaldo { get; set; }
        public int entrada { get; set; }

        public Receber(): this (null,null,null,null,null,1,1,null,null,0,0,0,0,0,0,0)
        {
        }

        public Receber(int? id_receber, int? cli_id, int? pro_id, int? uso_id, int? lot_id, int parcela, int total_parcela, 
            DateTime? dtemissao, DateTime? dtvencimento, double valor, double valorpago, double valorLote, double valorEntrada,
            double descontoEntrada, double descontoSaldo, int entrada)
        {
            this.id_receber = id_receber;
            this.cli_id = cli_id;
            this.pro_id = pro_id;
            this.uso_id = uso_id;
            this.lot_id = lot_id;
            this.parcela = parcela;
            this.total_parcela = total_parcela;
            this.dtemissao = dtemissao;
            this.dtvencimento = dtvencimento;
            this.valor = valor;
            this.valorpago = valorpago;
            this.valorLote = valorLote;
            this.valorEntrada = valorEntrada;
            this.descontoEntrada = descontoEntrada;
            this.descontoSaldo = descontoSaldo;
            this.entrada = entrada;
        }
    }
}
