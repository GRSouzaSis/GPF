using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GPF.Model
{
    public class Cliente
    {
        public int? cli_id { get; set; }
        public Endereco end_id { get; set; }
        public string cli_nome { get; set; }
        public string cli_sobrenome { get; set; }
        public string cli_cpf { get; set; }
        public int cli_casado { get; set; }
        public string cli_conjuge { get; set; }
        public string cli_conjuge_cpf { get; set; }
        public DateTime? cli_dtnasc { get; set; }
        public string cli_telefone1 { get; set; }
        public string cli_telefone2 { get; set; }

        public Cliente() : this (null, null, "","","",0,"","",null,"","")
        {
        }

        public Cliente(int? cli_id, Endereco end_id, string cli_nome, string cli_sobrenome, string cli_cpf, 
            int cli_casado, string cli_conjuge, string cli_conjuge_cpf,
            DateTime? cli_dtnasc, string cli_telefone1, string cli_telefone2)
        {
            this.cli_id = cli_id;
            this.end_id = end_id;
            this.cli_nome = cli_nome;
            this.cli_sobrenome = cli_sobrenome;
            this.cli_cpf = cli_cpf;
            this.cli_casado = cli_casado;
            this.cli_conjuge = cli_conjuge;
            this.cli_conjuge_cpf = cli_conjuge_cpf;
            this.cli_dtnasc = cli_dtnasc;
            this.cli_telefone1 = cli_telefone1;
            this.cli_telefone2 = cli_telefone2;
        }
    }
}
