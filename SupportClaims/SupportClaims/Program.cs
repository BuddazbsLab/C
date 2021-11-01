using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Newtonsoft.Json;
using RestSharp;
using Telegram.Bot;

namespace SupportClaims
{
    internal static class Program
    {
        private static async Task Main()
        {
            var takeSettingsApp = JsonConvert.DeserializeObject<Settings.AppData>(await File.ReadAllTextAsync("appsettings.json"));
            var botClient = new TelegramBotClient(takeSettingsApp.token);
            var startTimeSpan = TimeSpan.Zero;
            var periodTimeSpan = TimeSpan.FromMinutes(10);
            var timer = new Timer(async e =>
            {
                var timesleep = DateTime.Now.Hour;
                var datesleep = DateTime.Now.DayOfWeek;
                if (timesleep >= 08 && timesleep < 18 && datesleep != DayOfWeek.Saturday &&
                    datesleep != DayOfWeek.Sunday)
                {
                    var client =
                        new RestClient(
                            takeSettingsApp.basgeteurl);
                    var updateGet = client.Get(new RestRequest()).Content;
                    
                    var myDeserializedClass = JsonConvert.DeserializeObject<List<Parse.Class1>>(updateGet);
                    var allclaims = myDeserializedClass.Count;
                    var hotclaim = myDeserializedClass.Count(j => j.priority.StartsWith("High"));
                    var middleclaim = myDeserializedClass.Count(j => j.priority.StartsWith("Average"));
                    var alarmnumber = myDeserializedClass.Count(j => j.objectType.StartsWith("Incident"));
                    var lowclaim = myDeserializedClass.Count(j => j.priority.StartsWith("Low"));
                    if (allclaims >= 3)
                    {
                        var message = await botClient.SendTextMessageAsync(
                            -1001609745979, // or a chat id: 123456789
                            "Ребята, на нашей группе висит более 5 обращений, всего: " + " " + allclaims + " " + "шт." +
                            "\n\nИз них: \n\n🚨ИНЦИДЕНТОВ🚨: " + " " + alarmnumber + " " + "шт., (но не факт)" +
                            "\n\nВысокий приоритет‼: " + " " + hotclaim + " " + "шт.," +
                            "\n\nСредний приоритет⁉: " + " " + middleclaim + " " + "шт.," +
                            "\n\nНизкий приоритет❕: " + " " + lowclaim + " " + "шт.");
                    }
                    else
                    {
                        var message1 = await botClient.SendTextMessageAsync(
                            -1001609745979, // or a chat id: 123456789 
                            "Ребята, на нашей группе висит мало обращений, всего : " + allclaims + " " + "шт." +
                            "\n\nИз них 🚨ИНЦИДЕНТОВ🚨: " + alarmnumber + " " + "шт." +
                            "\n\nВы все ✅М О Л О Д Ц Ы✅");
                        var message_else = await botClient.SendStickerAsync(
                            -1001609745979, // or a chat id: 123456789
                            sticker: takeSettingsApp.stiker); 
                    }
                }
            }, null, startTimeSpan, periodTimeSpan);
            Console.ReadLine();
        }
    }
}