namespace Discogs.ApiClient.ApiModel.Dto.Responses.Database.GetRelease
{
    public sealed class Submitter
    {
        public string Username { get; }
        public string ResourceUrl { get; }

        public Submitter(string username, string resourceUrl)
        {
            Username = username;
            ResourceUrl = resourceUrl;
        }
    }
}