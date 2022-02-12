using ZoteroApiCore.Client;
using ZoteroApiCore.Request;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        private static readonly string _accessToken = "U5nIeNf08Vu3mNh7zqZH4XD3";
        private static readonly string _user = "9077300";
        private static readonly HttpClient http = new HttpClient();
        private static ZoteroApiClient _zoteroApiClient;

        static void Main(string[] args)
        {
            MainAsync(args).GetAwaiter().GetResult();
        }

        static async Task MainAsync(string[] args)
        {
            http.DefaultRequestHeaders.Add("Authorization", "Bearer " + _accessToken);
            _zoteroApiClient = new ZoteroApiClient(_accessToken, _user);
            var results = await _zoteroApiClient.GetUserItems(new ZoteroApiParameters());
        }
    }
}