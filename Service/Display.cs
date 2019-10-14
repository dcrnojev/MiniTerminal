using System;
using System.Linq;

namespace Zadatak_1
{ 
    class Display
    {
        public void ReadEmpWithoutCEO()
        {
            DataAccessList dataAccess = new DataAccessList();

            var EmpWithoutCEO = dataAccess.Data<ListingProperties>(@"SELECT Roles.RoleName, FirstName, LastName, Age, Project.ProjectName FROM dbo.PM
                                                        INNER JOIN Project ON Project.ProjectId = PM.ProjectId
                                                        INNER JOIN Roles ON Roles.RoleId = PM.RoleId
                                                        UNION ALL
                                                        SELECT Roles.RoleName, FirstName, LastName, Age, Project.ProjectName FROM dbo.DEV
                                                        INNER JOIN Project ON Project.ProjectId = DEV.ProjectId
                                                        INNER JOIN Roles ON Roles.RoleId = DEV.RoleId
                                                        UNION ALL
                                                        SELECT Roles.RoleName, FirstName, LastName, Age, Project.ProjectName FROM dbo.DSNR
                                                        INNER JOIN Project ON Project.ProjectId = DSNR.ProjectId
                                                        INNER JOIN Roles ON Roles.RoleId = DSNR.RoleId
                                                        UNION ALL
                                                        SELECT Roles.RoleName, FirstName, LastName, Age, Project.ProjectName FROM dbo.ST
                                                        INNER JOIN Project ON Project.ProjectId = ST.ProjectId
                                                        INNER JOIN Roles ON Roles.RoleId = ST.RoleId; ").ToList();

            Console.WriteLine();
            Console.WriteLine(String.Format("{0,-10}{1,8}{2,12}{3,9}", "Role", "First Name", "Last Name", "Age"));
            Console.WriteLine();
            foreach (ListingProperties emp in EmpWithoutCEO)
            {
                Console.WriteLine(String.Format(" {0,-10}{1,8}{2,12}{3,10}", emp.RoleName, emp.FirstName, emp.LastName, emp.Age));
            }


        }
    }
}
