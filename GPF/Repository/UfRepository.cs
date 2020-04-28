using System;
using System.Data;

namespace GPF.Repository
{
    public class UfRepository
    {
        public AcessoHelper db = new AcessoHelper();
        public DataTable GetAll(string nome)
        {
            try
            {
                DataTable dt = new DataTable();
                string sql = "SELECT uf FROM uf";
                dt.Load( db.ExecuteReader(sql));
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
