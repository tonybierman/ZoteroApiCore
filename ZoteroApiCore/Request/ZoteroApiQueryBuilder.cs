using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZoteroApiCore.Request
{
    public static class ZoteroApiQueryBuilder
    {
        public static string GetQuery(string url, ZoteroApiParameters param)
        {
            // TODO: var result = url.SetQueryParams(param);
            var result = url;//.SetQueryParams(param);
            return result.ToString();
        }
    }
}
