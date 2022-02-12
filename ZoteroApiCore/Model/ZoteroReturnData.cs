using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZoteroApiCore.Model
{
    public class ZoteroReturnData<T>
    {
        public string Key { get; set; }
        public int Version { get; set; }
        public ZoteroLibrary Library { get; set; }
        public LinkCollection Links { get; set; }
        public Meta Meta { get; set; }
        public T Data { get; set; }
    }
}
