using System.Collections.Generic;

namespace Discogs.ApiClient.ApiModel.Dto.Responses.Database.GetMasterVersions
{
    public sealed class Version
    {
        public string Status { get; }
        public Stats Stats { get; }
        public string Thumb { get; }
        public string Format { get; }
        public string Title { get; }
        public string Label { get; }
        public string Released { get; }
        public IReadOnlyList<string> MajorFormats { get; }
        public string Catno { get; }
        public string ResourceUrl { get; }
        public int Id { get; }

        public Version(string status, Stats stats, string thumb, string format, string title, string label, string released, IReadOnlyList<string> majorFormats, string catno, string resourceUrl, int id)
        {
            Status = status;
            Stats = stats;
            Thumb = thumb;
            Format = format;
            Title = title;
            Label = label;
            Released = released;
            MajorFormats = majorFormats;
            Catno = catno;
            ResourceUrl = resourceUrl;
            Id = id;
        }
    }
}