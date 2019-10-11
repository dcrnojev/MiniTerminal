using System;
using System.Collections.Generic;
using System.Linq;


namespace Zadatak_1
{

    public class Commands
    {
        public void ReadAllCEO()
        {

        }

        /*
        private readonly Roles roles;
        public Commands(Roles rolesCon)
        {
            roles = rolesCon;
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
            Save();
            Load();
        }

        public void Add()

        {
            Console.Write("Role: ");
            var role = Console.ReadLine();

            if (role != "CEO" && role != "PM" && role != "DEV" && role != "DSNR" && role != "ST")
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
                        Console.Write("Age: ");
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

        public void Save()
        {
            File.Delete("Data.txt");
            foreach (var employee in roles.CEO)
            {
                string newEmployee = String.Format("CEO, {0}, {1}, {2}, {3}", employee.FirstName, employee.LastName, employee.Age, employee.CeoYears);
                File.AppendAllText("Data.txt", newEmployee + Environment.NewLine);
            }

            foreach (var employee in roles.PM)
            {
                string newEmployee = String.Format("PM, {0}, {1}, {2}, {3}", employee.FirstName, employee.LastName, employee.Age, employee.Project);
                File.AppendAllText("Data.txt", newEmployee + Environment.NewLine);
            }

            foreach (var employee in roles.DEV)
            {
                string newEmployee = String.Format("DEV, {0}, {1}, {2}, {3}, {4}", employee.FirstName, employee.LastName, employee.Age, employee.Project, employee.IsStudent);
                File.AppendAllText("Data.txt", newEmployee + Environment.NewLine);
            }

            foreach (var employee in roles.DSNR)
            {
                string newEmployee = String.Format("DSNR, {0}, {1}, {2}, {3}, {4}", employee.FirstName, employee.LastName, employee.Age, employee.Project, employee.CanDraw);
                File.AppendAllText("Data.txt", newEmployee + Environment.NewLine);
            }

            foreach (var employee in roles.ST)
            {
                string newEmployee = String.Format("ST, {0}, {1}, {2}, {3}, {4}", employee.FirstName, employee.LastName, employee.Age, employee.Project, employee.UsesAutomatedTests);
                File.AppendAllText("Data.txt", newEmployee + Environment.NewLine);
            }

            Console.WriteLine("Data saved.");
        }

        List<string> allLinesText = File.ReadAllLines("Data.txt").ToList();
        public void Display()
        {
            foreach (string line in allLinesText)
            {
                Console.WriteLine(line);
            }
        }

        public void List()
        {
            for (int i = 1; i < allLinesText.Count; i++)
            {
                Console.WriteLine(allLinesText[i]);
            }
        }

        public void CEOList()
        {
            foreach (string line in allLinesText)
            {
                if (line.Contains("CEO"))
                {
                    Console.WriteLine(line);
                }
            }
        }

        public void DEVList()
        {
            foreach (string line in allLinesText)
            {
                if (line.Contains("DEV"))
                {
                    Console.WriteLine(line);
                }
            }
        }

        public void DSNRList()
        {
            foreach (string line in allLinesText)
            {
                if (line.Contains("DSNR"))
                {
                    Console.WriteLine(line);
                }
            }
        }
        public void PMList()
        {
            foreach (string line in allLinesText)
            {
                if (line.Contains("PM"))
                {
                    Console.WriteLine(line);
                }
            }
        }

        public void STList()
        {
            foreach (string line in allLinesText)
            {
                if (line.Contains("ST"))
                {
                    Console.WriteLine(line);
                }
            }
        }

        public void Load()
        {
            List<string> allLinesText = File.ReadAllLines("Data.txt").ToList();
            foreach (string line in allLinesText)
            {
                string[] words = line.Split(", ");
                switch (words[0])
                {
                    case ("CEO"):
                        roles.CEO.Add(new Roles.ClassCEO
                        {
                            FirstName = words[1],
                            LastName = words[2],
                            Age = int.Parse(words[3]),
                            CeoYears = int.Parse(words[4])
                        });
                        break;

                    case ("PM"):
                        roles.PM.Add(new Roles.ClassPM
                        {
                            FirstName = words[1],
                            LastName = words[2],
                            Age = int.Parse(words[3]),
                            Project = words[4]
                        });
                        break;

                    case ("DEV"):
                        roles.DEV.Add(new Roles.ClassDEV
                        {
                            FirstName = words[1],
                            LastName = words[2],
                            Age = int.Parse(words[3]),
                            Project = words[4],
                            IsStudent = System.Convert.ToBoolean(words[5])
                        }); ;
                        break;

                    case ("DSNR"):
                        roles.DSNR.Add(new Roles.ClassDSNR
                        {
                            FirstName = words[1],
                            LastName = words[2],
                            Age = int.Parse(words[3]),
                            Project = words[4],
                            CanDraw = System.Convert.ToBoolean(words[5])
                        });
                        break;

                    case ("ST"):
                        roles.ST.Add(new Roles.ClassST
                        {
                            FirstName = words[1],
                            LastName = words[2],
                            Age = int.Parse(words[3]),
                            Project = words[4],
                            UsesAutomatedTests = System.Convert.ToBoolean(words[5])
                        });
                        break;

                    default: continue;

                }
            }
        }*/
    }
}
