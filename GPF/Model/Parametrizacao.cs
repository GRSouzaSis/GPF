using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GPF.Model
{
    public class Parametrizacao
    {
        public int? id { get; set; }
        public string nome { get; set; }
        public string cnpj { get; set; }
        public byte[] foto { get; set; }

        public Parametrizacao() : this(0, "", "", null)
        {
        }

        public Parametrizacao(int id, string nome, string cnpj, byte[] foto)
        {
            this.id = id;
            this.nome = nome;
            this.cnpj = cnpj;
            this.foto = foto;
        }
    }
}
