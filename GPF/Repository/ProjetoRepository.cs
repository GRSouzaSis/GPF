using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GPF.Repository
{
    public class ProjetoRepository
    {
        public AcessoHelper db = new AcessoHelper();

        public DataTable GetAll(string nome)
        {
            try
            {
                DataTable dt = new DataTable();
                string sql = "select pro_id, pro_nome from projeto where pro_ativo = 1";
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
