using System.Collections.Generic;

namespace Discogs.ApiClient.ApiModel.Responses.Database.GetMasterVersions
{
    // https://www.discogs.com/developers/#page:database,header:database-master-release-versions 
    public sealed class GetMasterVersionResult : IPageable<GetMasterVersionResult>
    {
        public Pagination Pagination { get; set; }
        public List<Version> Versions { get; set; }
    }
}