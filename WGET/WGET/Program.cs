using Newtonsoft.Json.Linq;
using System;
using System.IO;
using System.Net;
using System.Threading.Tasks;

namespace WGET
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                string updateGet = string.Empty;
                string url = @"http://10.7.8.220:8000/updater/postamats/status/all";

                async Task<string> GetAsync(string uri)
                {
                    HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
                    request.AutomaticDecompression = DecompressionMethods.GZip;

                    using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
                    using (Stream stream = response.GetResponseStream())
                    using (StreamReader reader = new StreamReader(stream))
                    {
                        return await reader.ReadToEndAsync();
                    }
                }

                Console.WriteLine(updateGet);
            }
        }
    }
}