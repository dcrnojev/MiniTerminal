using System;


namespace Zadatak_1
{
    class Program
    {
        static void Main()
        {
            List listAll = new List();
            Display displayAll = new Display();
            Help help = new Help();
            CEORead ceoRead = new CEORead();
            PMRead pmRead = new PMRead();
            DEVRead devRead = new DEVRead();
            DSNRRead dsnrRead = new DSNRRead();
            STRead stRead = new STRead();

            help.AvailableCommands();

            for (; ; )
            {
                var unos = Console.ReadLine();
                switch (unos)
                {
                    case "List":
                        listAll.ReadEmpWithCEO();
                        break;

                    case "Display":
                        displayAll.ReadEmpWithoutCEO();
                        break;

                    case "Help":
                        help.AvailableCommands();
                        break;

                    case "CEOList":
                        ceoRead.CEOList();
                        break;

                    case "PMList":
                        pmRead.PMList();
                        break;

                    case "DEVList":
                        devRead.DEVList();
                        break;

                    case "DSNRList":
                        dsnrRead.DSNRList();
                        break;

                    case "STList":
                        stRead.STList();
                        break;
                    default: break;


                }
            }
/*
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
