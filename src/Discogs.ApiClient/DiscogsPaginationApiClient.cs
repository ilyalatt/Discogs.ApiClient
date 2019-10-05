using System;
using System.Threading.Tasks;
using Discogs.ApiClient.ApiModel.Responses;
using Discogs.ApiClient.Extensions;

namespace Discogs.ApiClient
{
    public sealed class DiscogsPaginationApiClient
    {
        public readonly DiscogsApiClientEnvironment Environment;

        public DiscogsPaginationApiClient(DiscogsApiClientEnvironment environment)
        {
            Environment = environment ?? throw new ArgumentNullException(nameof(environment));
        }

        public async Task<T> Next<T>(IPageable<T> pageable)
        {
            var url = pageable.Pagination.Urls.Next;
            return await Environment.Get<T>(url).ConfigureAwait(false);
        }
    }
}