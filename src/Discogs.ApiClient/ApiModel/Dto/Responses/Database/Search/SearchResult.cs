using System.Collections.Generic;

namespace Discogs.ApiClient.ApiModel.Dto.Responses.Database.Search
{
    public sealed class SearchResult : IPageable<SearchResult>
    {
        public Pagination Pagination { get; }
        public IReadOnlyList<ReleaseBrief> Results { get; }

        public SearchResult(Pagination pagination, IReadOnlyList<ReleaseBrief> results)
        {
            Pagination = pagination;
            Results = results;
        }
    }
}