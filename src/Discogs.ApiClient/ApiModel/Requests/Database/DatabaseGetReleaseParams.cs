namespace Discogs.ApiClient.ApiModel.Requests.Database
{
    // https://www.discogs.com/developers/#page:database,header:database-release
    public sealed class DatabaseGetReleaseParams
    {
        public int ReleaseId { get; }
        public DatabaseGetReleaseParams(int releaseId) => ReleaseId = releaseId;
        
        public string CurrAbbr { get; set; }
    }
}