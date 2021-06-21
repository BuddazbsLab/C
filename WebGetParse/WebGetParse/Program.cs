using System;
using System.IO;
using System.Net;
using Newtonsoft.Json;

namespace WebGetParse
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var updateGet = string.Empty;
            var url = @"http://awx:8000/awx/postamats/status/all";

            var request = (HttpWebRequest) WebRequest.Create(url);
            request.AutomaticDecompression = DecompressionMethods.GZip;

            using (var response = (HttpWebResponse) request.GetResponse())
            using (var stream = response.GetResponseStream())
            using (var reader = new StreamReader(stream))
            {
                updateGet = reader.ReadToEnd();
            }

            Console.WriteLine();
        }
    }
}
