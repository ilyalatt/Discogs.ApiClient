namespace Discogs.ApiClient.ApiModel.Dto.Requests.Database
{
    // https://www.discogs.com/developers/#page:database,header:database-master-release-versions 
    public sealed class DatabaseGetMasterReleaseVersionsParams
    {
        public int MasterId { get; }
        public DatabaseGetMasterReleaseVersionsParams(int masterId) => MasterId = masterId;
        
        public int Page { get; set; }
        public int PerPage { get; set; }
        public string Format { get; set; }
        public string Label { get; set; }
        public string Released { get; set; }
        public string Country { get; set; }
        public string Sort { get; set; }
        public string SortOrder { get; set; }
    }
}
