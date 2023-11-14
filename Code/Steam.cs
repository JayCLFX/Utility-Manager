using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utility
{
    public class Steam
    {

        private static string Steam_Path = null;
        public static string Sanboxie_Path = null;

        private static string Minigame_List_Arguments = @"-dev -nofriendsui -no-dwrite -nointro -nobigpicture -nofasthtml -nocrashmonitor -noshaders -no-shared-textures -disablehighdpi -cef-disable-d3d11 +open steam://open/minigameslist -noreactlogin -no-browser -login";
        private static string Silent_List_Arguments = @"-dev -nofriendsui -no-dwrite -nointro -nobigpicture -nofasthtml -nocrashmonitor -noshaders -no-shared-textures -disablehighdpi -cef-disable-d3d11 -silent -noreactlogin -no-browser -login";
        private static string CS2_List_Arguments = @"-dev -nofriendsui -no-dwrite -nointro -nobigpicture -nofasthtml -nocrashmonitor -noshaders -no-shared-textures -disablehighdpi -cef-disable-d3d11 +open steam://rungameid/730 -noreactlogin -no-browser -login";

        private static string acc01_username = null; private static string acc01_password = null;
        private static string acc02_username = null; private static string acc02_password = null;
        private static string acc03_username = null; private static string acc03_password = null;
        private static string acc04_username = null; private static string acc04_password = null;
        private static string acc05_username = null; private static string acc05_password = null;
        private static string acc06_username = null; private static string acc06_password = null;
        private static string acc07_username = null; private static string acc07_password = null;
        private static string acc08_username = null; private static string acc08_password = null;
        private static string acc09_username = null; private static string acc09_password = null;
        private static string acc10_username = null; private static string acc10_password = null;
        private static string acc11_username = null; private static string acc11_password = null;
        private static string acc12_username = null; private static string acc12_password = null;
        private static string acc13_username = null; private static string acc13_password = null;
        private static string acc14_username = null; private static string acc14_password = null;
        private static string acc15_username = null; private static string acc15_password = null;
        private static string acc16_username = null; private static string acc16_password = null;
        private static string acc17_username = null; private static string acc17_password = null;
        private static string acc18_username = null; private static string acc18_password = null;
        private static string acc19_username = null; private static string acc19_password = null;
        private static string acc20_username = null; private static string acc20_password = null;

        public static string Start_Steam_Instances_MinigameList()
        {
            Steam_Path = Library.Steam_Path;
            Sanboxie_Path = Library.Sandboxie_Path;
            try
            {
                var task = Task.Run((Func<Task>)Steam_Instances_Miningamelist);
                task.Wait();
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

        public static string Start_Steam_Instances_Silent()
        {
            Steam_Path = Library.Steam_Path;
            Sanboxie_Path = Library.Sandboxie_Path;
            try
            {
                var task = Task.Run((Func<Task>)Steam_Instances_Silent);
                task.Wait();
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

        public static string Start_Steam_Instances_CS2()
        {
            Steam_Path = Library.Steam_Path;
            Sanboxie_Path = Library.Sandboxie_Path;
            try
            {
                var task = Task.Run((Func<Task>)Steam_Instances_CS2);
                task.Wait();
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

        private static async Task Steam_Instances_Miningamelist()
        {
            Library.Account_Dictionary.Clear(); Thread.Sleep(1000);
            Library.Load_Accounts();
            var task = Task.Run((Func<Task>)PrepareUsers);
            task.Wait();

            try
            {
                if (acc01_username != null && acc01_password != null)
                {
                    System.Diagnostics.Process SteamProcess = new System.Diagnostics.Process();
                    SteamProcess.StartInfo.FileName = Sanboxie_Path;
                    SteamProcess.StartInfo.Arguments = $"/box:Steam01 \"{Steam_Path}\" {Minigame_List_Arguments} {acc01_username} {acc01_password}";
                    SteamProcess.Start();
                    Thread.Sleep(1000);
                }

                if (acc02_username != null && acc02_password != null)
                {
                    System.Diagnostics.Process SteamProcess = new System.Diagnostics.Process();
                    SteamProcess.StartInfo.FileName = Sanboxie_Path;
                    SteamProcess.StartInfo.Arguments = $"/box:Steam02 \"{Steam_Path}\" {Minigame_List_Arguments} {acc02_username} {acc02_password}";
                    SteamProcess.Start();
                    Thread.Sleep(1000);
                }

                if (acc03_username != null && acc03_password != null)
                {
                    System.Diagnostics.Process SteamProcess = new System.Diagnostics.Process();
                    SteamProcess.StartInfo.FileName = Sanboxie_Path;
                    SteamProcess.StartInfo.Arguments = $"/box:Steam03 \"{Steam_Path}\" {Minigame_List_Arguments} {acc03_username} {acc03_password}";
                    SteamProcess.Start();
                    Thread.Sleep(1000);
                }

                if (acc04_username != null && acc04_password != null)
                {
                    System.Diagnostics.Process SteamProcess = new System.Diagnostics.Process();
                    SteamProcess.StartInfo.FileName = Sanboxie_Path;
                    SteamProcess.StartInfo.Arguments = $"/box:Steam04 \"{Steam_Path}\" {Minigame_List_Arguments} {acc04_username} {acc04_password}";
                    SteamProcess.Start();
                    Thread.Sleep(1000);
                }

                if (acc05_username != null && acc05_password != null)
                {
                    System.Diagnostics.Process SteamProcess = new System.Diagnostics.Process();
                    SteamProcess.StartInfo.FileName = Sanboxie_Path;
                    SteamProcess.StartInfo.Arguments = $"/box:Steam05 \"{Steam_Path}\" {Minigame_List_Arguments} {acc05_username} {acc05_password}";
                    SteamProcess.Start();
                    Thread.Sleep(1000);
                }

                if (acc06_username != null && acc06_password != null)
                {
                    System.Diagnostics.Process SteamProcess = new System.Diagnostics.Process();
                    SteamProcess.StartInfo.FileName = Sanboxie_Path;
                    SteamProcess.StartInfo.Arguments = $"/box:Steam06 \"{Steam_Path}\" {Minigame_List_Arguments} {acc06_username} {acc06_password}";
                    SteamProcess.Start();
                    Thread.Sleep(1000);
                }

                if (acc07_username != null && acc07_password != null)
                {
                    System.Diagnostics.Process SteamProcess = new System.Diagnostics.Process();
                    SteamProcess.StartInfo.FileName = Sanboxie_Path;
                    SteamProcess.StartInfo.Arguments = $"/box:Steam07 \"{Steam_Path}\" {Minigame_List_Arguments} {acc07_username} {acc07_password}";
                    SteamProcess.Start();
                    Thread.Sleep(1000);
                }

                if (acc08_username != null && acc08_password != null)
                {
                    System.Diagnostics.Process SteamProcess = new System.Diagnostics.Process();
                    SteamProcess.StartInfo.FileName = Sanboxie_Path;
                    SteamProcess.StartInfo.Arguments = $"/box:Steam08 \"{Steam_Path}\" {Minigame_List_Arguments} {acc08_username} {acc08_password}";
                    SteamProcess.Start();
                    Thread.Sleep(1000);
                }

                if (acc09_username != null && acc09_password != null)
                {
                    System.Diagnostics.Process SteamProcess = new System.Diagnostics.Process();
                    SteamProcess.StartInfo.FileName = Sanboxie_Path;
                    SteamProcess.StartInfo.Arguments = $"/box:Steam09 \"{Steam_Path}\" {Minigame_List_Arguments} {acc09_username} {acc09_password}";
                    SteamProcess.Start();
                    Thread.Sleep(1000);
                }

                if (acc10_username != null && acc10_password != null)
                {
                    System.Diagnostics.Process SteamProcess = new System.Diagnostics.Process();
                    SteamProcess.StartInfo.FileName = Sanboxie_Path;
                    SteamProcess.StartInfo.Arguments = $"/box:Steam10 \"{Steam_Path}\" {Minigame_List_Arguments} {acc10_username} {acc10_password}";
                    SteamProcess.Start();
                    Thread.Sleep(1000);
                }

                if (acc11_username != null && acc11_password != null)
                {
                    System.Diagnostics.Process SteamProcess = new System.Diagnostics.Process();
                    SteamProcess.StartInfo.FileName = Sanboxie_Path;
                    SteamProcess.StartInfo.Arguments = $"/box:Steam11 \"{Steam_Path}\" {Minigame_List_Arguments} {acc11_username} {acc11_password}";
                    SteamProcess.Start();
                    Thread.Sleep(1000);
                }

                if (acc12_username != null && acc12_password != null)
                {
                    System.Diagnostics.Process SteamProcess = new System.Diagnostics.Process();
                    SteamProcess.StartInfo.FileName = Sanboxie_Path;
                    SteamProcess.StartInfo.Arguments = $"/box:Steam12 \"{Steam_Path}\" {Minigame_List_Arguments} {acc12_username} {acc12_password}";
                    SteamProcess.Start();
                    Thread.Sleep(1000);
                }

                if (acc13_username != null && acc13_password != null)
                {
                    System.Diagnostics.Process SteamProcess = new System.Diagnostics.Process();
                    SteamProcess.StartInfo.FileName = Sanboxie_Path;
                    SteamProcess.StartInfo.Arguments = $"/box:Steam13 \"{Steam_Path}\" {Minigame_List_Arguments} {acc13_username} {acc13_password}";
                    SteamProcess.Start();
                    Thread.Sleep(1000);
                }

                if (acc14_username != null && acc14_password != null)
                {
                    System.Diagnostics.Process SteamProcess = new System.Diagnostics.Process();
                    SteamProcess.StartInfo.FileName = Sanboxie_Path;
                    SteamProcess.StartInfo.Arguments = $"/box:Steam14 \"{Steam_Path}\" {Minigame_List_Arguments} {acc14_username} {acc14_password}";
                    SteamProcess.Start();
                    Thread.Sleep(1000);
                }

                if (acc15_username != null && acc15_password != null)
                {
                    System.Diagnostics.Process SteamProcess = new System.Diagnostics.Process();
                    SteamProcess.StartInfo.FileName = Sanboxie_Path;
                    SteamProcess.StartInfo.Arguments = $"/box:Steam15 \"{Steam_Path}\" {Minigame_List_Arguments} {acc15_username} {acc15_password}";
                    SteamProcess.Start();
                    Thread.Sleep(1000);
                }

                if (acc16_username != null && acc16_password != null)
                {
                    System.Diagnostics.Process SteamProcess = new System.Diagnostics.Process();
                    SteamProcess.StartInfo.FileName = Sanboxie_Path;
                    SteamProcess.StartInfo.Arguments = $"/box:Steam16 \"{Steam_Path}\" {Minigame_List_Arguments} {acc16_username} {acc16_password}";
                    SteamProcess.Start();
                    Thread.Sleep(1000);
                }

                if (acc17_username != null && acc17_password != null)
                {
                    System.Diagnostics.Process SteamProcess = new System.Diagnostics.Process();
                    SteamProcess.StartInfo.FileName = Sanboxie_Path;
                    SteamProcess.StartInfo.Arguments = $"/box:Steam17 \"{Steam_Path}\" {Minigame_List_Arguments} {acc17_username} {acc17_password}";
                    SteamProcess.Start();
                    Thread.Sleep(1000);
                }

                if (acc18_username != null && acc18_password != null)
                {
                    System.Diagnostics.Process SteamProcess = new System.Diagnostics.Process();
                    SteamProcess.StartInfo.FileName = Sanboxie_Path;
                    SteamProcess.StartInfo.Arguments = $"/box:Steam18 \"{Steam_Path}\" {Minigame_List_Arguments} {acc18_username} {acc18_password}";
                    SteamProcess.Start();
                    Thread.Sleep(1000);
                }

                if (acc19_username != null && acc19_password != null)
                {
                    System.Diagnostics.Process SteamProcess = new System.Diagnostics.Process();
                    SteamProcess.StartInfo.FileName = Sanboxie_Path;
                    SteamProcess.StartInfo.Arguments = $"/box:Steam19 \"{Steam_Path}\" {Minigame_List_Arguments} {acc19_username} {acc19_password}";
                    SteamProcess.Start();
                    Thread.Sleep(1000);
                }

                if (acc20_username != null && acc20_password != null)
                {
                    System.Diagnostics.Process SteamProcess = new System.Diagnostics.Process();
                    SteamProcess.StartInfo.FileName = Sanboxie_Path;
                    SteamProcess.StartInfo.Arguments = $"/box:Steam20 \"{Steam_Path}\" {Minigame_List_Arguments} {acc20_username} {acc20_password}";
                    SteamProcess.Start();
                    Thread.Sleep(1000);
                }
            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine($"Fatal Error while starting Steam: {ex.Message}");
                Console.ForegroundColor = ConsoleColor.White;
            }
            return;
        }

        private static async Task Steam_Instances_Silent()
        {
            Library.Account_Dictionary.Clear(); Thread.Sleep(1000);
            Library.Load_Accounts();
            var task = Task.Run((Func<Task>)PrepareUsers);
            task.Wait();

            try
            {
                if (acc01_username != null && acc01_password != null)
                {
                    System.Diagnostics.Process SteamProcess = new System.Diagnostics.Process();
                    SteamProcess.StartInfo.FileName = Sanboxie_Path;
                    SteamProcess.StartInfo.Arguments = $"/box:Steam01 \"{Steam_Path}\" {Silent_List_Arguments} {acc01_username} {acc01_password}";
                    SteamProcess.Start();
                    Thread.Sleep(1000);
                }

                if (acc02_username != null && acc02_password != null)
                {
                    System.Diagnostics.Process SteamProcess = new System.Diagnostics.Process();
                    SteamProcess.StartInfo.FileName = Sanboxie_Path;
                    SteamProcess.StartInfo.Arguments = $"/box:Steam02 \"{Steam_Path}\" {Silent_List_Arguments} {acc02_username} {acc02_password}";
                    SteamProcess.Start();
                    Thread.Sleep(1000);
                }

                if (acc03_username != null && acc03_password != null)
                {
                    System.Diagnostics.Process SteamProcess = new System.Diagnostics.Process();
                    SteamProcess.StartInfo.FileName = Sanboxie_Path;
                    SteamProcess.StartInfo.Arguments = $"/box:Steam03 \"{Steam_Path}\" {Silent_List_Arguments} {acc03_username} {acc03_password}";
                    SteamProcess.Start();
                    Thread.Sleep(1000);
                }

                if (acc04_username != null && acc04_password != null)
                {
                    System.Diagnostics.Process SteamProcess = new System.Diagnostics.Process();
                    SteamProcess.StartInfo.FileName = Sanboxie_Path;
                    SteamProcess.StartInfo.Arguments = $"/box:Steam04 \"{Steam_Path}\" {Silent_List_Arguments} {acc04_username} {acc04_password}";
                    SteamProcess.Start();
                    Thread.Sleep(1000);
                }

                if (acc05_username != null && acc05_password != null)
                {
                    System.Diagnostics.Process SteamProcess = new System.Diagnostics.Process();
                    SteamProcess.StartInfo.FileName = Sanboxie_Path;
                    SteamProcess.StartInfo.Arguments = $"/box:Steam05 \"{Steam_Path}\" {Silent_List_Arguments} {acc05_username} {acc05_password}";
                    SteamProcess.Start();
                    Thread.Sleep(1000);
                }

                if (acc06_username != null && acc06_password != null)
                {
                    System.Diagnostics.Process SteamProcess = new System.Diagnostics.Process();
                    SteamProcess.StartInfo.FileName = Sanboxie_Path;
                    SteamProcess.StartInfo.Arguments = $"/box:Steam06 \"{Steam_Path}\" {Silent_List_Arguments} {acc06_username} {acc06_password}";
                    SteamProcess.Start();
                    Thread.Sleep(1000);
                }

                if (acc07_username != null && acc07_password != null)
                {
                    System.Diagnostics.Process SteamProcess = new System.Diagnostics.Process();
                    SteamProcess.StartInfo.FileName = Sanboxie_Path;
                    SteamProcess.StartInfo.Arguments = $"/box:Steam07 \"{Steam_Path}\" {Silent_List_Arguments} {acc07_username} {acc07_password}";
                    SteamProcess.Start();
                    Thread.Sleep(1000);
                }

                if (acc08_username != null && acc08_password != null)
                {
                    System.Diagnostics.Process SteamProcess = new System.Diagnostics.Process();
                    SteamProcess.StartInfo.FileName = Sanboxie_Path;
                    SteamProcess.StartInfo.Arguments = $"/box:Steam08 \"{Steam_Path}\" {Silent_List_Arguments} {acc08_username} {acc08_password}";
                    SteamProcess.Start();
                    Thread.Sleep(1000);
                }

                if (acc09_username != null && acc09_password != null)
                {
                    System.Diagnostics.Process SteamProcess = new System.Diagnostics.Process();
                    SteamProcess.StartInfo.FileName = Sanboxie_Path;
                    SteamProcess.StartInfo.Arguments = $"/box:Steam09 \"{Steam_Path}\" {Silent_List_Arguments} {acc09_username} {acc09_password}";
                    SteamProcess.Start();
                    Thread.Sleep(1000);
                }

                if (acc10_username != null && acc10_password != null)
                {
                    System.Diagnostics.Process SteamProcess = new System.Diagnostics.Process();
                    SteamProcess.StartInfo.FileName = Sanboxie_Path;
                    SteamProcess.StartInfo.Arguments = $"/box:Steam10 \"{Steam_Path}\" {Silent_List_Arguments} {acc10_username} {acc10_password}";
                    SteamProcess.Start();
                    Thread.Sleep(1000);
                }

                if (acc11_username != null && acc11_password != null)
                {
                    System.Diagnostics.Process SteamProcess = new System.Diagnostics.Process();
                    SteamProcess.StartInfo.FileName = Sanboxie_Path;
                    SteamProcess.StartInfo.Arguments = $"/box:Steam11 \"{Steam_Path}\" {Silent_List_Arguments} {acc11_username} {acc11_password}";
                    SteamProcess.Start();
                    Thread.Sleep(1000);
                }

                if (acc12_username != null && acc12_password != null)
                {
                    System.Diagnostics.Process SteamProcess = new System.Diagnostics.Process();
                    SteamProcess.StartInfo.FileName = Sanboxie_Path;
                    SteamProcess.StartInfo.Arguments = $"/box:Steam12 \"{Steam_Path}\" {Silent_List_Arguments} {acc12_username} {acc12_password}";
                    SteamProcess.Start();
                    Thread.Sleep(1000);
                }

                if (acc13_username != null && acc13_password != null)
                {
                    System.Diagnostics.Process SteamProcess = new System.Diagnostics.Process();
                    SteamProcess.StartInfo.FileName = Sanboxie_Path;
                    SteamProcess.StartInfo.Arguments = $"/box:Steam13 \"{Steam_Path}\" {Silent_List_Arguments} {acc13_username} {acc13_password}";
                    SteamProcess.Start();
                    Thread.Sleep(1000);
                }

                if (acc14_username != null && acc14_password != null)
                {
                    System.Diagnostics.Process SteamProcess = new System.Diagnostics.Process();
                    SteamProcess.StartInfo.FileName = Sanboxie_Path;
                    SteamProcess.StartInfo.Arguments = $"/box:Steam14 \"{Steam_Path}\" {Silent_List_Arguments} {acc14_username} {acc14_password}";
                    SteamProcess.Start();
                    Thread.Sleep(1000);
                }

                if (acc15_username != null && acc15_password != null)
                {
                    System.Diagnostics.Process SteamProcess = new System.Diagnostics.Process();
                    SteamProcess.StartInfo.FileName = Sanboxie_Path;
                    SteamProcess.StartInfo.Arguments = $"/box:Steam15 \"{Steam_Path}\" {Silent_List_Arguments} {acc15_username} {acc15_password}";
                    SteamProcess.Start();
                    Thread.Sleep(1000);
                }

                if (acc16_username != null && acc16_password != null)
                {
                    System.Diagnostics.Process SteamProcess = new System.Diagnostics.Process();
                    SteamProcess.StartInfo.FileName = Sanboxie_Path;
                    SteamProcess.StartInfo.Arguments = $"/box:Steam16 \"{Steam_Path}\" {Silent_List_Arguments} {acc16_username} {acc16_password}";
                    SteamProcess.Start();
                    Thread.Sleep(1000);
                }

                if (acc17_username != null && acc17_password != null)
                {
                    System.Diagnostics.Process SteamProcess = new System.Diagnostics.Process();
                    SteamProcess.StartInfo.FileName = Sanboxie_Path;
                    SteamProcess.StartInfo.Arguments = $"/box:Steam17 \"{Steam_Path}\" {Silent_List_Arguments} {acc17_username} {acc17_password}";
                    SteamProcess.Start();
                    Thread.Sleep(1000);
                }

                if (acc18_username != null && acc18_password != null)
                {
                    System.Diagnostics.Process SteamProcess = new System.Diagnostics.Process();
                    SteamProcess.StartInfo.FileName = Sanboxie_Path;
                    SteamProcess.StartInfo.Arguments = $"/box:Steam18 \"{Steam_Path}\" {Silent_List_Arguments} {acc18_username} {acc18_password}";
                    SteamProcess.Start();
                    Thread.Sleep(1000);
                }

                if (acc19_username != null && acc19_password != null)
                {
                    System.Diagnostics.Process SteamProcess = new System.Diagnostics.Process();
                    SteamProcess.StartInfo.FileName = Sanboxie_Path;
                    SteamProcess.StartInfo.Arguments = $"/box:Steam19 \"{Steam_Path}\" {Silent_List_Arguments} {acc19_username} {acc19_password}";
                    SteamProcess.Start();
                    Thread.Sleep(1000);
                }

                if (acc20_username != null && acc20_password != null)
                {
                    System.Diagnostics.Process SteamProcess = new System.Diagnostics.Process();
                    SteamProcess.StartInfo.FileName = Sanboxie_Path;
                    SteamProcess.StartInfo.Arguments = $"/box:Steam20 \"{Steam_Path}\" {Silent_List_Arguments} {acc20_username} {acc20_password}";
                    SteamProcess.Start();
                    Thread.Sleep(1000);
                }
            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine($"Fatal Error while starting Steam: {ex.Message}");
                Console.ForegroundColor = ConsoleColor.White;
            }
            return;
        }

        private static async Task Steam_Instances_CS2()
        {
            Library.Account_Dictionary.Clear(); Thread.Sleep(1000);
            Library.Load_Accounts();
            var task = Task.Run((Func<Task>)PrepareUsers);
            task.Wait();

            try
            {
                if (acc01_username != null && acc01_password != null)
                {
                    System.Diagnostics.Process SteamProcess = new System.Diagnostics.Process();
                    SteamProcess.StartInfo.FileName = Sanboxie_Path;
                    SteamProcess.StartInfo.Arguments = $"/box:Steam01 \"{Steam_Path}\" {CS2_List_Arguments} {acc01_username} {acc01_password}";
                    SteamProcess.Start();
                    Thread.Sleep(1000);
                }

                if (acc02_username != null && acc02_password != null)
                {
                    System.Diagnostics.Process SteamProcess = new System.Diagnostics.Process();
                    SteamProcess.StartInfo.FileName = Sanboxie_Path;
                    SteamProcess.StartInfo.Arguments = $"/box:Steam02 \"{Steam_Path}\" {CS2_List_Arguments} {acc02_username} {acc02_password}";
                    SteamProcess.Start();
                    Thread.Sleep(1000);
                }

                if (acc03_username != null && acc03_password != null)
                {
                    System.Diagnostics.Process SteamProcess = new System.Diagnostics.Process();
                    SteamProcess.StartInfo.FileName = Sanboxie_Path;
                    SteamProcess.StartInfo.Arguments = $"/box:Steam03 \"{Steam_Path}\" {CS2_List_Arguments} {acc03_username} {acc03_password}";
                    SteamProcess.Start();
                    Thread.Sleep(1000);
                }

                if (acc04_username != null && acc04_password != null)
                {
                    System.Diagnostics.Process SteamProcess = new System.Diagnostics.Process();
                    SteamProcess.StartInfo.FileName = Sanboxie_Path;
                    SteamProcess.StartInfo.Arguments = $"/box:Steam04 \"{Steam_Path}\" {CS2_List_Arguments} {acc04_username} {acc04_password}";
                    SteamProcess.Start();
                    Thread.Sleep(1000);
                }

                if (acc05_username != null && acc05_password != null)
                {
                    System.Diagnostics.Process SteamProcess = new System.Diagnostics.Process();
                    SteamProcess.StartInfo.FileName = Sanboxie_Path;
                    SteamProcess.StartInfo.Arguments = $"/box:Steam05 \"{Steam_Path}\" {CS2_List_Arguments} {acc05_username} {acc05_password}";
                    SteamProcess.Start();
                    Thread.Sleep(1000);
                }

                if (acc06_username != null && acc06_password != null)
                {
                    System.Diagnostics.Process SteamProcess = new System.Diagnostics.Process();
                    SteamProcess.StartInfo.FileName = Sanboxie_Path;
                    SteamProcess.StartInfo.Arguments = $"/box:Steam06 \"{Steam_Path}\" {CS2_List_Arguments} {acc06_username} {acc06_password}";
                    SteamProcess.Start();
                    Thread.Sleep(1000);
                }

                if (acc07_username != null && acc07_password != null)
                {
                    System.Diagnostics.Process SteamProcess = new System.Diagnostics.Process();
                    SteamProcess.StartInfo.FileName = Sanboxie_Path;
                    SteamProcess.StartInfo.Arguments = $"/box:Steam07 \"{Steam_Path}\" {CS2_List_Arguments} {acc07_username} {acc07_password}";
                    SteamProcess.Start();
                    Thread.Sleep(1000);
                }

                if (acc08_username != null && acc08_password != null)
                {
                    System.Diagnostics.Process SteamProcess = new System.Diagnostics.Process();
                    SteamProcess.StartInfo.FileName = Sanboxie_Path;
                    SteamProcess.StartInfo.Arguments = $"/box:Steam08 \"{Steam_Path}\" {CS2_List_Arguments} {acc08_username} {acc08_password}";
                    SteamProcess.Start();
                    Thread.Sleep(1000);
                }

                if (acc09_username != null && acc09_password != null)
                {
                    System.Diagnostics.Process SteamProcess = new System.Diagnostics.Process();
                    SteamProcess.StartInfo.FileName = Sanboxie_Path;
                    SteamProcess.StartInfo.Arguments = $"/box:Steam09 \"{Steam_Path}\" {CS2_List_Arguments} {acc09_username} {acc09_password}";
                    SteamProcess.Start();
                    Thread.Sleep(1000);
                }

                if (acc10_username != null && acc10_password != null)
                {
                    System.Diagnostics.Process SteamProcess = new System.Diagnostics.Process();
                    SteamProcess.StartInfo.FileName = Sanboxie_Path;
                    SteamProcess.StartInfo.Arguments = $"/box:Steam10 \"{Steam_Path}\" {CS2_List_Arguments} {acc10_username} {acc10_password}";
                    SteamProcess.Start();
                    Thread.Sleep(1000);
                }

                if (acc11_username != null && acc11_password != null)
                {
                    System.Diagnostics.Process SteamProcess = new System.Diagnostics.Process();
                    SteamProcess.StartInfo.FileName = Sanboxie_Path;
                    SteamProcess.StartInfo.Arguments = $"/box:Steam11 \"{Steam_Path}\" {CS2_List_Arguments} {acc11_username} {acc11_password}";
                    SteamProcess.Start();
                    Thread.Sleep(1000);
                }

                if (acc12_username != null && acc12_password != null)
                {
                    System.Diagnostics.Process SteamProcess = new System.Diagnostics.Process();
                    SteamProcess.StartInfo.FileName = Sanboxie_Path;
                    SteamProcess.StartInfo.Arguments = $"/box:Steam12 \"{Steam_Path}\" {CS2_List_Arguments} {acc12_username} {acc12_password}";
                    SteamProcess.Start();
                    Thread.Sleep(1000);
                }

                if (acc13_username != null && acc13_password != null)
                {
                    System.Diagnostics.Process SteamProcess = new System.Diagnostics.Process();
                    SteamProcess.StartInfo.FileName = Sanboxie_Path;
                    SteamProcess.StartInfo.Arguments = $"/box:Steam13 \"{Steam_Path}\" {CS2_List_Arguments} {acc13_username} {acc13_password}";
                    SteamProcess.Start();
                    Thread.Sleep(1000);
                }

                if (acc14_username != null && acc14_password != null)
                {
                    System.Diagnostics.Process SteamProcess = new System.Diagnostics.Process();
                    SteamProcess.StartInfo.FileName = Sanboxie_Path;
                    SteamProcess.StartInfo.Arguments = $"/box:Steam14 \"{Steam_Path}\" {CS2_List_Arguments} {acc14_username} {acc14_password}";
                    SteamProcess.Start();
                    Thread.Sleep(1000);
                }

                if (acc15_username != null && acc15_password != null)
                {
                    System.Diagnostics.Process SteamProcess = new System.Diagnostics.Process();
                    SteamProcess.StartInfo.FileName = Sanboxie_Path;
                    SteamProcess.StartInfo.Arguments = $"/box:Steam15 \"{Steam_Path}\" {CS2_List_Arguments} {acc15_username} {acc15_password}";
                    SteamProcess.Start();
                    Thread.Sleep(1000);
                }

                if (acc16_username != null && acc16_password != null)
                {
                    System.Diagnostics.Process SteamProcess = new System.Diagnostics.Process();
                    SteamProcess.StartInfo.FileName = Sanboxie_Path;
                    SteamProcess.StartInfo.Arguments = $"/box:Steam16 \"{Steam_Path}\" {CS2_List_Arguments} {acc16_username} {acc16_password}";
                    SteamProcess.Start();
                    Thread.Sleep(1000);
                }

                if (acc17_username != null && acc17_password != null)
                {
                    System.Diagnostics.Process SteamProcess = new System.Diagnostics.Process();
                    SteamProcess.StartInfo.FileName = Sanboxie_Path;
                    SteamProcess.StartInfo.Arguments = $"/box:Steam17 \"{Steam_Path}\" {CS2_List_Arguments} {acc17_username} {acc17_password}";
                    SteamProcess.Start();
                    Thread.Sleep(1000);
                }

                if (acc18_username != null && acc18_password != null)
                {
                    System.Diagnostics.Process SteamProcess = new System.Diagnostics.Process();
                    SteamProcess.StartInfo.FileName = Sanboxie_Path;
                    SteamProcess.StartInfo.Arguments = $"/box:Steam18 \"{Steam_Path}\" {CS2_List_Arguments} {acc18_username} {acc18_password}";
                    SteamProcess.Start();
                    Thread.Sleep(1000);
                }

                if (acc19_username != null && acc19_password != null)
                {
                    System.Diagnostics.Process SteamProcess = new System.Diagnostics.Process();
                    SteamProcess.StartInfo.FileName = Sanboxie_Path;
                    SteamProcess.StartInfo.Arguments = $"/box:Steam19 \"{Steam_Path}\" {CS2_List_Arguments} {acc19_username} {acc19_password}";
                    SteamProcess.Start();
                    Thread.Sleep(1000);
                }

                if (acc20_username != null && acc20_password != null)
                {
                    System.Diagnostics.Process SteamProcess = new System.Diagnostics.Process();
                    SteamProcess.StartInfo.FileName = Sanboxie_Path;
                    SteamProcess.StartInfo.Arguments = $"/box:Steam20 \"{Steam_Path}\" {CS2_List_Arguments} {acc20_username} {acc20_password}";
                    SteamProcess.Start();
                    Thread.Sleep(1000);
                }
            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine($"Fatal Error while starting Steam: {ex.Message}");
                Console.ForegroundColor = ConsoleColor.White;
            }
            return;
        }



        private static async Task PrepareUsers()
        {

            foreach (var item in Library.Account_Dictionary)
            {
                if (item.Key == "Acc01_Username") acc01_username = item.Value;
                if (item.Key == "Acc01_Password") acc01_password = item.Value;

                if (item.Key == "Acc02_Username") acc02_username = item.Value;
                if (item.Key == "Acc02_Password") acc02_password = item.Value;

                if (item.Key == "Acc03_Username") acc03_username = item.Value;
                if (item.Key == "Acc03_Password") acc03_password = item.Value;

                if (item.Key == "Acc04_Username") acc04_username = item.Value;
                if (item.Key == "Acc04_Password") acc04_password = item.Value;

                if (item.Key == "Acc05_Username") acc05_username = item.Value;
                if (item.Key == "Acc05_Password") acc05_password = item.Value;

                if (item.Key == "Acc06_Username") acc06_username = item.Value;
                if (item.Key == "Acc06_Password") acc06_password = item.Value;

                if (item.Key == "Acc07_Username") acc07_username = item.Value;
                if (item.Key == "Acc07_Password") acc07_password = item.Value;

                if (item.Key == "Acc08_Username") acc08_username = item.Value;
                if (item.Key == "Acc08_Password") acc08_password = item.Value;

                if (item.Key == "Acc09_Username") acc09_username = item.Value;
                if (item.Key == "Acc09_Password") acc09_password = item.Value;

                if (item.Key == "Acc10_Username") acc10_username = item.Value;
                if (item.Key == "Acc10_Password") acc10_password = item.Value;

                if (item.Key == "Acc11_Username") acc11_username = item.Value;
                if (item.Key == "Acc11_Password") acc11_password = item.Value;

                if (item.Key == "Acc12_Username") acc12_username = item.Value;
                if (item.Key == "Acc12_Password") acc12_password = item.Value;

                if (item.Key == "Acc13_Username") acc13_username = item.Value;
                if (item.Key == "Acc13_Password") acc13_password = item.Value;

                if (item.Key == "Acc14_Username") acc14_username = item.Value;
                if (item.Key == "Acc14_Password") acc14_password = item.Value;

                if (item.Key == "Acc15_Username") acc15_username = item.Value;
                if (item.Key == "Acc15_Password") acc15_password = item.Value;

                if (item.Key == "Acc16_Username") acc16_username = item.Value;
                if (item.Key == "Acc16_Password") acc16_password = item.Value;

                if (item.Key == "Acc17_Username") acc17_username = item.Value;
                if (item.Key == "Acc17_Password") acc17_password = item.Value;

                if (item.Key == "Acc18_Username") acc18_username = item.Value;
                if (item.Key == "Acc18_Password") acc18_password = item.Value;

                if (item.Key == "Acc19_Username") acc19_username = item.Value;
                if (item.Key == "Acc19_Password") acc19_password = item.Value;

                if (item.Key == "Acc20_Username") acc20_username = item.Value;
                if (item.Key == "Acc20_Password") acc20_password = item.Value;
            }
        }
    }
}
