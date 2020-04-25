using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace GPF.Repository
{
    public abstract class BaseRepository: Connection
    {
        protected List<SqlParameter> parameters;

      
        protected int ExecuteNowQuery(string transactSql) {
            using (var connection = GetConnection()){
                connection.Open();
                using(var command = new SqlCommand()) {
                    command.Connection = connection;
                    command.CommandText = transactSql;
                    command.CommandType = CommandType.Text;
                    foreach (SqlParameter item in parameters)
                    {
                        command.Parameters.Add(item);
                    }
                    int result = command.ExecuteNonQuery();
                    parameters.Clear();
                    return result;
                }
            }
        }
        protected DataTable ExecuteNowReader(string transactSql) {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = transactSql;
                    command.CommandType = CommandType.Text;
                    SqlDataReader reader = command.ExecuteReader();
                    using(var table = new DataTable())
                    {
                        table.Load(reader);
                        reader.Dispose();
                        return table;
                    }
                }
            }
        }

    }
}

