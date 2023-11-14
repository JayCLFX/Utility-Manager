using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Utility
{
    public class Library
    {
        //Paths
        public static Dictionary<string,string> Main_Dictionary = new Dictionary<string,string>();

        //Envoirments
        private static string Software_Path = Environment.CurrentDirectory + "/" + "data";
        private static string Log_Main_Path = Environment.CurrentDirectory + "/" + "log";
        private static string Dictionary_Path = Environment.CurrentDirectory + "/" + "data" + "/" + "save.utility";
        public static string Log_Path = Environment.CurrentDirectory + "/" + "log" + "/" + "log.txt";

        //Sandboxies
        public static string Sandboxie_Path = @"";
        public static string Sandboxie_Browser_Path = @"";

        //Steam
        public static string Steam_Path = @"";

        //Steam Accounts
        public static string Steam_Account_Path = Environment.CurrentDirectory + "/" + "data" + "/" + "accounts.utility";
        public static Dictionary<string, string> Account_Dictionary = new Dictionary<string, string>();

        public static void Initialize_Library()
        {
            Directory.CreateDirectory(Software_Path);
            Directory.CreateDirectory(Log_Main_Path);

            if (File.Exists(Dictionary_Path))
            {
                Load_Dictionary();
            }
            else
            {
                Create_Dictionary();
            }

            foreach(var item in Main_Dictionary)
            {
                if (item.Key == "Sandboxie_Main_Path")
                {
                    Sandboxie_Path = item.Value;
                }

                if (item.Key == "Sandboxie_Browser_Path")
                {
                    Sandboxie_Browser_Path = item.Value;
                }

                if (item.Key == "Steam_Main_Path")
                {
                    Steam_Path = item.Value;
                }
            }
            return;
        }

        public static void Create_Dictionary()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("State the Sandboxies Path to Start.exe:\n");
            Sandboxie_Path = Console.ReadLine(); Console.Clear();
            Console.WriteLine("State a Browser Path used by the Sandboxies:\n");
            Sandboxie_Browser_Path = Console.ReadLine(); Console.Clear();
            Console.WriteLine("State a Steam Path to Steam.exe used by the Sandboxies:\n");
            Steam_Path = Console.ReadLine(); Console.Clear();

            if (Sandboxie_Path != null && Sandboxie_Browser_Path != null && Steam_Path != null)
            {
                Main_Dictionary.Add("Sandboxie_Main_Path", Sandboxie_Path);
                Main_Dictionary.Add("Sandboxie_Browser_Path", Sandboxie_Browser_Path);
                Main_Dictionary.Add("Steam_Main_Path", Steam_Path);
                Save_Dictionary();
            }
            else
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("Something Invalid has been typed!\n\n Press any Key to Close");
                Console.ForegroundColor = ConsoleColor.White;
                Console.ReadLine(); Environment.Exit(0);
            }
            return;
        }

        public static void Load_Dictionary()
        {
            try
            {
                string data = File.ReadAllText(Dictionary_Path);
                Main_Dictionary = JsonConvert.DeserializeObject<Dictionary<string, string>>(data);
            }
            catch (Exception ex)
            {
                Console.ForegroundColor= ConsoleColor.DarkRed;
                Console.WriteLine($"Fatal Error While Loading:  {ex.Message}");
                Console.ForegroundColor = ConsoleColor.White;
                Console.ReadLine(); Environment.Exit(0);
            }
            return;
        }

        public static void Save_Dictionary()
        {
            try
            {
                string data = JsonConvert.SerializeObject(Main_Dictionary, Formatting.Indented);
                File.WriteAllText(Dictionary_Path, data);
            }
            catch (Exception ex)
            {
                Console.ForegroundColor= ConsoleColor.DarkRed;
                Console.WriteLine($"Fatal Error while Saving:  {ex.Message}");
                Console.ForegroundColor = ConsoleColor.White;
                Console.ReadLine(); Environment.Exit(0);
            }
            return;
        }

        public static void Save_Accounts()
        {
            try
            {
                string data = JsonConvert.SerializeObject(Account_Dictionary, Formatting.Indented);
                File.WriteAllText(Steam_Account_Path, data);
            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine($"Fatal Error while Saving Steam Accounts:   {ex.Message}");
                Console.ForegroundColor = ConsoleColor.White;
                Console.ReadLine(); Environment.Exit(0);
            }
        }

        public static void Load_Accounts()
        {
            try
            {
                string data = File.ReadAllText(Steam_Account_Path);
                Account_Dictionary = JsonConvert.DeserializeObject<Dictionary<string, string>>(data);
            }
            catch (Exception ex) 
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine($"Fatal Error while loading Steam Accounts:   {ex.Message}");
                Console.ForegroundColor = ConsoleColor.White;
                Console.ReadLine(); Program.MainProgramm();
            }
            return;
        }
    }
}
