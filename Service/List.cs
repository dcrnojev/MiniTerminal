using System;
using System.Collections.Generic;
using System.Text;

namespace Zadatak_1
{
    class List
    {
        public void ReadEmpWithCEO()
        {
            DataAccess dataAccess = new DataAccess();


            var test = dataAccess.Data<ProjectManager>(@"SELECT *FirstName, LastName,  Project.ProjectName 
                                                        FROM dbo.PM INNER JOIN Project ON Project.ProjectId=PM.ProjectId ");

            foreach (ProjectManager name in test)
            {
                Console.WriteLine("Role: " + name.FirstName + " " + name.LastName );
            }
        }
    }
}
