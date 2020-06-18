using GPF.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;

namespace GPF.Repository
{
    public class ReceberRepository
    {
        public AcessoHelper db = new AcessoHelper();
       // public Receber Receber { get; set; }
        Receber receber = new Receber();

        public bool Insert(IEnumerable<Receber> recebers)
        {
            using (SqlConnection connection = new SqlConnection(db.GetStringConnection()))
            {
                connection.Open();
                using (SqlTransaction transaction = connection.BeginTransaction())
                {
                    using (var command = new SqlCommand())
                    {
                        command.Connection = connection;
                        command.Transaction = transaction;
                        var sql = @"insert into receber (cli_id,pro_id,lot_id,parcela,total_parcela,dtemissao,dtvencimento,valor,valorpago,entrada,valorlote,valorentrada,descontoentrada,descontosaldo)
values (@cli_id,@pro_id,@lot_id,@parcela,@total_parcela,@dtemissao,@dtvencimento,@valor,@valorpago,@entrada,@valorlote,@valorentrada,@descontoentrada,@descontosaldo)";
                        command.CommandType = CommandType.Text;
                        command.CommandText = sql;
                        command.Parameters.Add("@cli_id", SqlDbType.Int);
                        command.Parameters.Add("@pro_id", SqlDbType.Int);
                        command.Parameters.Add("@lot_id", SqlDbType.Int);
                        command.Parameters.Add("@parcela", SqlDbType.Int);
                        command.Parameters.Add("@total_parcela", SqlDbType.Int);
                        command.Parameters.Add("@dtemissao", SqlDbType.DateTime);
                        command.Parameters.Add("@dtvencimento", SqlDbType.DateTime);
                        command.Parameters.Add("@valor", SqlDbType.Decimal);
                        command.Parameters.Add("@valorpago", SqlDbType.Decimal);
                        command.Parameters.Add("@entrada", SqlDbType.Int);
                        command.Parameters.Add("@valorlote", SqlDbType.Decimal);
                        command.Parameters.Add("@valorentrada", SqlDbType.Decimal);
                        command.Parameters.Add("@descontoentrada", SqlDbType.Decimal);
                        command.Parameters.Add("@descontosaldo", SqlDbType.Decimal);

                        try
                        {
                            foreach (var item in recebers)
                            {
                                command.Parameters["@cli_id"].Value = item.cli_id;
                                command.Parameters["@pro_id"].Value = item.pro_id;
                                command.Parameters["@lot_id"].Value = item.lot_id;
                                command.Parameters["@parcela"].Value = item.parcela;
                                command.Parameters["@total_parcela"].Value = item.total_parcela;
                                command.Parameters["@dtemissao"].Value = item.dtemissao;
                                command.Parameters["@dtvencimento"].Value = item.dtvencimento;
                                command.Parameters["@valor"].Value = item.valor;
                                command.Parameters["@valorpago"].Value = item.valorpago;
                                command.Parameters["@entrada"].Value = item.entrada;
                                command.Parameters["@valorlote"].Value = item.valorLote;
                                command.Parameters["@valorentrada"].Value = item.valorEntrada;
                                command.Parameters["@descontoentrada"].Value = item.descontoEntrada;
                                command.Parameters["@descontosaldo"].Value = item.descontoSaldo;
                                command.ExecuteNonQuery();
                            }
                            transaction.Commit();
                            return true;
                        }
                        catch (Exception ex)
                        {
                            transaction.Rollback();
                            connection.Close();
                            return false;
                        }
                    }
                }

            }
        }

