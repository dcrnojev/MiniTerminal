using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Dapper;

namespace Zadatak_1
{
    class List
    {
        public void ReadEmpWithCEO()
        {
            DataAccessList dataAccess = new DataAccessList();
            Display display = new Display();

   
            var empWithCEO = dataAccess.Data<ListingProperties>(@"SELECT Roles.RoleName, FirstName, LastName, Age, '**No Project**' AS ProjectName FROM dbo.CEO                                         
                                                        INNER JOIN Roles ON Roles.RoleId = CEO.RoleId").ToList();


            display.ReadEmpWithoutCEO();
            foreach (ListingProperties emp in empWithCEO)
            {
                Console.WriteLine(String.Format(" {0,-10}{1,8}{2,12}{3,10}", emp.RoleName, emp.FirstName, emp.LastName, emp.Age));
            }

        }
    }
}
