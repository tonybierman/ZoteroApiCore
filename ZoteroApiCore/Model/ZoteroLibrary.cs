using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZoteroApiCore.Model
{
    public class ZoteroLibrary
    {
        public LibraryType Type { get; set; }
        public int Id { get; set; }
        public string Name { get; set; }
        public LinkCollection Links { get; set; }
    }
}
