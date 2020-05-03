using GPF.Cache;
using GPF.Model;
using System;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;

namespace GPF.Repository
{
    public class UsuarioRepository
    {
        public AcessoHelper db = new AcessoHelper();

        public void Cadastrar(Usuario usuario)//passar uma classe
        {
            try
            {
                string sql = "Insert Into usuario(uso_login, uso_senha, uso_nome, uso_ativo,fun_id) " +
                    "values (@uso_login,@uso_senha,@uso_nome, @uso_ativo, @fun_id)";
                db.AddParameter("@uso_login", usuario.uso_login);
                db.AddParameter("@uso_senha", usuario.uso_senha);
                db.AddParameter("@uso_nome", usuario.uso_nome);
                db.AddParameter("@uso_ativo", usuario.uso_ativo);
                db.AddParameter("@fun_id", usuario.funcionario);
                db.ExecuteNonQuery(sql);

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void alterar(Usuario usuario)//passar uma classe 
        {
            try
            {
                string sql = @"Update usuario set uso_nome=@uso_nome, uso_ativo=@uso_ativo, uso_login=@uso_login, uso_senha=@uso_senha, fun_id=@fun_id
                                where 
                                uso_id = @uso_id";
                db.AddParameter("@uso_login", usuario.uso_login);
                db.AddParameter("@uso_senha", usuario.uso_senha);
                db.AddParameter("@uso_nome", usuario.uso_nome);
                db.AddParameter("@uso_ativo", usuario.uso_ativo);
                db.AddParameter("@fun_id", usuario.funcionario);
                db.AddParameter("@uso_id", usuario.uso_id);
                db.ExecuteNonQuery(sql);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void excluir(int uso_id)
        {
            try
            {
                string sql = "Delete From usuario where uso_id=@uso_id";
                db.AddParameter("@uso_id", uso_id);
                db.ExecuteNonQuery(sql);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public bool ProcurarLogin(string login)
        {
            DbDataReader dr = null;
            try
            {
                string sql = "SELECT uso_login FROM usuario WHERE uso_login=@uso_login";
                db.AddParameter("@uso_login", login);
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

        public DataView GetDataView(string nome)
        {

            try
            {
                string par = "'%" + nome + "%'";
                string sql = @"select * from usuario where uso_nome like" + par;

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
                string sql = "select top (50) uso_id, fun_id,uso_senha, uso_login as Login,  uso_nome as Usuário, uso_ativo as Ativo  from usuario";
               // string sql = @"select TOP (50) * from usuario c
               //                 inner join endereco e on c.end_id = e.end_id";
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

        public bool Login(string login, string senha)
        {
            using (SqlConnection connection = new SqlConnection(db.GetStringConnection()))
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = @"SELECT *
                                            FROM usuario
                                            WHERE
                                                uso_login = @login COLLATE SQL_Latin1_General_CP1_CS_AS
                                                AND uso_senha = @senha COLLATE SQL_Latin1_General_CP1_CS_AS
                                                AND uso_login = @login
                                                AND uso_senha = @senha";


                    command.Parameters.AddWithValue("@login", login);
                    command.Parameters.AddWithValue("@senha", senha);
                    command.CommandType = CommandType.Text;   
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            UsuarioLoginCache.uso_id = reader.GetInt32(0);
                            UsuarioLoginCache.uso_login = reader.GetString(2);
                            UsuarioLoginCache.uso_nome = reader.GetString(4);
                        }
                        return true;
                    }
                    else
                        return false;

                }
            }
           
        }

        public bool VerificaParametizacao()
        {
            using (SqlConnection connection = new SqlConnection(db.GetStringConnection()))
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = @"SELECT count(*)
                                            FROM padrao";
                    command.CommandType = CommandType.Text;
                    var reader = command.ExecuteScalar();
                    if (Convert.ToInt32(reader) > 0)
                    {                       
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }            
        }      


    }
}

