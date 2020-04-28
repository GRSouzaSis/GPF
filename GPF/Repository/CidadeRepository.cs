using System;
using System.Data;

namespace GPF.Repository
{
    public class CidadeRepository
    {
        public AcessoHelper db = new AcessoHelper();
        public DataTable GetAll(string uf)
        {
            try
            {
                DataTable dt = new DataTable();
                string sql = "SELECT cid_nome, cid_id FROM cidade where uf = "+"'"+ uf+"'";
                dt.Load(db.ExecuteReader(sql));
                return dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataTable GetCidade(int cidade)
        {
            try
            {
                DataTable dt = new DataTable();
                string sql = "SELECT cid_nome, cid_id FROM cidade where cid_id = " + cidade;
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
