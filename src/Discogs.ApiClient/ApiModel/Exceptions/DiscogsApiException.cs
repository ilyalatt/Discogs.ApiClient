using System;

namespace Discogs.ApiClient.ApiModel.Exceptions
{
    public abstract class DiscogsApiException : Exception
    {
        public DiscogsApiException(string message) : base(message) { }
    }
}