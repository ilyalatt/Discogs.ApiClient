using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;

namespace Discogs.ApiClient.ApiModel.Dto.Responses.Database.Search
{
    public sealed class SearchResult : IPageable<SearchResult>
    {
        public Pagination Pagination { get; }
        [JsonProperty("results")]
        public IReadOnlyList<ISearchResultEntity> RawEntities { get; }

        public IEnumerable<ArtistBrief> Artists => RawEntities.OfType<ArtistBrief>();
        public IEnumerable<LabelBrief> Labels => RawEntities.OfType<LabelBrief>();
        public IEnumerable<MasterReleaseBrief> MasterReleases => RawEntities.OfType<MasterReleaseBrief>();
        public IEnumerable<ReleaseBrief> Releases => RawEntities.OfType<ReleaseBrief>();

        public SearchResult(
            Pagination pagination, 
            IReadOnlyList<ISearchResultEntity> results // deserialization requires this name
        )
        {
            Pagination = pagination;
            RawEntities = results;
        }
    }
}