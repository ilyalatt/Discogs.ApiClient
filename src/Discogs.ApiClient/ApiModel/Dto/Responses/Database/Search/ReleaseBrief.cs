using System.Collections.Generic;

namespace Discogs.ApiClient.ApiModel.Dto.Responses.Database.Search
{
    public sealed class ReleaseBrief : ISearchResultEntity
    {
        public UserData UserData { get; }
        public CommunityBrief Community { get; }
        public string Catno { get; }
        public string Year { get; }
        public int FormatQuantity { get; }
        public int Id { get; }
        public IReadOnlyList<string> Style { get; }
        public string Thumb { get; }
        public string Title { get; }
        public IReadOnlyList<string> Label { get; }
        public int? MasterId { get; }
        public IReadOnlyList<string> Format { get; }
        public IReadOnlyList<string> Barcode { get; }
        public IReadOnlyList<string> Genre { get; }
        public string Country { get; }
        public string Uri { get; }
        public IReadOnlyList<Format> Formats { get; }
        public string CoverImage { get; }

        public ReleaseBrief(UserData userData, CommunityBrief community, string catno, string year, int formatQuantity, int id, IReadOnlyList<string> style, string thumb, string title, IReadOnlyList<string> label, int? masterId, IReadOnlyList<string> format, IReadOnlyList<string> barcode, IReadOnlyList<string> genre, string country, string uri, IReadOnlyList<Format> formats, string coverImage)
        {
            UserData = userData;
            Community = community;
            Catno = catno;
            Year = year;
            FormatQuantity = formatQuantity;
            Id = id;
            Style = style;
            Thumb = thumb;
            Title = title;
            Label = label;
            MasterId = masterId;
            Format = format;
            Barcode = barcode;
            Genre = genre;
            Country = country;
            Uri = uri;
            Formats = formats;
            CoverImage = coverImage;
        }
    }
}