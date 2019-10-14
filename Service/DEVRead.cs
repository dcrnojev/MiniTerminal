using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Zadatak_1
{
    class DEVRead
    {
        public void DEVList()
        {
            DataAccessList dataAccess = new DataAccessList();

            var EmpWithoutCEO = dataAccess.Data<DeveloperDetail>(@"SELECT FirstName, LastName, Age, Project.ProjectName, IsStudent FROM dbo.DEV
                                                        INNER JOIN Project ON Project.ProjectId = DEV.ProjectId").ToList();

            Console.WriteLine();
            Console.WriteLine(String.Format("{0,18}{1,15}{2,15}{3,10}{4,25}{5,10}", "Role", "First Name", "Last Name", "Age", "Project Name", "Student"));
            Console.WriteLine();
            foreach (DeveloperDetail emp in EmpWithoutCEO)
            { 
                Console.WriteLine(String.Format(" {0,18}{1,15}{2,15}{3,10}{4,25}{5,10}", "Project Manager", emp.firstName, emp.lastName, emp.age, emp.projectName, emp.isStudent));
            }
        }
    }
}
