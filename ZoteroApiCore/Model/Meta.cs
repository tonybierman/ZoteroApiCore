using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZoteroApiCore.Model
{
    public class Meta
    {
        public int NumCollections { get; set; }
        public int NumItems { get; set; }
        public string CreatorSummary { get; set; }
        public string ParsedDate { get; set; }
    }
}
