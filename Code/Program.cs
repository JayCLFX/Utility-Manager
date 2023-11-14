using System.Diagnostics;

namespace Utility
{
    public class Program
    {
        static void Main(string[] args)
        {
            Library.Initialize_Library();
            MainProgramm();
        }

        public static void MainProgramm()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;

            Console.WriteLine(
                @"  _    _ _   _ _ _ _           _____                                               " + "\n" +
                @" | |  | | | (_) (_) |         |  __ \                                              " + "\n" +
                @" | |  | | |_ _| |_| |_ _   _  | |__) | __ ___   __ _ _ __ __ _ _ __ ___  _ __ ___  " + "\n" +
                @" | |  | | __| | | | __| | | | |  ___/ '__/ _ \ / _` | '__/ _` | '_ ` _ \| '_ ` _ \ " + "\n" +
                @" | |__| | |_| | | | |_| |_| | | |   | | | (_) | (_| | | | (_| | | | | | | | | | | |" + "\n" +
                @"  \____/ \__|_|_|_|\__|\__, | |_|   |_|  \___/ \__, |_|  \__,_|_| |_| |_|_| |_| |_|" + "\n" +
                @"                        __/ |                   __/ |                              " + "\n" +
                @"                       |___/                   |___/                               " + "\n" +
                @"___________________________________________________________________________________" + "\n\n\n"
                );
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($" --------------------|Steam|--------------------\n");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(" 1. Start Steam Instances with MinigameList (10)\n 2. Start Steam Instances Silent (10)\n 3. Start CS2 Instances (10)\n");

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($" --------------------|Browser|--------------------\n");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(" 4. Start Edge Instances\n 5. Placeholder\n");

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($" --------------------|Misc|--------------------\n");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(" 6. Utility\n 7. Scripts\n 8. Exit\n");

            var answer = Console.ReadLine(); Console.Clear();
            var result = "";
            switch (answer )
            {
                case "1":
                    result = Steam.Start_Steam_Instances_MinigameList(); break;
                case "2":
                    result = Steam.Start_Steam_Instances_Silent(); break;
                case "3":
                    result = Steam.Start_Steam_Instances_CS2(); break;
                case "4":
                    result = Edge.Start_Edge_Instances(); break;
                case "5":
                    break;
                case "6":
                    Utility.UtilityMenu(); break;
                case "7":
                    Scripts.Scripts_Menu(); break;
                case "8":
                    Environment.Exit(0); break;
            }

            if (result == "Success")
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Success");
                Console.ForegroundColor= ConsoleColor.White;
                Thread.Sleep(2000);
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("Returned Error");
                Console.ForegroundColor = ConsoleColor.White;
                Thread.Sleep(2000);
            }

            Console.Clear(); MainProgramm();
        }
    }
}
