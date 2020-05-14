using GPF.Cache;
using System;
using System.Data;
using System.Data.Common;

namespace GPF.Repository
{
    public class ProjetoRepository
    {
        public AcessoHelper db = new AcessoHelper();

        public bool carregarValoresProjeto(int pro_id)
        {
            DbDataReader reader;                       
            string sql = @"SELECT * FROM projeto where pro_id = "+pro_id;
            reader = db.ExecuteReader(sql);
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    ProjetoCache.pro_id = reader.GetInt32(0);
                    ProjetoCache.pro_vlrPorLote = reader.GetDecimal(8);
                    ProjetoCache.pro_vlrEntrada = reader.GetDecimal(9);                    
                }
                reader.Close();
                return true;
                
            }
            else
            {
                reader.Close();
                return false;
            }

        }

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
