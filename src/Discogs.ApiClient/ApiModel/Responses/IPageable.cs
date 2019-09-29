namespace Discogs.ApiClient.ApiModel.Responses
{
    public interface IPageable<T>
    {
        Pagination Pagination { get; set; }
    }
}
