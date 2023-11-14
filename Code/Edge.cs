using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utility
{
    public class Edge
    {
        private static string Sandboxie_Path = null;
        private static string Browser = null;
        public static string URL = null;

        public static string Start_Edge_Instances()
        {
            try
            {
                Sandboxie_Path = Library.Sandboxie_Path;
                Browser = Library.Sandboxie_Browser_Path;
                URL = "";
                Console.WriteLine("State an Url:");
                URL = Console.ReadLine();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Clear(); Console.WriteLine("This Operation will take some time arround 30 seconds to a minute!");

                var task = Task.Run((Func<Task>)Edge_Instances);
                task.Wait();
                Console.Clear(); Console.WriteLine("Successfully Opened all Operations"); Console.ForegroundColor = ConsoleColor.White;
            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine(ex.Message);
                Console.ForegroundColor = ConsoleColor.White; Console.ReadLine();
                return "Error";
            }
            return "Success";
        }



        public static async Task Edge_Instances()
        {
            try
            {
                System.Diagnostics.Process Edge01 = new System.Diagnostics.Process();
                Edge01.StartInfo.FileName = Sandboxie_Path;
                Edge01.StartInfo.Arguments = $"/box:Edge01 \"{Browser}\" {URL}";
                Edge01.Start();
                Thread.Sleep(1000);

                System.Diagnostics.Process Edge02 = new System.Diagnostics.Process();
                Edge02.StartInfo.FileName = Sandboxie_Path;
                Edge02.StartInfo.Arguments = $"/box:Edge02 \"{Browser}\" {URL}";
                Edge02.Start();
                Thread.Sleep(1000);

                System.Diagnostics.Process Edge03 = new System.Diagnostics.Process();
                Edge03.StartInfo.FileName = Sandboxie_Path;
                Edge03.StartInfo.Arguments = $"/box:Edge03 \"{Browser}\" {URL}";
                Edge03.Start();
                Thread.Sleep(1000);

                System.Diagnostics.Process Edge04 = new System.Diagnostics.Process();
                Edge04.StartInfo.FileName = Sandboxie_Path;
                Edge04.StartInfo.Arguments = $"/box:Edge04 \"{Browser}\" {URL}";
                Edge04.Start();
                Thread.Sleep(1000);

                System.Diagnostics.Process Edge05 = new System.Diagnostics.Process();
                Edge05.StartInfo.FileName = Sandboxie_Path;
                Edge05.StartInfo.Arguments = $"/box:Edge05 \"{Browser}\" {URL}";
                Edge05.Start();
                Thread.Sleep(1000);

                System.Diagnostics.Process Edge06 = new System.Diagnostics.Process();
                Edge06.StartInfo.FileName = Sandboxie_Path;
                Edge06.StartInfo.Arguments = $"/box:Edge06 \"{Browser}\" {URL}";
                Edge06.Start();
                Thread.Sleep(1000);

                System.Diagnostics.Process Edge07 = new System.Diagnostics.Process();
                Edge07.StartInfo.FileName = Sandboxie_Path;
                Edge07.StartInfo.Arguments = $"/box:Edge07 \"{Browser}\" {URL}";
                Edge07.Start();
                Thread.Sleep(1000);

                System.Diagnostics.Process Edge08 = new System.Diagnostics.Process();
                Edge08.StartInfo.FileName = Sandboxie_Path;
                Edge08.StartInfo.Arguments = $"/box:Edge08 \"{Browser}\" {URL}";
                Edge08.Start();
                Thread.Sleep(1000);

                System.Diagnostics.Process Edge09 = new System.Diagnostics.Process();
                Edge09.StartInfo.FileName = Sandboxie_Path;
                Edge09.StartInfo.Arguments = $"/box:Edge09 \"{Browser}\" {URL}";
                Edge09.Start();
                Thread.Sleep(1000);

                System.Diagnostics.Process Edge10 = new System.Diagnostics.Process();
                Edge10.StartInfo.FileName = Sandboxie_Path;
                Edge10.StartInfo.Arguments = $"/box:Edge10 \"{Browser}\" {URL}";
                Edge10.Start();
                Thread.Sleep(1000);

                System.Diagnostics.Process Edge11 = new System.Diagnostics.Process();
                Edge11.StartInfo.FileName = Sandboxie_Path;
                Edge11.StartInfo.Arguments = $"/box:Edge11 \"{Browser}\" {URL}";
                Edge11.Start();
                Thread.Sleep(1000);

                System.Diagnostics.Process Edge12 = new System.Diagnostics.Process();
                Edge12.StartInfo.FileName = Sandboxie_Path;
                Edge12.StartInfo.Arguments = $"/box:Edge12 \"{Browser}\" {URL}";
                Edge12.Start();
                Thread.Sleep(1000);

                System.Diagnostics.Process Edge13 = new System.Diagnostics.Process();
                Edge13.StartInfo.FileName = Sandboxie_Path;
                Edge13.StartInfo.Arguments = $"/box:Edge13 \"{Browser}\" {URL}";
                Edge13.Start();
                Thread.Sleep(1000);

                System.Diagnostics.Process Edge14 = new System.Diagnostics.Process();
                Edge14.StartInfo.FileName = Sandboxie_Path;
                Edge14.StartInfo.Arguments = $"/box:Edge14 \"{Browser}\" {URL}";
                Edge14.Start();
                Thread.Sleep(1000);

                System.Diagnostics.Process Edge15 = new System.Diagnostics.Process();
                Edge15.StartInfo.FileName = Sandboxie_Path;
                Edge15.StartInfo.Arguments = $"/box:Edge15 \"{Browser}\" {URL}";
                Edge15.Start();
                Thread.Sleep(1000);

                System.Diagnostics.Process Edge16 = new System.Diagnostics.Process();
                Edge16.StartInfo.FileName = Sandboxie_Path;
                Edge16.StartInfo.Arguments = $"/box:Edge16 \"{Browser}\" {URL}";
                Edge16.Start();
                Thread.Sleep(1000);

                System.Diagnostics.Process Edge17 = new System.Diagnostics.Process();
                Edge17.StartInfo.FileName = Sandboxie_Path;
                Edge17.StartInfo.Arguments = $"/box:Edge17 \"{Browser}\" {URL}";
                Edge17.Start();
                Thread.Sleep(1000);

                System.Diagnostics.Process Edge18 = new System.Diagnostics.Process();
                Edge18.StartInfo.FileName = Sandboxie_Path;
                Edge18.StartInfo.Arguments = $"/box:Edge18 \"{Browser}\" {URL}";
                Edge18.Start();
                Thread.Sleep(1000);

                System.Diagnostics.Process Edge19 = new System.Diagnostics.Process();
                Edge19.StartInfo.FileName = Sandboxie_Path;
                Edge19.StartInfo.Arguments = $"/box:Edge19 \"{Browser}\" {URL}";
                Edge19.Start();
                Thread.Sleep(1000);

                System.Diagnostics.Process Edge20 = new System.Diagnostics.Process();
                Edge20.StartInfo.FileName = Sandboxie_Path;
                Edge20.StartInfo.Arguments = $"/box:Edge20 \"{Browser}\" {URL}";
                Edge20.Start();
                Thread.Sleep(1000);

                System.Diagnostics.Process Edge21 = new System.Diagnostics.Process();
                Edge21.StartInfo.FileName = Sandboxie_Path;
                Edge21.StartInfo.Arguments = $"/box:Edge21 \"{Browser}\" {URL}";
                Edge21.Start();
                Thread.Sleep(1000);

                System.Diagnostics.Process Edge22 = new System.Diagnostics.Process();
                Edge22.StartInfo.FileName = Sandboxie_Path;
                Edge22.StartInfo.Arguments = $"/box:Edge22 \"{Browser}\" {URL}";
                Edge22.Start();
                Thread.Sleep(1000);

                System.Diagnostics.Process Edge23 = new System.Diagnostics.Process();
                Edge23.StartInfo.FileName = Sandboxie_Path;
                Edge23.StartInfo.Arguments = $"/box:Edge23 \"{Browser}\" {URL}";
                Edge23.Start();
                Thread.Sleep(1000);

                System.Diagnostics.Process Edge24 = new System.Diagnostics.Process();
                Edge24.StartInfo.FileName = Sandboxie_Path;
                Edge24.StartInfo.Arguments = $"/box:Edge24 \"{Browser}\" {URL}";
                Edge24.Start();
                Thread.Sleep(1000);
            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine(ex.Message);
                Console.ForegroundColor= ConsoleColor.White;
                Console.ReadLine(); return;
            }
            return;
        }
    }
}