        public bool BaixaRecebimento(Receber receber, Cliente cliente)
        {

            using (SqlConnection connection = new SqlConnection(db.GetStringConnection()))
            {
                connection.Open();

                SqlCommand command = connection.CreateCommand();
                SqlTransaction transaction;
                transaction = connection.BeginTransaction("SampleTransaction");
                command.Connection = connection;
                command.Transaction = transaction;

                string updateReceber = @"Update receber set valorpago =@valorpago where id_receber =@id_receber";

                string insertRecebido = @"Insert Into recebido(cli_id,valor,desconto,acrescimo,dtpagamento) 
OUTPUT INSERTED.id_recebido
values (@cli_id,@valor1,@desconto1,@acrescimo1,@dtpagamento)";

                string insertReceber_recebido = @"Insert Into receber_recebido(id_receber, id_recebido, valor, desconto, acrescimo) 
values(@idreceber,@id_recebido,@valor,@desconto,@acrescimo)";

                try
                {
                    command.CommandText = updateReceber;  //update receber
                    command.Parameters.AddWithValue("@valorpago", receber.valorpago);
                    command.Parameters.AddWithValue("@id_receber", receber.id_receber);
                    command.ExecuteNonQuery();

                    command.CommandText = insertRecebido;
                    command.Parameters.AddWithValue("@cli_id", cliente.cli_id);
                    command.Parameters.AddWithValue("@valor1", receber.valorpago);
                    command.Parameters.AddWithValue("@desconto1", 0);
                    command.Parameters.AddWithValue("@acrescimo1", 0);
                    command.Parameters.AddWithValue("@dtpagamento", DateTime.Now);
                    //command.ExecuteNonQuery();
                    var IdInserido = Convert.ToInt32(command.ExecuteScalar());

                    command.CommandText = insertReceber_recebido;  //update receber
                    command.Parameters.AddWithValue("@idreceber", receber.id_receber);
                    command.Parameters.AddWithValue("@id_recebido", IdInserido);
                    command.Parameters.AddWithValue("@valor", receber.valorpago);
                    command.Parameters.AddWithValue("@desconto", 0);
                    command.Parameters.AddWithValue("@acrescimo", 0);                   
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

        public bool EstornarRecebimento(Receber receber)
        {
            int id_recebido=0;
            using (SqlConnection connection = new SqlConnection(db.GetStringConnection()))
            {
                connection.Open();

                SqlCommand command = connection.CreateCommand();
                SqlTransaction transaction;
                transaction = connection.BeginTransaction("SampleTransaction");
                command.Connection = connection;
                command.Transaction = transaction;

                string updateReceber = @"Update receber set valorpago =@valorpago where id_receber =@id_receber";

                string buscaId = @"select id_recebido from receber_recebido where id_recebido in (select id_recebido 
from receber_recebido
where id_receber =@idreceber)";

                string deleteReceber_recebido = @"delete from receber_recebido where id_receber=@id_recebe";

                string deleterecebido = @"delete from recebido where id_recebido=@id_recebido";

                try
                {
                    command.CommandText = updateReceber;  //update receber
                    command.Parameters.AddWithValue("@valorpago", 0);
                    command.Parameters.AddWithValue("@id_receber", receber.id_receber);
                    command.ExecuteNonQuery();

                    command.CommandText = buscaId;
                    command.Parameters.AddWithValue("@idreceber", receber.id_receber);
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            id_recebido = reader.GetInt32(0);
                        }
                    }
                    reader.Close();

                    command.CommandText = deleteReceber_recebido;  //delete Receber_recebido
                    command.Parameters.AddWithValue("@id_recebe", receber.id_receber);
                    command.ExecuteNonQuery();

                    command.CommandText = deleterecebido;  //delete receber
                    command.Parameters.AddWithValue("@id_recebido", id_recebido);
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

        public bool ExcluirParcelas(int cli_id, int lot_id, int pro_id, int entrada)
        {
            try
            {
                string sql = "Delete From receber where cli_id=@cli_id and pro_id=@pro_id and lot_id=@lot_id and entrada=@entrada";
                db.AddParameter("@cli_id", cli_id);
                db.AddParameter("@pro_id", pro_id);
                db.AddParameter("@lot_id", lot_id);
                db.AddParameter("@entrada", entrada);
                db.ExecuteNonQuery(sql);
                return true;
            }
            catch (Exception ex)
            {
                return false;
                throw ex;
            }
        }

        public bool BuscaEntrada(int cli_id, int lot_id, int pro_id, int entrada)
        {
            DbDataReader dr = null;
            try
            {
                string sql = "SELECT entrada FROM receber WHERE cli_id=@cli_id and lot_id=@lot_id and pro_id=@pro_id and entrada =@entrada";
                db.AddParameter("@cli_id", cli_id);
                db.AddParameter("@lot_id", lot_id);
                db.AddParameter("@pro_id", pro_id);
                db.AddParameter("@entrada", entrada);
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

        public bool Gerados(int lot_id, int entrada)
        {
            DbDataReader dr = null;
            try
            {
                string sql = @"select entrada, r.lot_id
from receber r
inner join lote l on l.lot_id = r.lot_id
where entrada = "+entrada + "and r.lot_id ="+ lot_id 
+ "intersect " +
"select entrada, r.lot_id " +
"from receber r " +
"inner join lote l on l.lot_id = r.lot_id " +
"where entrada = "+ entrada + "and r.lot_id =" + lot_id;
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

        public Receber Valor(int cli_id, int lot_id, int pro_id, int entrada)
        {
            using (SqlConnection connection = new SqlConnection(db.GetStringConnection()))
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = @"select total_parcela, dtvencimento, valorentrada, valorlote, descontoentrada, descontosaldo
from receber
where cli_id =@cli_id and lot_id =@lot_id and pro_id =@pro_id and entrada =@entrada";

                    command.Parameters.AddWithValue("@cli_id", cli_id);
                    command.Parameters.AddWithValue("@lot_id", lot_id);
                    command.Parameters.AddWithValue("@pro_id", pro_id);
                    command.Parameters.AddWithValue("@entrada", entrada);
                    command.CommandType = CommandType.Text;
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        reader.Read();
                        receber.total_parcela = reader.GetInt32(0);
                        receber.dtvencimento = reader.GetDateTime(1);
                        receber.valorEntrada = Convert.ToDouble(reader.GetDecimal(2));
                        receber.valorLote = Convert.ToDouble(reader.GetDecimal(3));
                        receber.descontoEntrada = Convert.ToDouble(reader.GetDecimal(4));
                        receber.descontoSaldo = Convert.ToDouble(reader.GetDecimal(5));
                        return receber;
                    }
                    return null;
                }
            }

        }       

        public int ClienteGerados(int cli_id, int entrada)
        {
            using (SqlConnection connection = new SqlConnection(db.GetStringConnection()))
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = @"select Count(*) FROM (
	select r.lot_id
	from receber r
	inner join lote l on l.lot_id = r.lot_id
	where entrada = @entrada and r.cli_id =@cli_id
    intersect select r.lot_id
    from receber r
    inner join lote l on l.lot_id = r.lot_id
     where entrada =@entrada and r.cli_id =@cli_id	)Tabelateste";
                    command.CommandType = CommandType.Text;
                    command.Parameters.AddWithValue("@entrada", entrada);
                    command.Parameters.AddWithValue("@cli_id", cli_id);
                    var reader = command.ExecuteScalar();
                    return Convert.ToInt32(reader);
                }
            }
        }       

        public bool TemPagamento(int lot_id, int entrada)
        {
            using (SqlConnection connection = new SqlConnection(db.GetStringConnection()))
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = @"select valorpago from receber where valorpago <> 0 and entrada =@entrada and lot_id =@lot_id ";
                    command.CommandType = CommandType.Text;
                    command.Parameters.AddWithValue("@entrada", entrada);
                    command.Parameters.AddWithValue("@lot_id", lot_id);
                    var reader = command.ExecuteScalar();
                    var count = Convert.ToInt32(reader);
                    if (count > 0)
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

        public DataTable GetRecebimentos(int pro_id)
        {
            try
            {
                DataTable dt = new DataTable();
                // string sql = "SELECT cli_id, cli_nome FROM cliente";
                string sql = @"SELECT id_receber as CodRec, parcela as Parcela, valor as Valor, dtvencimento as Vencimentos, entrada
                               FROM receber
                               where pro_id =@pro_id";
                db.AddParameter("@pro_id", pro_id);
                dt.Load(db.ExecuteReader(sql));
                return dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataTable FiltroRecebimentos(string onde)
        {
            try
            {
                DataTable dt = new DataTable();
                // string sql = "SELECT cli_id, cli_nome FROM cliente";
                string sql = @"SELECT r.id_receber as CodRec,r.lot_id as CodLote, r.pro_id, r.cli_id, r.lot_id, c.cli_nome + ' ' + c.cli_sobrenome  as Cliente  ,
parcela as Parcela, valor as Valor, dtvencimento as Vencimentos,
CASE 
WHEN entrada = 1 THEN 'Entrada'
ELSE 'Parcela' END AS Tipo
FROM receber r
inner join cliente c on c.cli_id = r.cli_id" + onde;
                
                dt.Load(db.ExecuteReader(sql));
                return dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataTable GetRecebimentos(string onde, int cli_id)
        {
            try
            {
                DataTable dt = new DataTable();
                // string sql = "SELECT cli_id, cli_nome FROM cliente";
                string sql = @"SELECT r.id_receber as CodRec,r.lot_id as CodLote, r.pro_id, r.cli_id, r.lot_id, c.cli_nome + ' ' + c.cli_sobrenome  as Cliente  ,
parcela as Parcela, valor as Valor, dtvencimento as Vencimentos,
CASE 
WHEN entrada = 1 THEN 'Entrada'
ELSE 'Parcela' END AS Tipo
FROM receber r
inner join cliente c on c.cli_id = r.cli_id" + onde + " and r.cli_id =@cliid";
                db.AddParameter("@cliid", cli_id);
                dt.Load(db.ExecuteReader(sql));
                return dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataTable FiltroRecebidos(string onde)
        {
            try
            {
                DataTable dt = new DataTable();
                // string sql = "SELECT cli_id, cli_nome FROM cliente";
                string sql = @"SELECT r.id_receber as CodRec,r.lot_id as CodLote, r.pro_id, r.cli_id, r.lot_id, c.cli_nome + ' ' + c.cli_sobrenome  as Cliente  ,
parcela as Parcela, r.valor as Valor, 
CASE 
WHEN entrada = 1 THEN 'Entrada'
ELSE 'Parcela' END AS Tipo,dtvencimento as Vencimentos, re.dtpagamento as Pagamento
FROM receber_recebido rr
inner join recebido re on re.id_recebido = rr.id_recebido
inner join receber r on r.id_receber = rr.id_receber
inner join cliente c on c.cli_id = r.cli_id" + onde;

                dt.Load(db.ExecuteReader(sql));
                return dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataTable FiltroRecebidos(string onde, int cli_id)
        {
            try
            {
                DataTable dt = new DataTable();
                // string sql = "SELECT cli_id, cli_nome FROM cliente";
                string sql = @"SELECT r.id_receber as CodRec,r.lot_id as CodLote, r.pro_id, r.cli_id, r.lot_id, c.cli_nome + ' ' + c.cli_sobrenome  as Cliente  ,
parcela as Parcela, r.valor as Valor, 
CASE 
WHEN entrada = 1 THEN 'Entrada'
ELSE 'Parcela' END AS Tipo,dtvencimento as Vencimento, re.dtpagamento as Pagamento
FROM receber_recebido rr
inner join recebido re on re.id_recebido = rr.id_recebido
inner join receber r on r.id_receber = rr.id_receber
inner join cliente c on c.cli_id = r.cli_id" + onde + " and r.cli_id =@cliid";
                db.AddParameter("@cliid", cli_id);
                dt.Load(db.ExecuteReader(sql));
                return dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }



        public DataTable GetRecebimentos(int pro_id,int cli_id, int lot_id)
        {
            try
            {
                DataTable dt = new DataTable();
                // string sql = "SELECT cli_id, cli_nome FROM cliente";
                string sql = @"SELECT id_receber as CodRec, parcela as Parcela, valor as Valor, dtvencimento as Vencimentos, entrada 
                               FROM receber
                               where pro_id = " + pro_id + "and cli_id = "+cli_id+ "and lot_id ="+lot_id;
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
