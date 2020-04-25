namespace GPF.Model
{
    public class Endereco
    {
        public int? end_id { get; set; }
        public Cidade cid_id { get; set; }
        public string end_logradouro { get; set; }
        public string end_cep { get; set; }
        public string bairro { get; set; }

        public Endereco() : this (null, null, "","","")
        {
        }

        public Endereco(int? end_id, Cidade cid_id, string end_logradouro, string end_cep, string bairro)
        {
            this.end_id = end_id;
            this.cid_id = cid_id;
            this.end_logradouro = end_logradouro;
            this.end_cep = end_cep;
            this.bairro = bairro;
        }

    
    }
}
