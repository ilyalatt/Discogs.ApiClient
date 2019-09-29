using System.Collections.Generic;

namespace Discogs.ApiClient.ApiModel.Responses.Database.GetRelease
{
    public sealed class Community
    {
        public string Status { get; set; }
        public Rating Rating { get; set; }
        public int Have { get; set; }
        public List<Contributor> Contributors { get; set; }
        public int Want { get; set; }
        public Submitter Submitter { get; set; }
        public string DataQuality { get; set; }
    }
}