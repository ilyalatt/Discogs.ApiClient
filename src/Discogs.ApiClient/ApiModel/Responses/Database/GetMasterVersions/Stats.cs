using Discogs.ApiClient.ApiModel.Responses.Database.Search;

namespace Discogs.ApiClient.ApiModel.Responses.Database.GetMasterVersions
{
    public sealed class Stats
    {
        public UserData User { get; set; }
        public CommunityBrief Community { get; set; }
    }
}