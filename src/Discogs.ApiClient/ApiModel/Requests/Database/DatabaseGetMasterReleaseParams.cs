namespace Discogs.ApiClient.ApiModel.Requests.Database
{
    public sealed class DatabaseGetMasterReleaseParams
    {
        public int MasterId { get;  }
        public DatabaseGetMasterReleaseParams(int masterId) => MasterId = masterId;
    }
}