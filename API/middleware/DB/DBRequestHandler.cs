using System.Data.SqlClient;
using API.Models;

namespace API.middleware.DB
{
    public class DBRequestHandler : ConnectionStringHandler
    {

        public List<DemoData> GetAllUsers()
        {
            throw new NotImplementedException();
            // Query = select * from API_DB_CONN_USERS
        }
        public DemoData GetUserByUUID(string uuid)
        {
            throw new NotImplementedException();
            // Query = select * from API_DB_CONN_USERS where uuid = 'uuid'
        }
        public void CreateUser(string uuid, string username, int yearOfBirth, string password)
        {
            throw new NotImplementedException();
            // Query = insert into API_DB_CONN_USERS(UUID, USERNAME, YEAROFBIRTH, PASSWORD) VALUES (UUID, USERNAME, YEAR OF BIRTH, PASSWORD)
        }
    }
}