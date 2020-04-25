using System.Data.SqlClient;

namespace GPF.Repository
{
    public abstract class Connection
    {
        private readonly string connectionString;
        public Connection()
        {
            connectionString = "Server=LAPTOP-FS6QDR67\\SQLEXPRESS; Database=GPF; User=admin; Password= G6*R<bZ8";//localhost
           
            // return new SqlConnection("Server=localhost;Port=5432;Database=GPF;User Id=postgres;Password=postgres123");//localhost
                                                                                                                //
            //Server = 127.0.0.1; Port = 5432; Database = myDataBase; User Id = myUsername; Password = myPassword;
        }
        protected SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }

    }

}

