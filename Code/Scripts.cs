using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace Utility
{
    public class Scripts
    {
        public static Process[] processCollection = Process.GetProcesses();
        public static int Counter = 0;

        [DllImport("user32.dll")]
        static extern short GetAsyncKeyState(int vkey);

        [DllImport("user32.dll")]
        static extern void mouse_event(uint dwFlags, int dx, int dy, int dwData, int dwExtraInfo);


        public static void Scripts_Menu()
        {
            Console.WriteLine("This part is unfinnished!");
            Console.ReadLine(); Program.MainProgramm();

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
            Console.WriteLine($" 1. Edge View Generator\n 5. Back");
            var answer = Console.ReadLine();
            if (answer == "1") Edge_Script();

            Program.MainProgramm();
        }

        public static void Edge_Script()
        {

            System.Timers.Timer timer = new System.Timers.Timer();
            timer.Elapsed += new ElapsedEventHandler(GetProcesses);
            timer.Interval = 100;
            timer.Enabled = true;

            Console.WriteLine("State Youtube URL:\n");
            Edge.URL = Console.ReadLine(); Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Script is active! Press Escape Key to exit out of function");
            Console.ForegroundColor = ConsoleColor.White;

            var task = Task.Run((Func<Task>)Edge.Edge_Instances);
            task.Wait();
            Thread.Sleep(900000);

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
                Console.WriteLine($"Error while using Script, cant kill msedge.exe:   {ex.Message}");
                Console.ForegroundColor = ConsoleColor.White;
                Scripts_Menu();
            }

            LogWrite($"Script has done its cycle (Edge Script) {Counter} Times!\n");
            Edge_Script();
        }


        private static void GetProcesses(object source, ElapsedEventArgs e)
        {
            processCollection = Process.GetProcesses();

            if (GetAsyncKeyState(0x1B) < 0)
            {
                Console.Clear();
                Console.WriteLine("Attempting to Shutdown Edge Script");

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
                    Console.WriteLine($"Shutdown unsuccessful!:  {ex.Message}");
                    Console.ForegroundColor = ConsoleColor.White;
                }

                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Successfull");
                Console.ForegroundColor = ConsoleColor.White;
                Thread.Sleep(10000);
                Scripts_Menu();
            }
        }

        public static void LogWrite(string logMessage)
        {
            try
            {
                using (StreamWriter w = File.AppendText(Library.Log_Path))
                {
                    Log(logMessage, w);
                }
            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine($"Cant make log File:   {ex.Message}");
                Console.ForegroundColor = ConsoleColor.White;
            }
        }

        public static void Log(string logMessage, TextWriter txtWriter)
        {
            try
            {
                txtWriter.WriteLine(logMessage);
            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine($"Cant make log File:   {ex.Message}");
                Console.ForegroundColor = ConsoleColor.White;
            }
        }
    }
}
