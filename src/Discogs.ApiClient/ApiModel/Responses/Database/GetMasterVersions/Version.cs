using System.Collections.Generic;

namespace Discogs.ApiClient.ApiModel.Responses.Database.GetMasterVersions
{
    public sealed class Version
    {
        public string Status { get; set; }
        public Stats Stats { get; set; }
        public string Thumb { get; set; }
        public string Format { get; set; }
        public string Title { get; set; }
        public string Label { get; set; }
        public string Released { get; set; }
        public List<string> MajorFormats { get; set; }
        public string Catno { get; set; }
        public string ResourceUrl { get; set; }
        public int Id { get; set; }
    }
}