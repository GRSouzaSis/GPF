using GPF.Model;
using System;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;

namespace GPF.Repository
{
    public class ClienteRepository
    {
        public AcessoHelper db = new AcessoHelper();

        public bool cadastrar(Cliente cliente, Endereco endereco)
        {
           
            using (SqlConnection connection = new SqlConnection(db.GetStringConnection()))
            {
                connection.Open();

                SqlCommand command = connection.CreateCommand();
                SqlTransaction transaction;
                transaction = connection.BeginTransaction("SampleTransaction");
                command.Connection = connection;
                command.Transaction = transaction;
              
                string sqlEndereco = @"Insert Into endereco(end_logradouro,end_bairro,cid_id,end_uf) 
                                     OUTPUT INSERTED.end_id
                                    values (@end_logradouro,@end_bairro,@cid_id,@end_uf)";
                try
                {             
                    
                    command.CommandText = sqlEndereco;  //insert endereço
                    command.Parameters.AddWithValue("@end_logradouro", endereco.end_logradouro);
                    command.Parameters.AddWithValue("@end_bairro", endereco.end_bairro);
                    command.Parameters.AddWithValue("@cid_id", endereco.cid_id);
                    command.Parameters.AddWithValue("@end_uf", endereco.end_uf);
                    //command.ExecuteNonQuery();
                    var IdInserido = Convert.ToInt32(command.ExecuteScalar());

                    string sqlCliente = @"Insert Into cliente(end_id,cli_nome,cli_sobrenome,cli_cpf,cli_casado,cli_conjuge,
                                                              cli_conjuge_cpf, cli_dtnasc,cli_telefone1,cli_telefone2) 
                                                      values (@end_id, @cli_nome, @cli_sobrenome, @cli_cpf, @cli_casado, @cli_conjuge,
                                                              @cli_conjuge_cpf,@cli_dtnasc, @cli_telefone1, @cli_telefone2)";
                    command.CommandText = sqlCliente; // insert cliente 
                    command.Parameters.AddWithValue("@end_id", IdInserido);
                    command.Parameters.AddWithValue("@cli_nome", cliente.cli_nome);
                    command.Parameters.AddWithValue("@cli_sobrenome", cliente.cli_sobrenome);
                    command.Parameters.AddWithValue("@cli_cpf", cliente.cli_cpf);
                    command.Parameters.AddWithValue("@cli_casado", cliente.cli_casado);
                    command.Parameters.AddWithValue("@cli_conjuge", cliente.cli_conjuge);
                    command.Parameters.AddWithValue("@cli_conjuge_cpf", cliente.cli_conjuge_cpf);
                    command.Parameters.AddWithValue("@cli_dtnasc", cliente.cli_dtnasc);
                    command.Parameters.AddWithValue("@cli_telefone1", cliente.cli_telefone1);
                    command.Parameters.AddWithValue("@cli_telefone2", cliente.cli_telefone2);
                    command.ExecuteNonQuery();

                    // Se deu certo Commit.
                    transaction.Commit();
                    return true;
                }
                catch (Exception ex)
                {                   
                    
                    // roll back na transaction.
                    try
                    {
                        transaction.Rollback();
                    }
                    catch (Exception ex2)
                    {                        
                     
                        return false;
                    }
                }
                return false;
            }
        }       

