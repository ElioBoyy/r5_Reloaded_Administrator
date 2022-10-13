using System.Net;

namespace r5_Reloaded_Administrator
{
    public class Selector
    {
        private string Path = $@"C:\Users\{Environment.UserName}\Documents";
        WebClient client = new WebClient();

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
            string prompt = "Download r5_Reloaded?\n";
            string[] options = { "Yes", "No" };
            Menu mainMenu = new Menu(options, prompt);
            int selectedIndex = mainMenu.Run();

            if (selectedIndex == 0)
            {
                //using (WebClient wc = new WebClient())
                //{
                //    wc.DownloadFileAsync(
                //        new System.Uri("https://download.r5reloaded.com/r5reloaded.rar"),
                //        $"{Path}/r5reloaded.rar"
                //    );

                //}

                Console.WriteLine(sizeCalcul("https://download.r5reloaded.com/r5reloaded.rar") + " Mo");
            }
        }

        private Int64 sizeCalcul(string path)
        {
            client.OpenRead(path);
            Int64 bytes_total = Convert.ToInt64(client.ResponseHeaders["Content-Length"]) / 1000000;
            return bytes_total;
        }

        private void ExitSoft()
        {
            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey(true);
            Environment.Exit(0);
        }
    }
}
