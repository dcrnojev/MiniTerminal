using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Zadatak_1
{
    class DSNRRead
    {
        public void DSNRList()
        {
            DataAccessList dataAccess = new DataAccessList();

            var EmpWithoutCEO = dataAccess.Data<DesignerDetail>(@"SELECT FirstName, LastName, Age, Project.ProjectName, CanDraw FROM dbo.DSNR
                                                        INNER JOIN Project ON Project.ProjectId = DSNR.ProjectId").ToList();

            Console.WriteLine();
            Console.WriteLine(String.Format("{0,18}{1,15}{2,15}{3,10}{4,25}{5,10}", "Role", "First Name", "Last Name", "Age", "Project Name", "Can Draw"));
            Console.WriteLine();
            foreach (DesignerDetail emp in EmpWithoutCEO)
            {
                Console.WriteLine(String.Format(" {0,18}{1,15}{2,15}{3,10}{4,25}{5,10}", "Designer", emp.firstName, emp.lastName, emp.age, emp.projectName, emp.canDraw));
            }
        }
    }
}

