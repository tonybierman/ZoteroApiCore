using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZoteroApiCore.Model
{
    [Newtonsoft.Json.JsonConverter(typeof(StringEnumConverter))]
    public enum CreatorType
    {
        Author,
        Editor,
        SeriesEditor,
        Translator,
        ReviewedAuthor
    };
}
