using System.Collections.Generic;

namespace Discogs.ApiClient.ApiModel.Dto.Responses.Database.GetMasterVersions
{
    // https://www.discogs.com/developers/#page:database,header:database-master-release-versions 
    public sealed class GetMasterVersionResult : IPageable<GetMasterVersionResult>
    {
        public Pagination Pagination { get; }
        public IReadOnlyList<Version> Versions { get; }

        public GetMasterVersionResult(Pagination pagination, IReadOnlyList<Version> versions)
        {
            Pagination = pagination;
            Versions = versions;
        }
    }
}