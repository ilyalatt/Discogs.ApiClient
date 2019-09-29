using System;
using System.Threading.Tasks;
using Discogs.ApiClient.ApiModel.Responses;
using Discogs.ApiClient.Extensions;

namespace Discogs.ApiClient
{
    public sealed class DiscogsApiClient
    {
        public readonly DiscogsApiClientEnvironment Environment;
        public DiscogsDatabaseApiClient Database => new DiscogsDatabaseApiClient(Environment);

        public DiscogsApiClient(DiscogsApiClientEnvironment environment)
        {
            Environment = environment ?? throw new ArgumentNullException(nameof(environment));
        }
        
        public static DiscogsApiClient Create(DiscogsApiClientEnvironment environment) =>
            new DiscogsApiClient(environment);

        public async Task<T> Next<T>(IPageable<T> pageable)
        {
            var url = pageable.Pagination.Urls.Next;
            return await Environment.Get<T>(url).ConfigureAwait(false);
        }
    }
}