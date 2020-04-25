using GPF.Repository;

namespace GPF.Model
{
    public class Usuario
    {        
        public int? uso_id { get; set; }
        public Pessoa pes_id { get; set; }
        public string uso_login { get; set; }
        public string uso_senha { get; set; }
        public string uso_nome { get; set; }

        public Usuario() : this (null, null, "", "","") { }

        public Usuario(int? uso_id, Pessoa pes_id, string uso_login, string uso_senha, string uso_nome)
        {
            this.uso_id = uso_id;
            this.pes_id = pes_id;
            this.uso_login = uso_login;
            this.uso_senha = uso_senha;
            this.uso_nome = uso_nome;
        }

        public override string ToString()
        {
            return this.uso_nome;
        }
    }
}
