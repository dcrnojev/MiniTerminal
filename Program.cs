using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.IO;
using System.Data.SqlClient;
using Dapper;

namespace Zadatak_1
{
    class Program
    {
        static void Main()
        {
         DataAccess db = new DataAccess();

            var test = db.Data<ProjectManager>("SELECT TOP (2) FirstName, LastName,  ProjectId FROM dbo.PM ");

            foreach (ProjectManager name in test) 
                    {
                Console.WriteLine(name.FirstName + name.ProjectId);
                    }

           
            Help h = new Help();
            h.AvailableCommands();


            List listAll = new List();

            listAll.ReadEmpWithCEO();
            
            /*
                var connectionString = "Server = (LocalDb)\\MSSQLLocalDB; Database = Zadatak1; Trusted_Connection = True; ";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    var FirstName = connection.QueryFirst<string>("SELECT TOP (1) FirstName FROM dbo.CEO");
                    Console.WriteLine(FirstName);
                   
                }
            
            DataAccess db = new DataAccess();
            db.GetPeople();

            var memoryCache = new Roles();
            var Commands = new Commands(memoryCache);
            Commands.Load();
            Console.WriteLine("Data loaded.");
            Console.WriteLine("Available commands: Add, Remove, Display, List, <role_name>List");
            
                for (; ;)
            {
                Console.Write("Command: ");
                string unos = Console.ReadLine().ToLower();
               
                switch (unos)
                {
                    case "add":
                        Commands.Add();
                        break;

                    case "display":
                        Console.WriteLine("Employees in system: ");
                        Commands.Display();
                        break;

                    case "help":
                        Commands.Help();
                        break;

                    case "list":
                        Commands.List();
                        break;

                    case "remove":
                        Commands.Remove();
                        break;

                    case "ceolist":
                        Commands.CEOList();
                        break;

                    case "pmlist":
                        Commands.PMList();
                        break;

                    case "devlist":
                        Commands.DEVList();
                        break;

                    case "dsnrlist":
                        Commands.DSNRList();
                        break;

                    case "stlist":
                        Commands.STList();
                        Console.WriteLine("");
                        break;
                        
                    case "save":
                        Commands.Save();
                        break;

                    case "load":
                        Commands.Load();
                        break;

                    default:
                        Console.WriteLine("Requested command does not exist. Available commands: Add, Remove, Display, List, <role_name>List");
                        break;
                }

            }*/

        }

    }
}
