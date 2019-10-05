namespace Discogs.ApiClient.ApiModel.Dto.Responses.Database.GetMasterVersions
{
    public sealed class Stats
    {
        public UserData User { get; }
        public CommunityBrief Community { get; }

        public Stats(UserData user, CommunityBrief community)
        {
            User = user;
            Community = community;
        }
    }
}