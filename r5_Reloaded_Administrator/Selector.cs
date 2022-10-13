using System.Net;

namespace r5_Reloaded_Administrator
{
    public class Selector
    {
        private string Path = $@"C:\Users\{Environment.UserName}\Documents";

        public void Start()
        {
            Console.Title = "r5 Reloaded Administrator";
            RunMainMenu();
        }

        private void RunMainMenu()
        {
            string prompt = @"
██████╗ ███████╗██╗      ██████╗  █████╗ ██████╗ ███████╗██████╗ 
██╔══██╗██╔════╝██║     ██╔═══██╗██╔══██╗██╔══██╗██╔════╝██╔══██╗
██████╔╝█████╗  ██║     ██║   ██║███████║██║  ██║█████╗  ██║  ██║
██╔══██╗██╔══╝  ██║     ██║   ██║██╔══██║██║  ██║██╔══╝  ██║  ██║
██║  ██║███████╗███████╗╚██████╔╝██║  ██║██████╔╝███████╗██████╔╝
╚═╝  ╚═╝╚══════╝╚══════╝ ╚═════╝ ╚═╝  ╚═╝╚═════╝ ╚══════╝╚═════╝ 
            ";

            string[] options = { "Download r5", "Update r5", "Scripts", "Infos", "Exit" };
            Menu mainMenu = new Menu(options, prompt);
            int selectedIndex = mainMenu.Run();

            switch (selectedIndex)
            {
                case 0:
                    DownloadR5();
                    break;
                case 1:
                    UpdateR5();
                    break;
                case 2:
                    Scripts();
                    break;
                case 3:
                    Infos();
                    break;
                default:
                    ExitSoft();
                    break;
            }
        }

        private void Infos()
        {
            Console.Clear();
            Console.WriteLine("This is an unofficial r5_Reloaded Administrator.\n");
            Console.WriteLine("Author: ElioBoyy");
            Console.WriteLine("Discord: ElioBoyy#2681\n");
            Console.WriteLine("Version; 1.0");
            Console.WriteLine("GitHub link: https://github.com/ElioBoyy/r5_Reloaded_Administrator.git\n");
            Console.WriteLine("Enjoy!");

            Console.ReadKey(true);
            RunMainMenu();
        }

        private void Scripts()
        {
            throw new NotImplementedException();
        }

        private void UpdateR5()
        {
            throw new NotImplementedException();
        }

        private async void DownloadR5()
        {
            DownloadR5
        }

        private void ExitSoft()
        {
            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey(true);
            Environment.Exit(0);
        }
    }
}
