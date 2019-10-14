using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Zadatak_1
{
    class PMRead
    {
        public void PMList()
        {
            DataAccessList dataAccess = new DataAccessList();

            var EmpWithoutCEO = dataAccess.Data<ProjectManagerDetail>(@"SELECT FirstName, LastName, Age, Project.ProjectName FROM dbo.PM
                                                        INNER JOIN Project ON Project.ProjectId = PM.ProjectId").ToList();

            Console.WriteLine();
            Console.WriteLine(String.Format("{0,18}{1,15}{2,15}{3,10}{4,25}","Role","First Name", "Last Name", "Age", "Project Name"));
            Console.WriteLine();
            foreach (ProjectManagerDetail emp in EmpWithoutCEO)
            {
                Console.WriteLine(String.Format(" {0,18}{1,15}{2,15}{3,10}{4,25}", "Project Manager", emp.firstName, emp.lastName, emp.age, emp.projectName));
            }
        }

}
}
