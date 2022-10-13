using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace r5_Reloaded_Administrator.Options
{
    public class Download
    {
        WebClient client = new WebClient();

        public static void DownloadR5_OnClass()
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

                Console.WriteLine(Plus.Plus.sizeCalcul("https://download.r5reloaded.com/r5reloaded.rar") + " Mo");
            }
        }
    }
}
