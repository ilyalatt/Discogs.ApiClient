using System;
using System.Linq;
using System.Threading.Tasks;
using Discogs.ApiClient;
using Discogs.ApiClient.ApiModel.Requests.Database;

namespace Playground
{
    static class Program
    {
        static DiscogsApiClient CreateDiscogsApiClient()
        {
            var credentials = DiscogsApiClientCredentials.FromToken("<TOKEN>");
            var environment = DiscogsApiClientEnvironment.CreateDefault(credentials);
            return DiscogsApiClient.Create(environment);
        }

        static async Task Main()
        {
            var client = CreateDiscogsApiClient();
            var db = client.Database;
            var searchResults = await db.Search(new DatabaseSearchParams("Bang Bang")
            {
                Artist = "Nancy Sinatra"
            });
            while (true)
            {
                Console.WriteLine($"Page {searchResults.Pagination.Page}");
                searchResults.Results.Select(x => x.Title).ToList().ForEach(Console.WriteLine);
                Console.WriteLine();

                if (searchResults.Pagination.Urls.Next == null) break;
                searchResults = await client.Next(searchResults);
            }
        }
    }
}