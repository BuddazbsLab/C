using RestSharp;
using Telegram.Bot;
using RestSharp.Authenticators;

namespace Prototype_419.Runscope.Hook
{
    public class BotClient
    {
        private static async Task CreateBotClient()
        {
            BotClient botClient = new BotClient();
            var Client = new TelegramBotClient("2121228126:AAHCsuERjgTIInRANhPL-EPLcM9DeHTaEVI");
            var message = await Client.SendTextMessageAsync(74120470, "Ребята");
        }

    }
}
