namespace Discogs.ApiClient.ApiModel.Exceptions
{
    public sealed class DiscogsApiServerErrorException : DiscogsApiException
    {
        public DiscogsApiServerErrorException(string apiMessage) : base(apiMessage) { }
    }
}