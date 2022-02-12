using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using ZoteroApiCore.Request;
using ZoteroApiCore.Model;

namespace ZoteroApiCore.Response
{
    public class ZoteroApiResponseSingle<T> : ZoteroApiResponse<T>
    {
        public ZoteroReturnData<T> Data;

        public ZoteroApiResponseSingle(ZoteroApiResponseHeaderReader metaData, ZoteroReturnData<T> data,
            string requestUrl) : base(metaData, requestUrl)
        {
            Data = data;
        }
        
        public static async Task<ZoteroApiResponseSingle<T>> LoadResponseSingle(HttpResponseMessage response)
        {
            var meta = new ZoteroApiResponseHeaderReader(response);
        
            var stringBody = await response.Content.ReadAsStringAsync();
        
            var setting = new JsonSerializerSettings()
            {
                ContractResolver = new CamelCasePropertyNamesContractResolver()
            };
            var data = JsonConvert.DeserializeObject<ZoteroReturnData<T>>(stringBody, setting);
        
            return new ZoteroApiResponseSingle<T>(meta, data ,
                response.RequestMessage.RequestUri.ToString());
        }
    }
}