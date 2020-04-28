using GPF.Repository;

namespace GPF.Model
{
    public class Usuario
    {        
        public int? uso_id { get; set; }       
        public string uso_login { get; set; }
        public string uso_senha { get; set; }
        public string uso_nome { get; set; }
        public int uso_ativo { get; set; }

        public Usuario() : this (null, "", "","",0) { }

        public Usuario(int? uso_id, string uso_login, string uso_senha, string uso_nome, int uso_ativo)
        {
            this.uso_id = uso_id;
            this.uso_login = uso_login;
            this.uso_senha = uso_senha;
            this.uso_nome = uso_nome;
            this.uso_ativo = uso_ativo;
        }

        public override string ToString()
        {
            return this.uso_nome;
        }
    }
}
