using System.Collections.Generic;

namespace Discogs.ApiClient.ApiModel.Responses.Database.Search
{
    public sealed class SearchResult : IPageable<SearchResult>
    {
        public Pagination Pagination { get; set; }
        public List<ReleaseBrief> Results { get; set; }
    }
}