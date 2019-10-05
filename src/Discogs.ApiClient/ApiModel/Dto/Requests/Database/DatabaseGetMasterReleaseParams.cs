namespace Discogs.ApiClient.ApiModel.Dto.Requests.Database
{
    public sealed class DatabaseGetMasterReleaseParams
    {
        public int MasterId { get; }
        public DatabaseGetMasterReleaseParams(int masterId) => MasterId = masterId;
    }
}