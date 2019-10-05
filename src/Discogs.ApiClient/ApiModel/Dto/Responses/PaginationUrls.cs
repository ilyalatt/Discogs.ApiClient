namespace Discogs.ApiClient.ApiModel.Dto.Responses
{
    public sealed class PaginationUrls
    {
        public string Last { get; }
        public string Next { get; }

        public PaginationUrls(string last, string next)
        {
            Last = last;
            Next = next;
        }
    }
}