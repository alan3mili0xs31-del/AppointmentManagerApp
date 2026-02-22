using BusinessLogic.Entities;
using BusinessLogic.Interfaces;
using Persistence.DataAcces.SQLServer;
using System.Data;

namespace Persistence.Repositories.UserRepos
{
    public class UserDBRepo : IUserRepository
    {
        private readonly SQLServerQueryManager _queryManager;

        public UserDBRepo(SQLServerQueryManager queryManager)
        {
            _queryManager = queryManager;
        }

        public User? GetById(Guid id)
        {
             var users = _queryManager.ExecuteQuerySP("spGetUserById", (command) =>
            {
                command.Parameters.Add("@p_id_user", SqlDbType.UniqueIdentifier).Value = id;
            });

            return users.Rows.Count > 0 ? MapRowToUser(users.Rows[0]) : null;
        }

        public User? GetByUserName(string userName)
        {
            var users = _queryManager.ExecuteQuerySP("spGetUserByUserName", (command) =>
            {
                command.Parameters.Add("@p_user_name", SqlDbType.NVarChar).Value = userName;
            });

            return users.Rows.Count > 0 ? MapRowToUser(users.Rows[0]) : null;
        }

        private User MapRowToUser(DataRow row)
        {
            Guid id = Guid.Parse(row["id_user"].ToString() ?? string.Empty);
            string userName = row["user_name"].ToString() ?? string.Empty;
            string emailAdress = row["email_adress"].ToString() ?? string.Empty;
            string password = row["password"].ToString() ?? string.Empty;
            DateTime creationDate = DateTime.Parse(row["creation_date"].ToString() ?? string.Empty);
            int status = Convert.ToInt32(row["status"]);

            return new User(id, userName, emailAdress, password, creationDate, status);
        }
    }
}
