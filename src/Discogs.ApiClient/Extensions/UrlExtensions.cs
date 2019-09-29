using System.Linq;
using Flurl;
using Flurl.Util;
using Newtonsoft.Json.Serialization;

namespace Discogs.ApiClient.Extensions
{
    static class UrlExtensions
    {
        public static Url AsUrl(this string str) => new Url(str);

        static string ToSnakeCase(string str) =>
            new SnakeCaseNamingStrategy().GetPropertyName(str, false);
        
        public static string AppendQueryParams(this Url url, object obj) => obj
            .ToKeyValuePairs()
            .Aggregate(url, (a, x) => a.SetQueryParam(ToSnakeCase(x.Key), x.Value));
    }
}