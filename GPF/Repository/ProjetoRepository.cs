using GPF.Cache;
using GPF.Model;
using System;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;

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

        public bool Cadastrar(Projeto projeto, Endereco endereco)
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

                    string sqlCliente = @"Insert Into projeto(end_id, pro_nome, pro_vlrtotal, pro_qtdelotes, pro_dtinicio, pro_ativo, pro_finalizado, pro_vlrPorLote, pro_vlrEntrada) 
values (@end_id, @pro_nome, @pro_vlrtotal, @pro_qtdelotes, @pro_dtinicio, @pro_ativo, @pro_finalizado, @pro_vlrPorLote, @pro_vlrEntrada)";

                    command.CommandText = sqlCliente; // insert cliente 
                    command.Parameters.AddWithValue("@end_id", IdInserido);
                    command.Parameters.AddWithValue("@pro_nome", projeto.pro_nome);
                    command.Parameters.AddWithValue("@pro_vlrtotal", projeto.pro_vlrtotal);
                    command.Parameters.AddWithValue("@pro_qtdelotes", projeto.qtdlotes);
                    command.Parameters.AddWithValue("@pro_dtinicio", projeto.dtinicio);
                    command.Parameters.AddWithValue("@pro_ativo", projeto.pro_ativo);
                    command.Parameters.AddWithValue("@pro_finalizado", projeto.pro_finalizado);
                    command.Parameters.AddWithValue("@pro_vlrPorLote", projeto.pro_vlrPorLote);
                    command.Parameters.AddWithValue("@pro_vlrEntrada", projeto.pro_vlrEntrada);                   
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
                        connection.Close();
                    }
                    catch (Exception ex2)
                    {

                        return false;
                    }
                }
                return false;
            }
        }

        public bool Alterar(Projeto projeto, Endereco endereco)//passar uma classe 
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

                    string sqlCliente = @"Update projeto set end_id = @end_id,
                                            pro_nome = @pro_nome,
                                            pro_vlrtotal = @pro_vlrtotal,
                                            pro_dtinicio = @pro_dtinicio,
                                            pro_ativo = @pro_ativo,
                                            pro_finalizado = @pro_finalizado,
                                            pro_vlrPorLote = @pro_vlrPorLote,
                                            pro_vlrEntrada =  @pro_vlrEntrada where pro_id = @pro_id";

                    command.CommandText = sqlCliente; // insert cliente 
                    command.Parameters.AddWithValue("@end_id", endereco.end_id);
                    command.Parameters.AddWithValue("@pro_nome", projeto.pro_nome);
                    command.Parameters.AddWithValue("@pro_vlrtotal", projeto.pro_vlrtotal);
                    command.Parameters.AddWithValue("@pro_dtinicio", projeto.dtinicio);
                    command.Parameters.AddWithValue("@pro_ativo", projeto.pro_ativo);
                    command.Parameters.AddWithValue("@pro_finalizado", projeto.pro_finalizado);
                    command.Parameters.AddWithValue("@pro_vlrPorLote", projeto.pro_vlrPorLote);
                    command.Parameters.AddWithValue("@pro_vlrEntrada", projeto.pro_vlrEntrada);
                    command.Parameters.AddWithValue("@pro_id", projeto.pro_id);
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

        public bool Excluir(int pro_id, int end_id)
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

                    string sqlCliente = "delete from projeto where pro_id = @pro_id";
                    command.CommandText = sqlCliente; // insert cliente 
                    command.Parameters.AddWithValue("@pro_id", pro_id);
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

        public bool ProcurarPorNome(string nome)
        {
            DbDataReader dr = null;
            try
            {
                string sql = "SELECT pro_nome FROM projeto WHERE pro_nome=@pro_nome";
                db.AddParameter("@pro_nome", nome);
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

        public DataView GetDataView()
        {

            try
            {
                // string sql = "select * from cliente";
                string sql = @"select TOP (50) p.pro_id, e.end_id,e.cid_id , p.pro_nome as Projeto, p.pro_vlrPorLote as VlrLote, p.pro_vlrEntrada as VlrEntrada,p.pro_dtinicio as Início, c.cid_nome as Cidade,  
e.end_uf as UF,e.end_logradouro as Logradouro, e.end_bairro as Bairro ,
CASE 
WHEN p.pro_ativo = 1 THEN 'SIM'
ELSE 'NÃO' END as Ativo, 
CASE 
WHEN p.pro_finalizado = 1 THEN 'SIM'
ELSE 'NÃO' END  as Finalizado
from projeto p
inner join endereco e on p.end_id = e.end_id
inner join cidade c on e.cid_id = c.cid_id";
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

        public DataView GetDataView(string nome)
        {

            try
            {
                string par = "'%" + nome + "%'";
                string sql = @"select TOP (50) p.pro_id, e.end_id,e.cid_id , p.pro_nome as Projeto, p.pro_vlrPorLote as VlrLote, p.pro_vlrEntrada as VlrEntrada,p.pro_dtinicio as Início, c.cid_nome as Cidade,  
e.end_uf as UF,e.end_logradouro as Logradouro, e.end_bairro as Bairro ,
CASE 
WHEN p.pro_ativo = 1 THEN 'SIM'
ELSE 'NÃO' END as Ativo, 
CASE 
WHEN p.pro_finalizado = 1 THEN 'SIM'
ELSE 'NÃO' END  as Finalizado
from projeto p
inner join endereco e on p.end_id = e.end_id
inner join cidade c on e.cid_id = c.cid_id
where (p.pro_nome like" + par + ")";

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
