using GPF.Cache;
using System;
using System.Data;
using System.Data.SqlClient;

namespace GPF.Repository
{
    public class UsuarioRepository : BaseRepository
    {
        private string selectAll;
        private string insert;
        private string update;
        private string delete;

        public UsuarioRepository()
        {
            selectAll = "select * from usuario";

            insert = @"insert into usuario 
                        values(@uso_nome,
                               @uso_senha,
                               @uso_login,
                               @pes_id)";

            update = @"update usuario set 
                        uso_nome=@uso_nome, 
                        uso_senha=@uso_senha, 
                        uso_login=@uso_login,
                        pes_id=@pes_id
                        where uso_id=@uso_id";

            delete = "delete from usuario where uso_id=@uso_id";
        }

        public bool Login(string login, string senha)
        {
            using (var connection = GetConnection())
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
            using (var connection = GetConnection())
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

