using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;

namespace Zadatak_1
{
    class Program
    {
        public class Role
        {
            public string FirstName;
            public string LastName;
            public int Age;
        }
        public class Roles
        {
            public Roles()
            {
                CEO = new List<ClassCEO> { };
                PM = new List<ClassPM> { };
                DEV = new List<ClassDEV> { };
                DSNR = new List<ClassDSNR> { };
                ST = new List<ClassST> { };
            }

            public class ClassCEO : Role
            {
                public const string RoleName = "CEO";
                public int CeoYears;
            }

            public class ClassPM : Role
            {
                public const string RoleName = "PM";
                public string Project;
            }
            public class ClassDEV : Role
            {
                public const string RoleName = "DEV";
                public string Project;
                public bool IsStudent;
            }

            public class ClassDSNR : Role
            {
                public const string RoleName = "DSNR";
                public string Project;
                public bool CanDraw;
            }

            public class ClassST : Role
            {
                public const string RoleName = "ST";
                public string Project;
                public bool UsesAutomatedTests;
            }

            public List<ClassCEO> CEO { get; set; }
            public List<ClassPM> PM { get; set; }
            public List<ClassDEV> DEV { get; set; }
            public List<ClassDSNR> DSNR { get; set; }
            public List<ClassST> ST { get; set; }


        }

        public class Commands
        {

            private readonly Roles roles;
            public Commands(Roles roles)
            {
                this.roles = roles;
            }

            public void CEOList()
            {
                foreach (var employee in roles.CEO)
                {
                    Console.WriteLine("{0}, {1}, {2}, {3} ", employee.FirstName, employee.LastName, employee.Age, employee.CeoYears);
                }
            }

            public void PMList()
            {
                foreach (var employee in roles.PM)
                {
                    Console.WriteLine("{0}, {1}, {2}, {3} ", employee.FirstName, employee.LastName, employee.Age, employee.Project);
                }
            }
            public void DEVList()
            {
                foreach (var employee in roles.DEV)
                {
                    Console.WriteLine("{0}, {1}, {2}, {3} ", employee.FirstName, employee.LastName, employee.Age, employee.Project, employee.IsStudent);
                }
            }

            public void DSNRList()
            {
                foreach (var employee in roles.DSNR)
                {
                    Console.WriteLine("{0}, {1}, {2}, {3} ", employee.FirstName, employee.LastName, employee.Age, employee.Project, employee.CanDraw);
                }
            }

            public void STList()
            {
                foreach (var employee in roles.ST)
                {
                    Console.WriteLine("{0}, {1}, {2}, {3} ", employee.FirstName, employee.LastName, employee.Age, employee.Project, employee.UsesAutomatedTests);
                }
            }

            public void List()
            {
                Console.WriteLine("CEO: ");
                CEOList();
                Console.WriteLine("PM: ");
                PMList();
                Console.WriteLine("DEV: ");
                DEVList();
                Console.WriteLine("DSNR: ");
                DSNRList();
                Console.WriteLine("ST: ");
                STList();
            }
            public void Display()
            {
                Console.WriteLine("PM: ");
                PMList();
                Console.WriteLine("DEV: ");
                DEVList();
                Console.WriteLine("DSNR: ");
                DSNRList();
                Console.WriteLine("ST: ");
                STList();
            }

            public void Remove()
            {
                Console.Write("Role: ");
                var roleRemove = Console.ReadLine();

                Console.Write("Name: ");
                var name = Console.ReadLine();

                Console.Write("Last name: ");
                var surname = Console.ReadLine();

                if (Equals(Roles.ClassCEO.RoleName, roleRemove))
                {
                    roles.CEO.RemoveAll(r => (Equals(r.FirstName, name) && Equals(r.LastName, surname)));
                }

                if (Equals(Roles.ClassDEV.RoleName, roleRemove))
                {
                    roles.DEV.RemoveAll(r => (Equals(r.FirstName, name) && Equals(r.LastName, surname)));
                }

                if (Equals(Roles.ClassDSNR.RoleName, roleRemove))
                {
                    roles.DSNR.RemoveAll(r => (Equals(r.FirstName, name) && Equals(r.LastName, surname)));
                }

                if (Equals(Roles.ClassPM.RoleName, roleRemove))
                {
                    roles.PM.RemoveAll(r => (Equals(r.FirstName, name) && Equals(r.LastName, surname)));
                }
                if (Equals(Roles.ClassST.RoleName, roleRemove))
                {
                    roles.ST.RemoveAll(r => (Equals(r.FirstName, name) && Equals(r.LastName, surname)));
                }
            }

            public void Add()

