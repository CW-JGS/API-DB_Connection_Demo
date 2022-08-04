using System.Data.SqlClient;
using API.Models;

namespace API.middleware.DB
{
    public class DBRequestHandler : ConnectionStringHandler
    {
        private string _connectionString;
        public DBRequestHandler()
        {
            _connectionString = GetConnectionString();
        }
        public List<DemoData> GetAllUsers()
        {
            List<DemoData> returnData = new List<DemoData>();
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                try
                {
                    connection.Open();
                    string Query = "select * from API_DB_CONN_USERS";
                    using (SqlCommand command = new SqlCommand(Query, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                returnData.Add(new DemoData(reader.GetString(1), reader.GetInt32(2), reader.GetString(3)));
                            }
                        }
                    }
                }
                catch (System.Exception ex)
                {
                    throw;
                }
                finally
                {
                    connection.Close();
                }
                return returnData;
            }

        }
        public DemoData GetUserByUUID(string uuid)
        {
            DemoData ReturnData;
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                try
                {
                    connection.Open();
                    string Query = string.Format("select * from API_DB_CONN_USERS where uuid = {0}", uuid);
                    using (SqlCommand command = new SqlCommand(Query, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                ReturnData = new DemoData(reader.GetString(1), reader.GetInt32(2), reader.GetString(3));
                                connection.Close();
                                return ReturnData;
                            }
                        }
                    }
                }
                catch (System.Exception ex)
                {
                    connection.Close();
                    throw;

                }
                finally
                {
                    throw new Exception("data not found in database");
                }
            }
        }
        public bool CreateUser(string uuid, string username, int yearOfBirth, string password)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                try
                {
                    connection.Open();
                    string Query = string.Format("insert into API_DB_CONN_USERS(UUID, USERNAME, YEAROFBIRTH, PASSWORD VALUES ({0}, {1}, {2}, {3})", uuid, username, yearOfBirth, password);
                    using (SqlCommand command = new SqlCommand(Query, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            Console.WriteLine("data read = ", reader.Read());
                        }
                    }
                }
                catch (System.Exception ex)
                {
                    // TODO
                    return false;
                }
                finally
                {
                    connection.Close();
                }
                return true;
            }

        }
    }
}