        public bool alterar(Cliente cliente, Endereco endereco)//passar uma classe 
        {
            var endid = endereco.end_id;
            using (SqlConnection connection = new SqlConnection(db.GetStringConnection()))
            {
                connection.Open();

                SqlCommand command = connection.CreateCommand();
                SqlTransaction transaction;
                transaction = connection.BeginTransaction("SampleTransaction");
                command.Connection = connection;
                command.Transaction = transaction;
          
                string sqlEndereco = @"Update endereco set end_logradouro = @end_logradouro ,end_bairro = @end_bairro ,cid_id = @cid_id,end_uf = @end_uf 
                                    where end_id = @endid";
                try
                {

                    string sqlCliente = @"Update cliente set end_id = @end_id,
                                            cli_nome = @cli_nome,
                                            cli_sobrenome = @cli_sobrenome,
                                            cli_cpf = @cli_cpf,
                                            cli_casado = @cli_casado,
                                            cli_conjuge = @cli_conjuge,
                                            cli_conjuge_cpf =  @cli_conjuge_cpf,
                                            cli_dtnasc = @cli_dtnasc,
                                            cli_telefone1 = @cli_telefone1,
                                            cli_telefone2 = @cli_telefone2 where cli_id = @cli_id";

                    command.CommandText = sqlCliente; // insert cliente 
                    command.Parameters.AddWithValue("@end_id", endereco.end_id);
                    command.Parameters.AddWithValue("@cli_nome", cliente.cli_nome);
                    command.Parameters.AddWithValue("@cli_sobrenome", cliente.cli_sobrenome);
                    command.Parameters.AddWithValue("@cli_cpf", cliente.cli_cpf);
                    command.Parameters.AddWithValue("@cli_casado", cliente.cli_casado);
                    command.Parameters.AddWithValue("@cli_conjuge", cliente.cli_conjuge);
                    command.Parameters.AddWithValue("@cli_conjuge_cpf", cliente.cli_conjuge_cpf);
                    command.Parameters.AddWithValue("@cli_dtnasc", cliente.cli_dtnasc);
                    command.Parameters.AddWithValue("@cli_telefone1", cliente.cli_telefone1);
                    command.Parameters.AddWithValue("@cli_telefone2", cliente.cli_telefone2);
                    command.Parameters.AddWithValue("@cli_id", cliente.cli_id);
                    command.ExecuteNonQuery();
                   
                    command.CommandText = sqlEndereco;  //insert endereço
                    command.Parameters.AddWithValue("@end_logradouro", endereco.end_logradouro);
                    command.Parameters.AddWithValue("@end_bairro", endereco.end_bairro);
                    command.Parameters.AddWithValue("@cid_id", endereco.cid_id);
                    command.Parameters.AddWithValue("@end_uf", endereco.end_uf);
                    command.Parameters.AddWithValue("@endid", endid);
                    command.ExecuteNonQuery();
                    //var IdInserido = Convert.ToInt32(command.ExecuteScalar());                   

                    // Se deu certo Commit.
                    transaction.Commit();
                    return true;
                }
                catch (Exception ex)
                {

                    // roll back na transaction.
                    try
                    {
                        transaction.Rollback();
                    }
                    catch (Exception ex2)
                    {

                        return false;
                    }
                }
                return false;
            }
          
        }

        public bool excluir(int cli_id, int end_id)
        {

            using (SqlConnection connection = new SqlConnection(db.GetStringConnection()))
            {
                connection.Open();

                SqlCommand command = connection.CreateCommand();
                SqlTransaction transaction;
                transaction = connection.BeginTransaction("SampleTransaction");
                command.Connection = connection;
                command.Transaction = transaction;

                string sqlEndereco = "delete from endereco where end_id =@end_id";
                try
                {

                    string sqlCliente = "delete from cliente where cli_id = @cli_id";
                    command.CommandText = sqlCliente; // insert cliente 
                    command.Parameters.AddWithValue("@cli_id", cli_id);
                    command.ExecuteNonQuery();

                    command.CommandText = sqlEndereco;  //insert endereço                   
                    command.Parameters.AddWithValue("@end_id", end_id);
                    command.ExecuteNonQuery();
                    //var IdInserido = Convert.ToInt32(command.ExecuteScalar());                    

                    // Se deu certo Commit.
                    transaction.Commit();
                    return true;
                }
                catch (Exception ex)
                {

                    // roll back na transaction.
                    try
                    {
                        transaction.Rollback();
                    }
                    catch (Exception ex2)
                    {

                        return false;
                    }
                }
                return false;
            }
            
        }

        public DataView GetDataView(string nome)
        {

            try
            {
                string par = "'%" + nome + "%'";
                string sql = @"select TOP (50) * from cliente c
                                inner join endereco e on e.end_id = c.end_id
                                where (cli_nome like" + par+") or (cli_sobrenome like" + par+ ") or (cli_cpf like" + par + ")" ;

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
               // string sql = "select * from cliente";
                string sql = @"select TOP (50) * from cliente c
                                inner join endereco e on c.end_id = e.end_id";
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

        public bool ProcurarPorCPF(string cpf)
        {
            DbDataReader dr = null;
            try
            {
                string sql = "SELECT cli_cpf FROM cliente WHERE cli_cpf=@cli_cpf";
                db.AddParameter("@cli_cpf", cpf);
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

        public DataTable GetAll(string nome)
        {
            try
            {
                DataTable dt = new DataTable();
               // string sql = "SELECT cli_id, cli_nome FROM cliente";
                string sql = @"select cli_nome + ' ' + cli_sobrenome + ' ' + cli_cpf as cli, cli_id 
                                from cliente 
                                order by cli_nome";
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

