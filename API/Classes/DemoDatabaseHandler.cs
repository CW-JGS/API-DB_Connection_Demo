using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace API
{
    public class DemoDatabaseHandler:DatabaseHandler
    {
       public List<Demo> GetAllDemoFromDB()
       {

           List<Demo> returnData = new List<Demo>();

            // create a connection
            using(SqlConnection conn = new SqlConnection(GetConnectionString()))
            {
                try{
                    conn.Open();
                    // create a command - hold the sql we want to execute
                    string query = "select did, data1, data2 from API_DB_Connection_Demo_Table";
                    using(SqlCommand comm = new SqlCommand(query, conn)){
                        // execute the command (on the connection) and read the results 
                        using(SqlDataReader rdr = comm.ExecuteReader())
                        {

                            //and put them not the returnData list
                            while(rdr.Read()){
                                returnData.Add(new Demo(){  did = rdr.GetInt32(0), 
                                                            data1 = rdr.GetString(1), 
                                                            data2 = rdr.GetString(2) 
                                                         });
                            } // end of scope for while
                        } // end of scope for rdr
                    }// end of comm
                } // end of scope for try
                catch(Exception e){
                    throw new Exception("Error in GetAllDemoFromDB() " + e.Message);
                }
                finally{
                    conn.Close();
                } 
            }// end of scope for conn
            
            return returnData;
        } // end of method
    }
}
