namespace Discogs.ApiClient.ApiModel.Dto.Responses
{
    public interface IPageable<T>
    {
        Pagination Pagination { get; }
    }
}
