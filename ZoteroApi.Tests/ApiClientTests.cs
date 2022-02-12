using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Net.Http;
using ZoteroApiCore.Client;

namespace ZoteroApi.Tests
{
    [TestClass]
    public class ApiClientTests
    {
        private static readonly HttpClient http = new HttpClient();
        private static ZoteroApiClient _zoteroApiClient;

        [TestMethod]
        public void ClientTest()
        {
            var accessToken = "U5nIeNf08Vu3mNh7zqZH4XD3";
            var baseUrl = "https://api.zotero.org";
            var user = "/users/9077300";
            var collections = "collections";
            var url = baseUrl + user + "/" + collections;
            var testUrl = "https://api.zotero.org/users/9077300/collections";
            Assert.AreEqual(url, testUrl);
            //_out.WriteLine("https://api.zotero.org/users/9077300/collections");
            http.DefaultRequestHeaders.Add("Authorization", "Bearer " + accessToken);
            //var response = await http.GetAsync(url);
            //_out.WriteLine(await response.Content.ReadAsStringAsync());
        }
    }
}