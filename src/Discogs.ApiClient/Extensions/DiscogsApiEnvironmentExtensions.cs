using System.Net;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Discogs.ApiClient.ApiModel.Dto.Responses;
using Discogs.ApiClient.ApiModel.Dto.Responses.Database.Search;
using Discogs.ApiClient.ApiModel.Exceptions;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace Discogs.ApiClient.Extensions
{
    static class DiscogsApiEnvironmentExtensions
    {
        static T DeserializeJson<T>(string json)
        {
            var contractResolver = new DefaultContractResolver
            {
                NamingStrategy = new SnakeCaseNamingStrategy()
            };
            var jsonSerializerSettings = new JsonSerializerSettings
            {
                ContractResolver = contractResolver,
                Converters = new JsonConverter[]
                {
                    new SearchResultEntityConverter()
                }
            };
            return JsonConvert.DeserializeObject<T>(json, jsonSerializerSettings);
        }

        public static async Task<T> Get<T>(
            this DiscogsApiClientEnvironment environment,
            string url,
            CancellationToken cancellationToken = default
        )
        {
            var httpMessageInvoker = environment.HttpMessageInvoker;
            var resp = await httpMessageInvoker.SendAsync(
                new HttpRequestMessage(HttpMethod.Get, url),
                cancellationToken
            ).ConfigureAwait(false);
            var json = await resp.Content.ReadAsStringAsync().ConfigureAwait(false);

            var error = DeserializeJson<Error>(json);

            if (resp.StatusCode == HttpStatusCode.InternalServerError)
            {
                throw new DiscogsApiServerErrorException(error.Message);
            }

            if (resp.StatusCode == HttpStatusCode.NotFound)
            {
                throw new DiscorgsApiNotFoundException(error.Message);
            }

            if (error.Message != null)
            {
                if (error.Message == DiscogsApiQuotaException.ApiErrorMessage)
                {
                    throw new DiscogsApiQuotaException();
                }

                // TODO: rename the exception
                throw new DiscogsApiServerErrorException(error.Message);
            }

            return DeserializeJson<T>(json);
        }
    }
}