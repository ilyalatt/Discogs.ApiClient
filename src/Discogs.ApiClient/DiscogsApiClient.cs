using System;

namespace Discogs.ApiClient
{
    public sealed class DiscogsApiClient
    {
        public readonly DiscogsApiClientEnvironment Environment;
        public DiscogsDatabaseApiClient Database => new DiscogsDatabaseApiClient(Environment);
        public DiscogsPaginationApiClient Pagination => new DiscogsPaginationApiClient(Environment);

        public DiscogsApiClient(DiscogsApiClientEnvironment environment)
        {
            Environment = environment ?? throw new ArgumentNullException(nameof(environment));
        }
        
        public static DiscogsApiClient Create(DiscogsApiClientEnvironment environment) =>
            new DiscogsApiClient(environment);
    }
}