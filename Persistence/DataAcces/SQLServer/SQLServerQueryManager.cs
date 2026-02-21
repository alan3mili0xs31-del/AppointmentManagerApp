using Microsoft.Data.SqlClient;
using System.Data;

namespace Persistence.DataAcces.SQLServer
{
    public class SQLServerQueryManager
    {
        private readonly SqlDbConnection _sqlDbConnection;

        public SQLServerQueryManager(SqlDbConnection sqlServerConnection)
        {
            _sqlDbConnection = sqlServerConnection;
        }

        /// <summary>
        /// Execute Non-Query Store Procedures to modify data from Database.
        /// </summary>
        /// <param name="spName">
        /// The name of the store procedure to be executed.
        /// </param>
        /// <param name="parameters">
        /// Delegate that let you add parameteres using the sql command providen.
        /// </param>
        /// <returns>
        /// Returns true if the execution was successful or false if not.
        /// </returns>
        internal bool ExecuteNonQuerySP(string spName, Action<SqlCommand> parameters)
        {
            using (var conn = _sqlDbConnection.CreateConnection())
            {
                using (var command = new SqlCommand(spName, conn))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    parameters.Invoke(command);

                    conn.Open();

                    int affectedColumns = command.ExecuteNonQuery();

                    conn.Close();

                    return affectedColumns > 0;
                }
            }
        }

        /// <summary>
        /// Execute Query Store Procedures to retrieve data from Database.
        /// </summary>
        /// <param name="spName">
        /// The name of the store procedure to be executed.
        /// </param>
        /// <param name="parameters">
        /// Delegate that let you add parameteres using the sql command providen.
        /// </param>
        /// <returns>
        /// Returns a datatable with the data retrieved from Database.
        /// </returns>
        internal DataTable ExecuteQuerySP(string spName, Action<SqlCommand> parameters)
        {
            using (var conn = _sqlDbConnection.CreateConnection())
            {
                using (var command = new SqlCommand(spName, conn))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    parameters.Invoke(command);

                    conn.Open();

                    using (var reader = command.ExecuteReader())
                    {
                        var table = new DataTable();
                        table.Load(reader);
                        conn.Close();
                        return table;
                    }
                }
            }
        }

        /// <summary>
        /// Execute Scalar Store Procedures to insert data into Database.
        /// </summary>
        /// <param name="spName">
        /// The name of the store procedure to be executed.
        /// </param>
        /// <param name="parameters">
        /// Delegate that let you add parameteres using the sql command providen.
        /// </param>
        /// <returns>
        /// Returns the id of the barely-created row.
        /// </returns>
        internal Guid ExecuteScalarSP(string spName, Action<SqlCommand> parameters)
        {
            using (var conn = _sqlDbConnection.CreateConnection())
            {
                using (var command = new SqlCommand(spName, conn))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    parameters.Invoke(command);

                    conn.Open();

                    var idGenerado = command.ExecuteScalar();

                    conn.Close();

                    return Guid.Parse(idGenerado.ToString() ?? string.Empty);
                }
            }
        }
    }
}
