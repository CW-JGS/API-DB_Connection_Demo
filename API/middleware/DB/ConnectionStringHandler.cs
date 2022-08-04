using System.Data.SqlClient;

namespace API.middleware.DB
{
    public abstract class ConnectionStringHandler
    {
        public static string GetConnectionString()
        {
            try
            {
                SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
                builder.DataSource = "Database URL";
                builder.UserID = "username";
                builder.Password = "password";
                builder.InitialCatalog = "database name";
                return builder.ConnectionString;

            }
            catch (Exception err)
            {
                throw;
            }
        }

    }
}