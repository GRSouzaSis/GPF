using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GPF.Repository
{
    public class FuncionarioRepository
    {
        public AcessoHelper db = new AcessoHelper();
        public DataTable GetAll(string nome)
        {
            try
            {
                DataTable dt = new DataTable();
                string sql = "SELECT fun_id, fun_nome FROM funcionario";
                dt.Load(db.ExecuteReader(sql));
                return dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataTable Get(string nome)
        {
            try
            {
                DataTable dt = new DataTable();
                string sql = "SELECT uf FROM uf where uf = " + "'" + nome + "'";
                dt.Load(db.ExecuteReader(sql));
                return dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
