using System;
using Dapper;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.IO;
using System.Data.SqlClient;
using Dapper.Contrib;

namespace Zadatak_1
{
    class DataAccess
    {
        public List<T> Data<T>(string queryString)
        {
            var connectionString = "Server = (LocalDb)\\MSSQLLocalDB; Database = Zadatak1; Trusted_Connection = True; ";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                var ReturningObject = connection.Query<T>(queryString).ToList();
                return ReturningObject;
            }
   
        }
    }
}


