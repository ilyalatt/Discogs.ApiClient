using System;
using System.Net.Http;

namespace Discogs.ApiClient
{
    public sealed class DiscogsApiClientEnvironment
    {
        public readonly DiscogsApiClientCredentials Credentials;
        public readonly HttpMessageInvoker HttpMessageInvoker;

        public DiscogsApiClientEnvironment(DiscogsApiClientCredentials credentials, HttpMessageInvoker httpMessageInvoker)
        {
            Credentials = credentials ?? throw new ArgumentNullException(nameof(credentials));
            HttpMessageInvoker = httpMessageInvoker ?? throw new ArgumentNullException(nameof(httpMessageInvoker));
        }

        public static DiscogsApiClientEnvironment CreateDefault(DiscogsApiClientCredentials credentials)
        {
            if (credentials == null) throw new ArgumentNullException(nameof(credentials));

            var httpClient = new HttpClient { BaseAddress = new Uri("https://api.discogs.com/") };
            var headers = httpClient.DefaultRequestHeaders;
            headers.Add("User-Agent", "FooBarApp/3.0");
            headers.Add("Authorization", $"Discogs token={credentials.Token}");
            
            return new DiscogsApiClientEnvironment(credentials, httpClient);
        }
    }
}