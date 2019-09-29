namespace Discogs.ApiClient.ApiModel.Exceptions
{
    public sealed class DiscogsApiQuotaException : DiscogsApiException
    {
        public const string ApiErrorMessage = "You are making requests too quickly.";
        public DiscogsApiQuotaException() : base(ApiErrorMessage) { }
    }
}