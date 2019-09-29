using System;
using System.Threading.Tasks;
using Discogs.ApiClient.ApiModel.Requests.Database;
using Discogs.ApiClient.ApiModel.Responses.Database.GetMasterVersions;
using Discogs.ApiClient.ApiModel.Responses.Database.GetRelease;
using Discogs.ApiClient.ApiModel.Responses.Database.Search;
using Discogs.ApiClient.Extensions;
using Flurl;

namespace Discogs.ApiClient
{
    public sealed class DiscogsDatabaseApiClient
    {
        public readonly DiscogsApiClientEnvironment Environment;
        
        public DiscogsDatabaseApiClient(DiscogsApiClientEnvironment environment)
        {
            Environment = environment ?? throw new ArgumentNullException(nameof(environment));
        }

        public async Task<SearchResult> Search(DatabaseSearchParams @params)
        {
            var url = "/database/search".AsUrl().AppendQueryParams(@params);
            return await Environment.Get<SearchResult>(url).ConfigureAwait(false);
        }

        public async Task<SearchResult> Search(string query)
        {
            return await Search(new DatabaseSearchParams(query)).ConfigureAwait(false);
        }

        
        public async Task<Release> GetRelease(DatabaseGetReleaseParams @params)
        {
            var url = "/releases"
                .AsUrl()
                .AppendPathSegment(@params.ReleaseId)
                .AppendQueryParams(@params);
            return await Environment.Get<Release>(url).ConfigureAwait(false);
        }
        
        public async Task<Release> GetRelease(int releaseId)
        {
            return await GetRelease(new DatabaseGetReleaseParams(releaseId)).ConfigureAwait(false);
        }


        public async Task<GetMasterVersionResult> GetMasterVersions(DatabaseGetMasterReleaseVersionsParams @params)
        {
            var url = "masters/"
                .AsUrl()
                .AppendPathSegment(@params.MasterId)
                .AppendPathSegment("/versions")
                .AppendQueryParams(@params);
            return await Environment.Get<GetMasterVersionResult>(url).ConfigureAwait(false);
        }

        public async Task<GetMasterVersionResult> GetMasterVersions(int masterId)
        {
            return await GetMasterVersions(new DatabaseGetMasterReleaseVersionsParams(masterId)).ConfigureAwait(false);
        }
    }
}