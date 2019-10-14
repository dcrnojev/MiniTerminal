using System;
using Dapper;
using System.Collections.Generic;
using System.Linq;
using System.Data.SqlClient;


namespace Zadatak_1
{
    class DataAccessList
    {
        public List<T> Data<T>(string queryString)
        {
            //Evo primjer kako da ne ponavljaš connection string svugdje
            using (SqlConnection connection = new SqlConnection(Settings.MainDbConnectionString))
            {
                var ReturningObject = connection.Query<T>(queryString).ToList();
                return ReturningObject;
            }
        }
    }

    class DataAccessAdd
    {
        public void AddData(string insertUpdateString)
        {
            var connectionString = "Server = (LocalDb)\\MSSQLLocalDB; Database = Zadatak1; Trusted_Connection = True; ";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                //connection.Execute(@"INSERT INTO dbo.PM(FirstName, LastName) VALUES (@FirstName, @LastName)","Ivana", "Mirkić") ;

            }
        }

    }
}


