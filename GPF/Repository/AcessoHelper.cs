using System;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;

namespace GPF.Repository
{
    public class AcessoHelper : IDisposable
    {

        private DbConnection objConnection;
        private DbCommand objCommand;
        private DbProviderFactory objFactory = null;

        public enum ConnectionState
        {
            MantemConexaoAberta,
            FechaConexaoAoSair
        }

        public AcessoHelper()
        {
            objFactory = SqlClientFactory.Instance;
            objConnection = objFactory.CreateConnection();
            objCommand = objFactory.CreateCommand();
            objConnection.ConnectionString = GetStringConnection();
            objCommand.Connection = objConnection;
        }

        public void Dispose()
        {
            objConnection.Close();
            objConnection.Dispose();
            objCommand.Dispose();
        }

        public string GetStringConnection()
        {
            string strConexao = "";
            // Retorna a string de conexão
            return strConexao;
        }

        public int ExecuteNonQuery(string query)
        {
            return ExecuteNonQuery(query, CommandType.Text, ConnectionState.FechaConexaoAoSair);
        }

        public int ExecuteNonQuery(string query, CommandType commandtype)
        {
            return ExecuteNonQuery(query, commandtype, ConnectionState.FechaConexaoAoSair);
        }

        public int ExecuteNonQuery(string query, ConnectionState connectionstate)
        {
            return ExecuteNonQuery(query, CommandType.Text, connectionstate);
        }

        public int ExecuteNonQuery(string query, CommandType commandtype, ConnectionState connectionstate)
        {
            objCommand.CommandText = query;
            objCommand.CommandType = commandtype;
            int i = -1;
            try
            {
                if (objConnection.State == System.Data.ConnectionState.Closed)
                    objConnection.Open();
                i = objCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw (ex);
            }
            finally
            {
                objCommand.Parameters.Clear();
                if (connectionstate == ConnectionState.FechaConexaoAoSair)
                    objConnection.Close();
            }
            return i;
        }

        public int ExecuteScalar(string query)
        {
            return ExecuteScalar(query, CommandType.Text, ConnectionState.FechaConexaoAoSair);
        }

        public int ExecuteScalar(string query, CommandType commandtype, ConnectionState connectionstate)
        {
            objCommand.CommandText = query;
            objCommand.CommandType = commandtype;
            int i = -1;
            try
            {
                if (objConnection.State == System.Data.ConnectionState.Closed)
                    objConnection.Open();
                i =Convert.ToInt32(objCommand.ExecuteScalar());
            }
            catch (Exception ex)
            {
                throw (ex);
            }
            finally
            {
                objCommand.Parameters.Clear();
                if (connectionstate == ConnectionState.FechaConexaoAoSair)
                    objConnection.Close();
            }
            return i;
        }

        public DbDataReader ExecuteReader(string query)
        {
            return ExecuteReader(query, CommandType.Text, ConnectionState.FechaConexaoAoSair);
        }

        public DbDataReader ExecuteReader(string query, CommandType commandtype)
        {
            return ExecuteReader(query, commandtype, ConnectionState.FechaConexaoAoSair);
        }

        public DbDataReader ExecuteReader(string query, ConnectionState connectionstate)
        {
            return ExecuteReader(query, CommandType.Text, connectionstate);
        }

        public DbDataReader ExecuteReader(string query, CommandType commandtype,
    ConnectionState connectionstate)
        {
            objCommand.CommandText = query;
            objCommand.CommandType = commandtype;
            DbDataReader reader = null;
            try
            {
                if (objConnection.State == System.Data.ConnectionState.Closed)
                    objConnection.Open();
                if (connectionstate == ConnectionState.FechaConexaoAoSair)
                    reader = objCommand.ExecuteReader(CommandBehavior.CloseConnection);
                else
                    reader = objCommand.ExecuteReader();
            }
            catch (Exception ex)
            {
                throw (ex);
            }
            finally
            {
                objCommand.Parameters.Clear();
            }
            return reader;
        }

        public int AddParameter(string name, object value)
        {
            DbParameter p = objFactory.CreateParameter();
            p.ParameterName = name;
            p.Value = value;
            return objCommand.Parameters.Add(p);
        }

        public int AddParameter(DbParameter parameter)
        {
            return objCommand.Parameters.Add(parameter);
        }
              
    }
}
