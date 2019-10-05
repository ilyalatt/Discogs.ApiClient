using System.Collections.Generic;

namespace Discogs.ApiClient.ApiModel.Dto.Responses.Database.Search
{
    // https://www.discogs.com/developers/#page:database,header:database-search
    public sealed class ReleaseBrief
    {
        public IReadOnlyList<string> Style { get; }
        public string Thumb { get; }
        public string Title { get; }
        public string Country { get; }
        public IReadOnlyList<string> Format { get; }
        public string Uri { get; }
        public CommunityBrief CommunityBrief { get; }
        public IReadOnlyList<string> Label { get; }
        public string Catno { get; }
        public string Year { get; }
        public IReadOnlyList<string> Genre { get; }
        public string ResourceUrl { get; }
        public string Type { get; }
        public int Id { get; }

        // properties below are not specified in the documentation
        public UserData UserData { get; }
        public int FormatQuantity { get; }
        public int? MasterId { get; }
        public IReadOnlyList<Format> Formats { get; }
        public IReadOnlyList<string> Barcode { get; }
        public string MasterUrl { get; }
        public string CoverImage { get; }

        public ReleaseBrief(IReadOnlyList<string> style, string thumb, string title, string country, IReadOnlyList<string> format, string uri, CommunityBrief communityBrief, IReadOnlyList<string> label, string catno, string year, IReadOnlyList<string> genre, string resourceUrl, string type, int id, UserData userData, int formatQuantity, int? masterId, IReadOnlyList<Format> formats, IReadOnlyList<string> barcode, string masterUrl, string coverImage)
        {
            Style = style;
            Thumb = thumb;
            Title = title;
            Country = country;
            Format = format;
            Uri = uri;
            CommunityBrief = communityBrief;
            Label = label;
            Catno = catno;
            Year = year;
            Genre = genre;
            ResourceUrl = resourceUrl;
            Type = type;
            Id = id;
            UserData = userData;
            FormatQuantity = formatQuantity;
            MasterId = masterId;
            Formats = formats;
            Barcode = barcode;
            MasterUrl = masterUrl;
            CoverImage = coverImage;
        }
    }
}