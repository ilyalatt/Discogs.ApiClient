using System;
using System.Linq;
using System.Threading.Tasks;
using Discogs.ApiClient;
using Discogs.ApiClient.ApiModel.Dto.Requests.Database;

namespace Playground
{
    static class Program
    {
        static DiscogsApiClient CreateDiscogsApiClient(string discogsApiToken)
        {
            var credentials = DiscogsApiClientCredentials.FromToken(discogsApiToken);
            var environment = DiscogsApiClientEnvironment.CreateDefault(credentials);
            return DiscogsApiClient.Create(environment);
        }

        static async Task Main()
        {
            const string discogsApiTokenEnvVar = "DISCOGS_API_TOKEN";
            var discogsApiToken = Environment.GetEnvironmentVariable(discogsApiTokenEnvVar) ??
                throw new ApplicationException(
                    $"You need to set {discogsApiTokenEnvVar} environment variable. " +
                    "You can just place your token in `var discogsApiToken = ...`."
                );
            var client = CreateDiscogsApiClient(discogsApiToken);
            var db = client.Database;
            var pagination = client.Pagination;
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
                searchResults = await pagination.Next(searchResults);
            }
        }
    }
}