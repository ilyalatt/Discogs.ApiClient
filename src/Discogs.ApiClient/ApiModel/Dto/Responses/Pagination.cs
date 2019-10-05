namespace Discogs.ApiClient.ApiModel.Dto.Responses
{
    public sealed class Pagination
    {
        public int PerPage { get; }
        public int Pages { get; }
        public int Page { get; }
        public PaginationUrls Urls { get; }
        public int Items { get; }

        public Pagination(int perPage, int pages, int page, PaginationUrls urls, int items)
        {
            PerPage = perPage;
            Pages = pages;
            Page = page;
            Urls = urls;
            Items = items;
        }
    }
}