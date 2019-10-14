using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
namespace Zadatak_1
{ 
    class CEORead
    {
        public void CEOList()
        {

            DataAccessList dataAccess = new DataAccessList();
            var EmpCEO = dataAccess.Data<ChiefExecutiveOfficer>(@"SELECT Roles.RoleName, FirstName, LastName, Age, CeoYears FROM dbo.CEO
                                                        INNER JOIN Roles ON Roles.RoleId = CEO.RoleId;").ToList();

            Console.WriteLine();
            foreach (ChiefExecutiveOfficer emp in EmpCEO)
            {
                Console.WriteLine("Current CEO: ");
                Console.WriteLine(String.Format("First name: {0}, Last name: {1}, Age: {2}, Years as CEO: {3}", emp.FirstName, emp.LastName, emp.Age, emp.CeoYears));
                Console.WriteLine();
            }

        }
    }
}
