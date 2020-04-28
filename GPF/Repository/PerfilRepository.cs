using GPF.Model;
using System;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;

namespace GPF.Repository
{
    public class PerfilRepository
    {
        public AcessoHelper db = new AcessoHelper();

        public void cadastraPerfil(Perfil perfil)//passar uma classe
        {
            try
            {
                string sql = "Insert Into perfil(per_nome,per_ativo) values (@per_nome,@per_ativo)";
                db.AddParameter("@per_nome", perfil.per_nome);
                db.AddParameter("@per_ativo", perfil.per_ativo);
                db.ExecuteNonQuery(sql);
                
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void alterarPerfil(Perfil perfil)//passar uma classe 
        {
            try
            {
                string sql = @"Update perfil set per_nome=@per_nome, per_ativo=@per_ativo where 
                                per_id = @per_id";
                db.AddParameter("@per_nome", perfil.per_nome);
                db.AddParameter("@per_ativo", perfil.per_ativo);                
                db.AddParameter("@per_id", perfil.per_id);
                db.ExecuteNonQuery(sql);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void excluirPerfil(int per_id)
        {
            try
            {
                string sql = "Delete From perfil where per_id=@per_id";
                db.AddParameter("@per_id", per_id);
                db.ExecuteNonQuery(sql);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DbDataReader Procurar(int usuarioid)
        {
            try
            {
                string sql = "SELECT * FROM usuarios WHERE usuarioid=@usuarioid";
                db.AddParameter("@usuarioid", usuarioid);
                return db.ExecuteReader(sql);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool ProcurarPorNome(string nome)
        {
            DbDataReader dr = null;
            try
            {
                string sql = "SELECT per_nome FROM perfil WHERE per_nome=@nome";
                db.AddParameter("@nome", nome);
                dr = db.ExecuteReader(sql);
                if (dr.HasRows)
                    return true;
                else
                    return false;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                dr.Close();
            }
        }

        public DbDataReader GetAll()
        {
            try
            {
                string sql = "SELECT * FROM perfil";
                return db.ExecuteReader(sql);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataView GetDataView(string nome)
        {

            try
            {                
                string par = "'%" + nome + "%'";
                string sql = @"select * from perfil where per_nome like" + par;

                SqlDataAdapter da = new SqlDataAdapter(sql, db.GetStringConnection());
                DataTable dt = new DataTable();
                da.Fill(dt);
               
                DataView dv = new DataView(dt);
                dv.Sort = dt.Columns[0].ColumnName;
                return dv;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public DataView GetDataView()
        {
           
            try
            {
                string sql = "select * from perfil";   
                SqlDataAdapter da = new SqlDataAdapter(sql, db.GetStringConnection());
                DataTable dt = new DataTable();
                da.Fill(dt);
                
                DataView dv = new DataView(dt);
                dv.Sort = dt.Columns[0].ColumnName;
                return dv;
            }
            catch (Exception ex)
            {
                throw ex;
            }            
           
        }

    }
}
