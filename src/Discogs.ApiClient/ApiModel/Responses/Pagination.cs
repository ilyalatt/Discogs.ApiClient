namespace Discogs.ApiClient.ApiModel.Responses
{
    public sealed class Pagination
    {
        public int PerPage { get; set; }
        public int Pages { get; set; }
        public int Page { get; set; }
        public PaginationUrls Urls { get; set; }
        public int Items { get; set; }
    }
}