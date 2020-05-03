using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GPF.Model
{
    public class Projeto
    {
        public int? pro_id { get; set; }
        public Endereco end_id { get; set; }
        public string pro_nome { get; set; }
        public double pro_vlrtotal { get; set; }
        public int qtdlotes { get; set; }
        public DateTime? dtinicio { get; set; }
        public int pro_ativo { get; set; }
        public int pro_finalizado { get; set; }

        public Projeto(): this(null,null,"",0,0,null,0,0)
        {
        }

        public Projeto(int? pro_id, Endereco end_id, string pro_nome, double pro_vlrtotal, int qtdlotes, DateTime? dtinicio, int pro_ativo, int pro_finalizado)
        {
            this.pro_id = pro_id;
            this.end_id = end_id;
            this.pro_nome = pro_nome;
            this.pro_vlrtotal = pro_vlrtotal;
            this.qtdlotes = qtdlotes;
            this.dtinicio = dtinicio;
            this.pro_ativo = pro_ativo;
            this.pro_finalizado = pro_finalizado;
        }
    }


}
