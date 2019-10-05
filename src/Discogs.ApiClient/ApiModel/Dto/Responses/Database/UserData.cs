namespace Discogs.ApiClient.ApiModel.Dto.Responses.Database
{
    public sealed class UserData
    {
        public bool InCollection { get; }
        public bool InWantlist { get; }

        public UserData(bool inCollection, bool inWantlist)
        {
            InCollection = inCollection;
            InWantlist = inWantlist;
        }
    }
}