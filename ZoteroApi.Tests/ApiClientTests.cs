using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Net.Http;
using System.Threading.Tasks;
using ZoteroApiCore.Api;
using ZoteroApiCore.Client;
using ZoteroApiCore.Model;
using ZoteroApiCore.Request;
using ZoteroApiCore.Response;

namespace ZoteroApi.Tests
{
    [TestClass]
    public class ApiClientTests
    {
        private static readonly string _accessToken = "U5nIeNf08Vu3mNh7zqZH4XD3";
        private static readonly string _user = "9077300";
        //private static readonly HttpClient http = new HttpClient();
        //private static ZoteroApiClient _zoteroApiClient;

        [TestMethod]
        public void ZoteroItemsTest()
        {
            ZoteroApiResponseMany<ZoteroItem> items = ZoteroItemsTestAsync().GetAwaiter().GetResult();
            Assert.IsTrue(items.Data.Count > 0);
        }

        async Task<ZoteroApiResponseMany<ZoteroItem>> ZoteroItemsTestAsync()
        {
            HttpClient http = new HttpClient();
            ZoteroApiClient _zoteroApiClient;
            http.DefaultRequestHeaders.Add("Authorization", "Bearer " + _accessToken);
            _zoteroApiClient = new ZoteroApiClient(_accessToken, _user);
            return await _zoteroApiClient.GetUserItems(new ZoteroApiParameters());
        }

        [TestMethod]
        public void ZoteroCollectionsTest()
        {
            ZoteroApiResponseMany<ZoteroCollection> cols = ZoteroCollectionsTestAsync().GetAwaiter().GetResult();
            Assert.IsTrue(cols.Data.Count > 0);
        }

        async Task<ZoteroApiResponseMany<ZoteroCollection>> ZoteroCollectionsTestAsync()
        {
            HttpClient http = new HttpClient();
            ZoteroApiClient _zoteroApiClient;
            http.DefaultRequestHeaders.Add("Authorization", "Bearer " + _accessToken);
            _zoteroApiClient = new ZoteroApiClient(_accessToken, _user);
            return await _zoteroApiClient.GetUserCollections(new ZoteroApiParameters());
        }
    }
}