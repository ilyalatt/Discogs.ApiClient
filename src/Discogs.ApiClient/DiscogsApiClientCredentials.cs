using System;

namespace Discogs.ApiClient
{
    public sealed class DiscogsApiClientCredentials
    {
        public readonly string Token;
        
        public DiscogsApiClientCredentials(string token)
        {
            Token = token ?? throw new ArgumentNullException(nameof(token));
        }

        public static DiscogsApiClientCredentials FromToken(string token) =>
            new DiscogsApiClientCredentials(token);
    }
}