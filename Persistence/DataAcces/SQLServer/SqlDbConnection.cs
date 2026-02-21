using Microsoft.Data.SqlClient;
using System.Data;


namespace Persistence.DataAcces.SQLServer
{
    public class SqlDbConnection 
    {
        private readonly string _connectionString;

        /// <summary>
        /// Constructor which initializes connection string.
        /// </summary>
        /// <param name="connectionString">
        /// The connection string to connect to your Database.
        /// </param>
        public SqlDbConnection(string connectionString)
        {
            _connectionString = connectionString;
        }

        /// <summary>
        /// Stablish connection to sql server databases.
        /// </summary>
        /// <returns>
        /// An instance of SqlConnection class.
        /// </returns>
        public SqlConnection CreateConnection()
        {
            return new SqlConnection(_connectionString);
        }
    }
}
