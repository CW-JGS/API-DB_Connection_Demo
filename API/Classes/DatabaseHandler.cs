using System;
using System.Data.SqlClient;

namespace API
{
    public abstract class DatabaseHandler
    {
        public string GetConnectionString(){
            try{
                SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
                builder.DataSource = "dad.cbrifzw8clzr.us-east-1.rds.amazonaws.com";
                builder.UserID = "admin";
                builder.Password = "Kitemud$41";
                builder.InitialCatalog = "timtest";
                return builder.ConnectionString;
            }
            catch(Exception e){
                throw new Exception("Error in GetConnectionString() " + e.Message);
            }
        }
    }
}