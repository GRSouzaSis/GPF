namespace GPF.Model
{
    public class Uf
    {
        public string uf { get; set; }
        public string uf_nome { get; set; }

        public Uf() : this (null,"")
        {
        }

        public Uf(string uf, string uf_nome)
        {
            this.uf = uf;
            this.uf_nome = uf_nome;
        }

        public override string ToString()
        {
            return uf;
        }
    }
}
