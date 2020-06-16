namespace GPF.Model
{
    public class Lote
    {
        public int? lot_id { get; set; }
        public int? cli_id { get; set; }
        public int? pro_id { get; set; }
        public Projeto projeto { get; set; }
        public Orcamento orcamento { get; set; }
        public Cliente cliente { get; set; }
        public string lot_numero { get; set; }
        public string lot_quadra { get; set; }
        public string lot_matricula { get; set; }

        public Lote() : this(null,null,null,null,null,null,"","","")
        {
        }

        public Lote(int? lot_id,int? cli_id, int? pro_id, Projeto projeto, Orcamento orcamento, Cliente cliente, string lot_numero, string lot_quadra, string lot_matricula)
        {
            this.lot_id = lot_id;
            this.cli_id = cli_id;
            this.pro_id = pro_id;
            this.projeto = projeto;
            this.orcamento = orcamento;
            this.cliente = cliente;
            this.lot_numero = lot_numero;
            this.lot_quadra = lot_quadra;
            this.lot_matricula = lot_matricula;
        }
    }
}
