using Newtonsoft.Json.Linq;
using System;
using System.IO;
using System.Net;

namespace Методы
{
    class Program
    {
        static void Main(string[] args)
        {
            string sURL;
            sURL = "";
            WebRequest wrGETURL;
            wrGETURL = WebRequest.Create(sURL);
            Stream objStream;
            objStream = wrGETURL.GetResponse().GetResponseStream();
            StreamReader objReader = new StreamReader(objStream);
            string postamat = objReader.ReadToEnd();
            JObject parsed = JObject.Parse(postamat);
            string version_postamat = (string)parsed.SelectToken("segments[0].groupKey");
            string number_postamat = (string)parsed.SelectToken("segments[0].count");
            string version_postamat_1 = (string)parsed.SelectToken("segments[1].groupKey");
            string number_postamat_1 = (string)parsed.SelectToken("segments[1].count");
            string version_postamat_2 = (string)parsed.SelectToken("segments[2].groupKey");
            string number_postamat_2 = (string)parsed.SelectToken("segments[2].count");
            string version_postamat_3 = (string)parsed.SelectToken("segments[3].groupKey");
            string number_postamat_3 = (string)parsed.SelectToken("segments[3].count");
            string version_postamat_4 = (string)parsed.SelectToken("segments[4].groupKey");
            string number_postamat_4 = (string)parsed.SelectToken("segments[4].count");
            string version_postamat_5 = (string)parsed.SelectToken("segments[5].groupKey");
            string number_postamat_5 = (string)parsed.SelectToken("segments[5].count");
            string version_postamat_6 = (string)parsed.SelectToken("segments[6].groupKey");
            string number_postamat_6 = (string)parsed.SelectToken("segments[6].count");
            string version_postamat_7 = (string)parsed.SelectToken("segments[7].groupKey");
            string number_postamat_7 = (string)parsed.SelectToken("segments[7].count");
            Console.WriteLine("Версия постамата:" + " " + version_postamat);
            Console.WriteLine("Колличество точек:" + " " + number_postamat);
            Console.WriteLine("===========================================");
            Console.WriteLine("Версия постамата:" + " " + version_postamat_1);
            Console.WriteLine("Колличество точек:" + " " + number_postamat_1);
            Console.WriteLine("===========================================");
            Console.WriteLine("Версия постамата:" + " " + version_postamat_2);
            Console.WriteLine("Колличество точек:" + " " + number_postamat_2);
            Console.WriteLine("===========================================");
            Console.WriteLine("Версия постамата:" + " " + version_postamat_3);
            Console.WriteLine("Колличество точек:" + " " + number_postamat_3);
            Console.WriteLine("===========================================");
            Console.WriteLine("Версия постамата:" + " " + version_postamat_4);
            Console.WriteLine("Колличество точек:" + " " + number_postamat_4);
            Console.WriteLine("===========================================");
            Console.WriteLine("Версия постамата:" + " " + version_postamat_5);
            Console.WriteLine("Колличество точек:" + " " + number_postamat_5);
            Console.WriteLine("===========================================");
            Console.WriteLine("Версия постамата:" + " " + version_postamat_6);
            Console.WriteLine("Колличество точек:" + " " + number_postamat_6);
            Console.WriteLine("===========================================");
            Console.WriteLine("Версия постамата:" + " " + version_postamat_7);
            Console.WriteLine("Колличество точек:" + " " + number_postamat_7);
            Console.WriteLine("===========================================");
            Console.ReadLine();
        }
    }
}

