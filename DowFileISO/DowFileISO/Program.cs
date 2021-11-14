using System;
using System.Net;
using System.Threading.Tasks;

namespace DowFileISO
{
    class Program
    {
        static void Main(string[] args)
        {
            Main().Wait();
            Console.WriteLine("Done");
        }
        static async Task Main()
        {
            WebClient http = new WebClient();
            int currentProgress = -1;

            http.DownloadProgressChanged += (sender, e) =>
            {
                if (currentProgress != e.ProgressPercentage)
                {
                    
                    Console.WriteLine(e.ProgressPercentage + "% complete");
                    
                    currentProgress = e.ProgressPercentage;

                }

            };
            Console.Write("Downloading ... ");
            
            await http.DownloadFileTaskAsync("https://releases.ubuntu.com/20.04.3/ubuntu-20.04.3-desktop-amd64.iso?_ga=2.73651666.1717481632.1633111246-1844122434.1633111246", @"d:\20150529TWC9_mid.mp4");
        }
    }
}
