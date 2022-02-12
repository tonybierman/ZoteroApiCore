using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZoteroApiCore.Model
{
    [Newtonsoft.Json.JsonConverter(typeof(StringEnumConverter))]
    public enum ItemType
    {
        Book,
        Artwork,
        AudioRecording,
        Bill,
        BlogPost,
        BookSection,
        Case,
        ConferencePaper,
        DictionaryEntry,
        Document,
        Email,
        EncyclopediaArticle,
        Film,
        ForumPost,
        Hearing,
        InstantMessage,
        Interview,
        JournalArticle,
        Letter,
        MagazineArticle,
        Manuscript,
        Map,
        NewspaperArticle,
        Patent,
        Podcast,
        Presentation,
        RadioBroadcast,
        Report,
        Software,
        Statute,
        Thesis,
        TVBroadcast,
        VideoRecording,
        Webpage,
        Attachment,
        Note
    };
}