            {
                Console.Write("Role: ");
                var role = Console.ReadLine();
  
                if (role != "CEO" && role!= "PM" && role != "DEV" && role != "DSNR" && role != "ST")
                {
                    Console.WriteLine("Requested role does not exist. Existing roles are: CEO, DEV, PM, ST and DSNR.");
                }
                else
                {
                    if (!(Equals(Roles.ClassCEO.RoleName.ToLower(), role)) || roles.CEO.Count == 0)
                    {

                        Console.Write("FirstName: ");
                        var firstName = Console.ReadLine();

                        Console.Write("LastName: ");
                        var lastName = Console.ReadLine();

                        int age = 0;
                        bool isNum;
                        do
                        {
                            Console.Write($"{nameof(Role.Age)}: ");
                            string ageTest = Console.ReadLine();

                            isNum = int.TryParse(ageTest, out int myInt);

                            if (isNum)
                            {
                                age = myInt;
                            }

                            else
                            {
                                Console.WriteLine("Invalid input.");
                            };

                        } while (age == 0 || !isNum);

     
                        switch (role)
                        {

                            case Roles.ClassCEO.RoleName:

                                var ceoYears = 0;
                                do
                                {
                                    Console.Write("CEO Years: ");
                                    string ceoYearsTest = Console.ReadLine();

                                    isNum = int.TryParse(ceoYearsTest, out int myInt);

                                    if (isNum)
                                    {
                                        ceoYears = myInt;
                                    }

                                    else
                                    {
                                        Console.WriteLine("Invalid input.");
                                    };

                                } while (ceoYears == 0 || !isNum);

                                roles.CEO.Add(new Roles.ClassCEO
                                {
                                    Age = age,
                                    FirstName = firstName,
                                    LastName = lastName,
                                    CeoYears = ceoYears
                                });


                                break;

                            case Roles.ClassPM.RoleName:

                                Console.Write("Name of the project: ");
                                var projectPM = Console.ReadLine();

                                roles.PM.Add(new Roles.ClassPM
                                {
                                    Age = age,
                                    FirstName = firstName,
                                    LastName = lastName,
                                    Project = projectPM
                                });


                                break;

                            case Roles.ClassDEV.RoleName:
                                Console.Write("Name of the project: ");
                                var projectDEV = Console.ReadLine();
                                Console.Write("Are you a student? ");
                                var isStudentDEV = System.Convert.ToBoolean(Console.ReadLine());

                                roles.DEV.Add(new Roles.ClassDEV
                                {
                                    Age = age,
                                    FirstName = firstName,
                                    LastName = lastName,
                                    Project = projectDEV,
                                    IsStudent = isStudentDEV
                                });

                                break;

                            case Roles.ClassDSNR.RoleName:
                                Console.Write("Name of the project: ");
                                var projectDSNR = Console.ReadLine();
                                Console.Write("Can draw: ");
                                var CanDrawDSNR = System.Convert.ToBoolean(Console.ReadLine());

                                roles.DSNR.Add(new Roles.ClassDSNR
                                {
                                    Age = age,
                                    FirstName = firstName,
                                    LastName = lastName,
                                    Project = projectDSNR,
                                    CanDraw = CanDrawDSNR
                                });

                                break;

                            case Roles.ClassST.RoleName:
                                Console.Write("Name of the project: ");
                                var projectST = Console.ReadLine();
                                Console.Write("Uses automated tests: ");
                                var UsesAutomatedTestsST = System.Convert.ToBoolean(Console.ReadLine());

                                roles.ST.Add(new Roles.ClassST
                                {
                                    Age = age,
                                    FirstName = firstName,
                                    LastName = lastName,
                                    Project = projectST,
                                    UsesAutomatedTests = UsesAutomatedTestsST
                                });


                                break;

                            default:
                                Console.WriteLine("Requested role does not exist. Existing roles are: CEO, DEV, PM, ST and DSNR.");

                                break;

                        }

                    }
                    else
                    {
                        Console.WriteLine("There already exists a CEO!");
                    };
                }
            }
            public void Help()
            {
                Console.WriteLine("Available commands: Add, Remove, Display, List, <role_name>List");
            }
        }


        static void Main()
        {
            var memoryCache = new Roles();
            var Commands = new Commands(memoryCache);

            Console.WriteLine("Available commands: Add, Remove, Display, List, <role_name>List");

            Program p = new Program();
            for (; ; )
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
                        break;


                    default:
                        Console.WriteLine("Requested command does not exist. Available commands: Add, Remove, Display, List, <role_name>List");
                        break;
                }

            }

        }

    }
}
