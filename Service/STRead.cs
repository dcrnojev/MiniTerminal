using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Zadatak_1
{
    class STRead
    {
        public void STList()
        {
            DataAccessList dataAccess = new DataAccessList();

            var softwareTesters = dataAccess.Data<SoftwareTesterDetail>(@"SELECT FirstName, LastName, Age, Project.ProjectName, UsesAutomatedTests FROM dbo.ST
                                                        INNER JOIN Project ON Project.ProjectId = ST.ProjectId").ToList();

            Console.WriteLine();
            Console.WriteLine(String.Format("{0,18}{1,15}{2,15}{3,10}{4,25}{5,20}", "Role", "First Name", "Last Name", "Age", "Project Name ", "   Uses Automated Tests"));
            Console.WriteLine();

            foreach (SoftwareTesterDetail emp in softwareTesters)
            {
                Console.WriteLine(String.Format(" {0,18}{1,15}{2,15}{3,10}{4,25}{5,20}", "Designer", emp.firstName, emp.lastName, emp.age, emp.projectName, emp.usesAutomatedTests));
            }
        }
    }
}
