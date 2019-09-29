using System.Collections.Generic;

namespace Discogs.ApiClient.ApiModel.Responses.Database.Search
{
    // https://www.discogs.com/developers/#page:database,header:database-search
    public sealed class ReleaseBrief
    {
        public string[] Style { get; set; }
        public string Thumb { get; set; }
        public string Title { get; set; }
        public string Country { get; set; }
        public List<string> Format { get; set; }
        public string Uri { get; set; }
        public CommunityBrief CommunityBrief { get; set; }
        public List<string> Label { get; set; }
        public string Catno { get; set; }
        public string Year { get; set; }
        public List<string> Genre { get; set; }
        public string ResourceUrl { get; set; }
        public string Type { get; set; }
        public int Id { get; set; }

        // properties below are not specified in the documentation
        public UserData UserData { get; set; }
        public int FormatQuantity { get; set; }
        public int? MasterId { get; set; }
        public List<Format> Formats { get; set; }
        public List<string> Barcode { get; set; }
        public string MasterUrl { get; set; }
        public string CoverImage { get; set; }
    }
}