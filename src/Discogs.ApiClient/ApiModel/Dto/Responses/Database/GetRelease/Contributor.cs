namespace Discogs.ApiClient.ApiModel.Dto.Responses.Database.GetRelease
{
    public sealed class Contributor
    {
        public string Username { get; }
        public string ResourceUrl { get; }

        public Contributor(string username, string resourceUrl)
        {
            Username = username;
            ResourceUrl = resourceUrl;
        }
    }
}