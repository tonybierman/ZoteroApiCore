using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using ZoteroApiCore.Request;
using ZoteroApiCore.Model;

namespace ZoteroApiCore.Response
{
    public abstract class ZoteroApiResponse<T>
    {
        public ZoteroApiResponseHeaderReader MetaData;
        public string RequestUrl;
        public bool HasNextPage = false;

        public ZoteroApiResponse(ZoteroApiResponseHeaderReader metaData, string requestUrl)
        {
            MetaData = metaData;
            RequestUrl = requestUrl;
            LoadMetaData(metaData);
        }

        private void LoadMetaData(ZoteroApiResponseHeaderReader metaData)
        {
            if (metaData.Next != null)
            {
                HasNextPage = true;
            }
        }
    }
}