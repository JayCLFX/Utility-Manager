using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace Utility
{
    public class Utility
    {
        public static Process[] processCollection = Process.GetProcesses();
        public static void UtilityMenu()
        {
            System.Timers.Timer timer = new System.Timers.Timer();
            timer.Elapsed += new ElapsedEventHandler(GetProcesses);
            timer.Interval = 100;
            timer.Enabled = true;

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
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(" 1. Setup new Steam Config Json\n 2. Kill Firewall\n 3. Kill CS2 Instances\n 4. Kill Edge Instances\n 5. Kill Steam Instances\n 6. Back\n");

            var answer = Console.ReadLine();
            if (answer == "1") Create_Steam_AccountSaveData();
            if (answer == "2") Kill_Firewall();
            if (answer == "3") Kill_CS2_Instances();
            if (answer == "4") Kill_Edge_Instances();
            if (answer == "5") Kill_Steam_Instances();

            Console.Clear(); Program.MainProgramm();
        }

        public static void Kill_Steam_Instances()
        {
            try
            {
                foreach (Process p in processCollection)
                {
                    if (p.ProcessName == "steam")
                    {
                        p.Kill();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Debug.WriteLine($"An Error Occurred while trying to Kill CS2.exe: {ex.Message}");
                Console.ForegroundColor = ConsoleColor.White;
                Console.ReadLine(); Program.MainProgramm();
            }
            return;
        }

        public static void Kill_Firewall()
        {
            try
            {
                Registry.LocalMachine.CreateSubKey(@"SOFTWARE\Policies\Microsoft\Windows Defender\Real-Time Protection");
                Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\Windows Defender", "DisableAntiSpyware", "1", RegistryValueKind.DWord);
                Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\Windows Defender\\Real-Time Protection", "DisableBehaviorMonitoring", "1", RegistryValueKind.DWord);
                Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\Windows Defender\\Real-Time Protection", "DisableOnAccessProtection", "1", RegistryValueKind.DWord);
                Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\Windows Defender\\Real-Time Protection", "DisableScanOnRealtimeEnable", "1", RegistryValueKind.DWord);
            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine($"Fatal Error while writing Registry Values!  Make sure to deactivate !!Tamper-Protection!! Error-Code:   {ex.Message}");
                Console.ForegroundColor= ConsoleColor.White;
                Console.ReadKey(); UtilityMenu();
            }
            return;
        }

        public static void Kill_CS2_Instances()
        {
            try
            {
                foreach (Process p in processCollection)
                {
                    if (p.ProcessName == "cs2")
                    {
                        p.Kill();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Debug.WriteLine($"An Error Occurred while trying to Kill CS2.exe: {ex.Message}");
                Console.ForegroundColor = ConsoleColor.White;
                Console.ReadLine(); Program.MainProgramm();
            }
            return;
        }

        public static void Kill_Edge_Instances()
        {
            try
            {
                foreach (Process p in processCollection)
                {
                    if (p.ProcessName == "msedge")
                    {
                        p.Kill();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Debug.WriteLine($"An Error Occurred while trying to Kill msedge.exe: {ex.Message}");
                Console.ForegroundColor = ConsoleColor.White;
                Console.ReadLine(); Program.MainProgramm();
            }
            return;
        }

        private static void GetProcesses(object source, ElapsedEventArgs e)
        {
            processCollection = Process.GetProcesses();
        }

        public static void Create_Steam_AccountSaveData()
        {
            try
            {
                Library.Account_Dictionary.Add("Acc01_Username", "Username");
                Library.Account_Dictionary.Add("Acc01_Password", "Password");

                Library.Account_Dictionary.Add("Acc02_Username", "Username");
                Library.Account_Dictionary.Add("Acc02_Password", "Password");

                Library.Account_Dictionary.Add("Acc03_Username", "Username");
                Library.Account_Dictionary.Add("Acc03_Password", "Password");

                Library.Account_Dictionary.Add("Acc04_Username", "Username");
                Library.Account_Dictionary.Add("Acc04_Password", "Password");

                Library.Account_Dictionary.Add("Acc05_Username", "Username");
                Library.Account_Dictionary.Add("Acc05_Password", "Password");

                Library.Account_Dictionary.Add("Acc06_Username", "Username");
                Library.Account_Dictionary.Add("Acc06_Password", "Password");

                Library.Account_Dictionary.Add("Acc07_Username", "Username");
                Library.Account_Dictionary.Add("Acc07_Password", "Password");

                Library.Account_Dictionary.Add("Acc08_Username", "Username");
                Library.Account_Dictionary.Add("Acc08_Password", "Password");

                Library.Account_Dictionary.Add("Acc09_Username", "Username");
                Library.Account_Dictionary.Add("Acc09_Password", "Password");

                Library.Account_Dictionary.Add("Acc10_Username", "Username");
                Library.Account_Dictionary.Add("Acc10_Password", "Password");

                Library.Account_Dictionary.Add("Acc11_Username", "Username");
                Library.Account_Dictionary.Add("Acc11_Password", "Password");

                Library.Account_Dictionary.Add("Acc12_Username", "Username");
                Library.Account_Dictionary.Add("Acc12_Password", "Password");

                Library.Account_Dictionary.Add("Acc13_Username", "Username");
                Library.Account_Dictionary.Add("Acc13_Password", "Password");

                Library.Account_Dictionary.Add("Acc14_Username", "Username");
                Library.Account_Dictionary.Add("Acc14_Password", "Password");

                Library.Account_Dictionary.Add("Acc15_Username", "Username");
                Library.Account_Dictionary.Add("Acc15_Password", "Password");

                Library.Account_Dictionary.Add("Acc16_Username", "Username");
                Library.Account_Dictionary.Add("Acc16_Password", "Password");

                Library.Account_Dictionary.Add("Acc17_Username", "Username");
                Library.Account_Dictionary.Add("Acc17_Password", "Password");

                Library.Account_Dictionary.Add("Acc18_Username", "Username");
                Library.Account_Dictionary.Add("Acc18_Password", "Password");

                Library.Account_Dictionary.Add("Acc19_Username", "Username");
                Library.Account_Dictionary.Add("Acc19_Password", "Password");

                Library.Account_Dictionary.Add("Acc20_Username", "Username");
                Library.Account_Dictionary.Add("Acc20_Password", "Password");

                Library.Save_Accounts();
            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine($"Fatal Error while Creating Steam Accounts:   {ex.Message}");
                Console.ForegroundColor = ConsoleColor.White;
                Console.ReadLine(); UtilityMenu();
            }
            return;
        }
    }
}
