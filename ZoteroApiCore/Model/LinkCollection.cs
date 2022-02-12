using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZoteroApiCore.Model
{
    public class LinkCollection
    {
        public Link Alternate { get; set; }
        public Link Up { get; set; }
        public Link Self { get; set; }
    }
}
