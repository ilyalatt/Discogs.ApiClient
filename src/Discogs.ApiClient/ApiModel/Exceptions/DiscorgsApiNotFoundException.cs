namespace Discogs.ApiClient.ApiModel.Exceptions
{
    public sealed class DiscorgsApiNotFoundException : DiscogsApiException
    {
        public DiscorgsApiNotFoundException(string apiMessage) : base(apiMessage) { }
    }
}