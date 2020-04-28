namespace GPF.Model
{
    public class Endereco
    {
        public int? end_id { get; set; }
        public Cidade Cidade { get; set; }
        public string end_logradouro { get; set; }
        public string end_cep { get; set; }
        public string end_bairro { get; set; }
        public int cid_id { get; set; }
        public string end_uf { get; set; }

        public Endereco() : this (null, null, "","","",0,"")
        {
        }

        public Endereco(int? end_id, Cidade Cidade, string end_logradouro, string end_cep, string end_bairro, int cid_id, string end_uf)
        {
            this.end_id = end_id;
            this.Cidade = Cidade;
            this.end_logradouro = end_logradouro;
            this.end_cep = end_cep;
            this.end_bairro = end_bairro;
            this.cid_id = cid_id;
            this.end_uf = end_uf;
        }

    
    }
}
