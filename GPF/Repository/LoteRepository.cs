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
    public class LoteRepository
    {
        public AcessoHelper db = new AcessoHelper();       

        public void Cadastrar(Lote lote, Projeto projeto, Cliente cliente)//passar uma classe
        {
            try
            {
                string sql = "Insert Into lote(lot_numero, lot_quadra, lot_matricula, pro_id, cli_id) " +
                    "values (@lot_numero,@lot_quadra,@lot_matricula, @pro_id, @cli_id)";
                db.AddParameter("@lot_numero", lote.lot_numero);
                db.AddParameter("@lot_quadra", lote.lot_quadra);
                db.AddParameter("@lot_matricula", lote.lot_matricula);
                db.AddParameter("@pro_id", projeto.pro_id);
                db.AddParameter("@cli_id", cliente.cli_id);
                db.ExecuteNonQuery(sql);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool CadastrarValoresLote(Lote lote, Projeto projeto, Cliente cliente, Orcamento orcamento)//passar uma classe
        {
            using (SqlConnection connection = new SqlConnection(db.GetStringConnection()))
            {
                connection.Open();

                SqlCommand command = connection.CreateCommand();
                SqlTransaction transaction;
                transaction = connection.BeginTransaction("SampleTransaction");
                command.Connection = connection;
                command.Transaction = transaction;

                string sql = "Insert Into lote(lot_numero, lot_quadra, lot_matricula, pro_id, cli_id) " +
                    "OUTPUT INSERTED.lot_id " +
                    "values (@lot_numero,@lot_quadra,@lot_matricula, @pro_id, @cli_id)";

                try
                {
                    command.CommandText = sql;
                    command.Parameters.AddWithValue("@lot_numero", lote.lot_numero);
                    command.Parameters.AddWithValue("@lot_quadra", lote.lot_quadra);
                    command.Parameters.AddWithValue("@lot_matricula", lote.lot_matricula);
                    command.Parameters.AddWithValue("@pro_id", projeto.pro_id);
                    command.Parameters.AddWithValue("@cli_id", cliente.cli_id);
                    var IdInserido = Convert.ToInt32(command.ExecuteScalar());

                    string sqlOrcamento = @"insert into orcamento(cli_id,
                                                                  lot_id,
                                                                pro_id,
                                                                orc_valor,
                                                                orc_valorEntrada,
                                                                orc_descEntrada,
                                                                orc_descRestante,
                                                                orc_qtdParcelaEntrada,
                                                                orc_qtdParcelaRestante,
                                                                orc_dtorcamento)                                                               
                                                              values (@cliente_id,
                                                                    @lot_id,
                                                                    @projeto_id,
                                                                    @orc_valor,
                                                                    @orc_valorEntrada,
                                                                    @orc_descEntrada,
                                                                    @orc_descRestante,
                                                                    @orc_qtdParcelaEntrada,
                                                                    @orc_qtdParcelaRestante,
                                                                    @orc_dtorcamento)";//,
                                                                   // @orc_dtvencimento,
                                                                   // @orc_dtiniciopag)";

                    command.CommandText = sqlOrcamento;
                    command.Parameters.AddWithValue("@cliente_id", cliente.cli_id);
                    command.Parameters.AddWithValue("@lot_id", IdInserido);
                    command.Parameters.AddWithValue("@projeto_id", projeto.pro_id);
                    command.Parameters.AddWithValue("@orc_valor", orcamento.orc_valor);
                    command.Parameters.AddWithValue("@orc_valorEntrada", orcamento.orc_valorEntrada);
                    command.Parameters.AddWithValue("@orc_descEntrada", orcamento.orc_descEntrada);
                    command.Parameters.AddWithValue("@orc_descRestante", orcamento.orc_descRestante);
                    command.Parameters.AddWithValue("@orc_qtdParcelaEntrada", orcamento.orc_qtdParcelaEntrada);
                    command.Parameters.AddWithValue("@orc_qtdParcelaRestante", orcamento.orc_qtdParcelaRestante);
                    command.Parameters.AddWithValue("@orc_dtorcamento", orcamento.orc_dtorcamento);
                   // command.Parameters.AddWithValue("@orc_dtvencimento", orcamento.orc_dtvencimento);
                   // command.Parameters.AddWithValue("@orc_dtiniciopag", orcamento.orc_dtiniciopag);

                    command.ExecuteNonQuery();

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


        public bool VerificaCliente(int projeto, int cliente)
        {
            using (SqlConnection connection = new SqlConnection(db.GetStringConnection()))
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = @"select count(c.cli_cpf) as contador
                                from lote l
                                inner join cliente c on c.cli_id = l.cli_id
                                inner join projeto p on p.pro_id = l.pro_id
                                where c.cli_id =" + cliente + " and p.pro_id = " + projeto;
                    command.CommandType = CommandType.Text;
                    var reader = command.ExecuteScalar();                   
                  
                        if (Convert.ToInt32(reader) > 0)
                        {
                            return false;
                        }
                        else
                        {
                            return true;
                        }                   
                   

                }
            }
        }

        public int ContaLote(int pro_id, int cli_id)
        {
           
            using (SqlConnection connection = new SqlConnection(db.GetStringConnection()))
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = @"select Count(*) lot_id 
                                            from lote
                                            where pro_id = "+ pro_id +" and cli_id = "+ cli_id;
                    command.CommandType = CommandType.Text;
                    var reader = command.ExecuteScalar();
                    return Convert.ToInt32(reader);
                }
            }
        }

        public bool VerificaSeTemLote(int projeto)
        {
         
            using (SqlConnection connection = new SqlConnection(db.GetStringConnection()))
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = @"select count(*) as contador
                                            from lote l
                                            inner join projeto p on p.pro_id = l.pro_id";
                    command.CommandType = CommandType.Text;
                    var reader = command.ExecuteScalar();
                    command.CommandText = "select pro_qtdelotes from projeto where pro_id =@pro_id";
                    command.Parameters.AddWithValue("@pro_id", projeto);
                    command.CommandType = CommandType.Text;
                    SqlDataReader lotes = command.ExecuteReader();                   
                    if (lotes.HasRows)
                    {
                        lotes.Read();
                        int l = lotes.GetInt32(0);
                        if (Convert.ToInt32(reader) < l)
                        {
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    }
                    return false;
                    
                }
            }
        }

        public void alterar(Lote lote, Projeto projeto, Cliente cliente)//passar uma classe 
        {
            try
            {
                string sql = @"Update lote set lot_numero=@lot_numero, lot_quadra=@lot_quadra, lot_matricula=@lot_matricula, pro_id=@pro_id, cli_id=@cli_id
                                where lot_id =@lot_id";
                db.AddParameter("@lot_numero", lote.lot_numero);
                db.AddParameter("@lot_quadra", lote.lot_quadra);
                db.AddParameter("@lot_matricula", lote.lot_matricula);
                db.AddParameter("@pro_id", projeto.pro_id);
                db.AddParameter("@cli_id", cliente.cli_id);
                db.AddParameter("@lot_id", lote.lot_id);
                db.ExecuteNonQuery(sql);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public bool ProcurarLote(string numero, string quadra, int projeto)
        {
            DbDataReader dr = null;
            try
            {
                string sql = @"select l.lot_numero, l.lot_quadra, p.pro_id
                                from lote l
                                inner join projeto p on p.pro_id = l.pro_id
                                where l.lot_numero=@lot_numero and l.lot_quadra =@lot_quadra and p.pro_id =@pro_id";
                
                db.AddParameter("@lot_numero", numero);
                db.AddParameter("@lot_quadra", quadra);
                db.AddParameter("@pro_id", projeto);
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

        public bool excluir(int lot_id, int pro_id, int cli_id)
        {
            using (SqlConnection connection = new SqlConnection(db.GetStringConnection()))
            {
                connection.Open();

                SqlCommand command = connection.CreateCommand();
                SqlTransaction transaction;
                transaction = connection.BeginTransaction("SampleTransaction");
                command.Connection = connection;
                command.Transaction = transaction;

                string sqlOrcamento = "delete from orcamento where lot_id =@lot_id and pro_id =@pro_id and cli_id = @cli_id";
                try
                {                 

                    command.CommandText = sqlOrcamento;  //insert endereço                   
                    command.Parameters.AddWithValue("@lot_id", lot_id);
                    command.Parameters.AddWithValue("@pro_id", pro_id);
                    command.Parameters.AddWithValue("@cli_id", cli_id);
                    command.ExecuteNonQuery();

                    string sqlLote = "Delete From lote where lot_id=@lotid";
                    command.CommandText = sqlLote; // insert cliente 
                    command.Parameters.AddWithValue("@lotid", lot_id);
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

        public void excluirCliente(int cli_id, int pro_id)
        {
            try
            {
                string sql = "Delete From lote where cli_id=@cli_id and pro_id=@pro_id";
                db.AddParameter("@cli_id", cli_id);
                db.AddParameter("@pro_id", pro_id);
                db.ExecuteNonQuery(sql);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataTable GetLotes(int cli_id, int pro_id)
        {
            try
            {
                DataTable dt = new DataTable();                
                string sql = @"select l.lot_id, l.lot_numero+' | '+ l.lot_quadra as lote 
                                from lote l
                                inner join cliente c on c.cli_id = l.cli_id
                                inner join projeto p on p.pro_id = l.pro_id
                                where c.cli_id =" + cli_id + " and p.pro_id = "+pro_id +"order by l.lot_numero";
                dt.Load(db.ExecuteReader(sql));
                return dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataView GetDataViewLote(int cli_id, int pro_id)
        {
            try
            {  
                string sql = @"select cli_id as CodCli, lot_id as CodLote, lot_numero as Lote, lot_quadra as Quadra, lot_matricula as Matrícula, pro_id
                                from lote 
                                where pro_id ="+pro_id+ " and cli_id ="+cli_id+ " order by lot_numero";

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

        public DataView GetDataView(string filtro, int projeto)
        {
            try
            {
                string par = "'%" + filtro + "%'";
               /* string sql = @"select TOP (50)  p.pro_nome as Projeto, c.cli_nome + ' ' + cli_sobrenome as Cliente ,l.lot_numero as Lote,
                                         l.lot_quadra as Quadra, l.lot_matricula as Matrícula , p.pro_id, c.cli_id,lot_id
                                 from lote l
                                 inner join projeto p on p.pro_id = l.pro_id
                                 inner join cliente c on c.cli_id = l.cli_id
                                 where (p.pro_id = "+projeto+") and ((c.cli_sobrenome like" + par + ") or (c.cli_nome like" + par + "))";*/

                  string sql = @"select distinct TOP (50)  p.pro_nome as Projeto, c.cli_nome + ' ' + cli_sobrenome as Cliente , p.pro_id, c.cli_id
                                 from lote l
                                 inner join projeto p on p.pro_id = l.pro_id
                                 inner join cliente c on c.cli_id = l.cli_id
                                 where (p.pro_id = " + projeto + ") and ((c.cli_sobrenome like" + par + ") or (c.cli_nome like" + par + "))";

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

        public DataView GetDataView(int pro_id, int cli_id)
        {
            try
            {
               string sql = @"select distinct p.pro_nome as Projeto, c.cli_nome + ' ' + cli_sobrenome as Cliente , p.pro_id, c.cli_id
                                 from lote l
                                 inner join projeto p on p.pro_id = l.pro_id
                                 inner join cliente c on c.cli_id = l.cli_id
                                 where p.pro_id = " + pro_id + " and c.cli_id ="+ cli_id;

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
                /* string sql = @"select TOP (50)  p.pro_nome as Projeto, c.cli_nome + ' ' + cli_sobrenome as Cliente ,l.lot_numero as Lote,
                                         l.lot_quadra as Quadra, l.lot_matricula as Matrícula , p.pro_id, c.cli_id,lot_id
                                 from lote l
                                 inner join projeto p on p.pro_id = l.pro_id
                                 inner join cliente c on c.cli_id = l.cli_id";*/

                string sql = @"select distinct TOP (50)  p.pro_nome as Projeto, c.cli_nome + ' ' + cli_sobrenome as Cliente , p.pro_id, c.cli_id
                                 from lote l
                                 inner join projeto p on p.pro_id = l.pro_id
                                 inner join cliente c on c.cli_id = l.cli_id";

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
