using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using ZoteroApiCore.Model;

namespace ZoteroApiCore.Request
{
    public class ZoteroApiParameters
    {
        [Range(0, 100)] public int limit { get; set; } = 100;

        public int start { get; set; } = 0;

        public ItemType? itemType { set; get; }
    }
}