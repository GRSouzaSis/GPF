using GPF.Cache;
using GPF.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GPF.Repository
{
    public class ParametrizacaoRepository
    {
        public AcessoHelper db = new AcessoHelper();

        public void cadastrar(Parametrizacao parametrizacao)//passar uma classe
        {
            try
            {
                string sql = "Insert Into padrao(nome,cnpj,logo) values (@nome,@cnpj,@logo)";
                db.AddParameter("@nome", parametrizacao.nome);
                db.AddParameter("@cnpj", parametrizacao.cnpj);
                db.AddParameter("@logo", parametrizacao.foto);
                db.ExecuteNonQuery(sql);

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void alterar(Parametrizacao parametrizacao)//passar uma classe 
        {
            try
            {
                string sql = @"Update padrao set nome=@nome, cnpj=@cnpj, logo=@logo where 
                                id = @id";
                db.AddParameter("@nome", parametrizacao.nome);
                db.AddParameter("@cnpj", parametrizacao.cnpj);
                db.AddParameter("@logo", parametrizacao.foto);
                db.AddParameter("@id", ParametrizacaoCache.id);
                db.ExecuteNonQuery(sql);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DbDataReader GetParametrizacao()
        {
            try
            {
                string sql = "SELECT * FROM padrao";
                return db.ExecuteReader(sql);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool VerificaParametizacao()
        {
            
            string sql = @"SELECT count(*) FROM padrao";
            var reader = db.ExecuteScalar(sql);//.ExecuteNonQuery(sql);//ExecuteScalar(sql);
            if (Convert.ToInt32(reader) > 0)
            {
                return true;
            }
            else
            {
                return false;
            }


        }

        public bool carregarParametrizacao()
        {
            DbDataReader reader = null;
            string sql = @"SELECT * FROM padrao";
            reader = db.ExecuteReader(sql);
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    ParametrizacaoCache.id = reader.GetInt32(0);
                    ParametrizacaoCache.nome = reader.GetString(1);
                    ParametrizacaoCache.cnpj = reader.GetString(2);
                    ParametrizacaoCache.logo = (byte[])(reader[3]);
                }
                return true;
            }
            else
            {
                return false;
            }            
            
        }

    }
}
