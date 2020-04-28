namespace GPF.Model
{
    public class Cidade
    {
        public int? cid_id { get; set; }
        public Uf Uf { get; set; }
        public string cid_nome { get; set; }
        public string cid_ibge { get; set; }

        public Cidade() : this(null, null, "","")
        {
        }

        public Cidade(int? cid_id, Uf uf, string cid_nome, string cid_ibge)
        {
            this.cid_id = cid_id;
            this.Uf = uf;
            this.cid_nome = cid_nome;
            this.cid_ibge = cid_ibge;
        }

        public override string ToString()
        {
            return cid_nome;
        }
    }

}
