using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZoteroApiCore.Model
{
    // Todo: Divide the Zotero item into item types so each have distinct fields.
    public class ZoteroItem
    {
        public string Key { get; set; }
        public int Version { get; set; }
        public string Name { get; set; }
        public string? ParentCollection { get; set; }
        public Relations? Relations { get; set; }
        // Below belongs to items
        public string? ParentItem { get; set; }
        public ItemType? ItemType { get; set; }
        public string? Note { get; set; }
        public List<object>? Tags { get; set; }
        public DateTimeOffset? DateAdded { get; set; }
        public DateTimeOffset? DateModified { get; set; }
        public LinkMode? LinkMode { get; set; }
        public string? Title { get; set; }
        public string? AccessDate { get; set; }
        public string? Url { get; set; }
        public string? ContentType { get; set; }
        public string? Charset { get; set; }
        public string? Path { get; set; }
        public string? Filename { get; set; }
        public object? Md5 { get; set; }
        public object? Mtime { get; set; }
        public Creator[]? Creators { get; set; }
        public string? AbstractNote { get; set; }
        public string? WebsiteTitle { get; set; }
        public string? WebsiteType { get; set; }
        public string? Date { get; set; }
        public string ShortTitle { get; set; }
        public string? Language { get; set; }
        public string? Rights { get; set; }
        public string? Extra { get; set; }

        /// <summary>
        /// Collection keys
        /// </summary>
        public string[] Collections { get; set; }

        public string PublicationTitle { get; set; }
        public string Volume { get; set; }
        public string Issue { get; set; }
        public string Pages { get; set; }
        public string? Series { get; set; }
        public string SeriesTitle { get; set; }
        public string SeriesText { get; set; }
        public string JournalAbbreviation { get; set; }
        public string Doi { get; set; }
        public string Issn { get; set; }
        public string Archive { get; set; }
        public string ArchiveLocation { get; set; }
        public string LibraryCatalog { get; set; }
        public string? CallNumber { get; set; }
        public string SeriesNumber { get; set; }
        public string NumberOfVolumes { get; set; }
        public string? Edition { get; set; }
        public string Place { get; set; }
        public string Publisher { get; set; }
        public string NumPages { get; set; }
        public string Isbn { get; set; }
        public string ProceedingsTitle { get; set; }
        public string ConferenceName { get; set; }
    }
}
