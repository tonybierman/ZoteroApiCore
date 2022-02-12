using ZoteroApiCore.Api;
using ZoteroApiCore.Request;

namespace ZoteroApiCore
{
    public class ZoteroApiUrls
    {
        private string _userId;

        private string _apiRoot;

        public ZoteroApiUrls(string userId)
        {
            this._userId = userId;

            // _apiRoot = EndPoints.BaseUrl + _userId + "/";
            _apiRoot = ZoteroApiEndPoints.BaseUrl + "/" + ZoteroApiEndPoints.Users + "/" + _userId + "/";
        }

        public string GetUserCollectionsUrl(Request.ZoteroApiParameters p)
        {
            var url = _apiRoot + ZoteroApiEndPoints.Collections;
            return AttachParams(url, p);
        }

        public string GetUserItemsUrl(Request.ZoteroApiParameters p)
        {
            var url = _apiRoot + ZoteroApiEndPoints.Items;
            return AttachParams(url, p);
        }

        private string _GetCollectionItemUrl(string collectionId)
        {
            return _apiRoot + ZoteroApiEndPoints.Collections + '/' + collectionId + '/' + "items";
        }

        public string GetItemUrl(string itemKey, Request.ZoteroApiParameters p)
        {
            var url = _apiRoot + ZoteroApiEndPoints.Items + '/' + itemKey;
            return AttachParams(url, p);
        }
        
        public string GetCollectionUrl(string itemKey, Request.ZoteroApiParameters p)
        {
            var url = _apiRoot + ZoteroApiEndPoints.Collections + '/' + itemKey;
            return AttachParams(url, p);
        }

        public string GetCollectionItemUrl(string collectionId, Request.ZoteroApiParameters p = null)
        {
            var url = _GetCollectionItemUrl(collectionId);
            return AttachParams(url, p);
        }

        /// <summary>
        /// Every method return url with params attached.
        /// </summary>
        /// <param name="url"></param>
        /// <param name="p"></param>
        /// <returns></returns>
        private string AttachParams(string url, Request.ZoteroApiParameters p)
        {
            if (p == null)
            {
                /// Provide a default parameters if the user did not provide one
                p = new Request.ZoteroApiParameters();
            }

            return ZoteroApiQueryBuilder.GetQuery(url, p);
        }

    }
}