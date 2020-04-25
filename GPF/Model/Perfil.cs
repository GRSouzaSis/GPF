using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GPF.Model
{
    public class Perfil
    {
        public int? per_id { get; set; }
        public string per_nome { get; set; }
        public int per_ativo { get; set; }

        public Perfil() : this (null, "",0)
        {
        }

        public Perfil(int? per_id, string per_nome, int per_ativo)
        {
            this.per_id = per_id;
            this.per_nome = per_nome;
            this.per_ativo = per_ativo;
        }
    }
}
