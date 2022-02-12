using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZoteroApiCore.Model
{
    public class ZoteroCollection
    {
        public string Key { get; set; }
        public int Version { get; set; }
        public string Name { get; set; }
        public string? ParentCollection { get; set; }
        public Relations? Relations { get; set; }
    }
}
