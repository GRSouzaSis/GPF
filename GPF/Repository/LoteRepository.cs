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

        public void excluir(int lot_id)
        {
            try
            {
                string sql = "Delete From lote where lot_id=@lot_id";
                db.AddParameter("@lot_id", lot_id);
                db.ExecuteNonQuery(sql);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataView GetDataView(string filtro)
        {
            try
            {
                string par = "'%" + filtro + "%'";
                string sql = @"select TOP (50)  p.pro_nome as Projeto, c.cli_nome + ' ' + cli_sobrenome as Cliente ,l.lot_numero as Lote,
                                        l.lot_quadra as Quadra, l.lot_matricula as Matrícula , p.pro_id, c.cli_id,lot_id
                                from lote l
                                inner join projeto p on p.pro_id = l.pro_id
                                inner join cliente c on c.cli_id = l.cli_id
                                where (p.pro_nome like" + par + ") or (c.cli_sobrenome like" + par + ") or (c.cli_nome like" + par + ")";

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
                string sql = @"select TOP (50)  p.pro_nome as Projeto, c.cli_nome + ' ' + cli_sobrenome as Cliente ,l.lot_numero as Lote,
                                        l.lot_quadra as Quadra, l.lot_matricula as Matrícula , p.pro_id, c.cli_id,lot_id
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
