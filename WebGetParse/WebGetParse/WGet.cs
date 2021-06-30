using Newtonsoft.Json;

namespace WebGetParse
{
    public class WGet
    {
        public class Hubs
        {
            [JsonProperty("Status")] public string Status { get; set; }

            [JsonProperty("Downloaded")] public int Downloaded { get; set; }
        }

        public class FiscalDevice
        {
            [JsonProperty("Status")] public string Status { get; set; }

            [JsonProperty("Downloaded")] public int Downloaded { get; set; }
        }

        public class Postamat
        {
            [JsonProperty("Status")] public string Status { get; set; }

            [JsonProperty("Downloaded")] public int Downloaded { get; set; }
        }

        public class Torrents
        {
            [JsonProperty("Hubs")] public Hubs Hubs { get; set; }

            [JsonProperty("FiscalDevice")] public FiscalDevice FiscalDevice { get; set; }

            [JsonProperty("Postamat")] public Postamat Postamat { get; set; }
        }

        public class Example
        {
            [JsonProperty("Torrents")] public Torrents Torrents { get; set; }

            [JsonProperty("PtName")] public string PtName { get; set; }

            [JsonProperty("StatusUpdate")] public string StatusUpdate { get; set; }

            [JsonProperty("ConnectName")] public string ConnectName { get; set; }
        }
    }
}