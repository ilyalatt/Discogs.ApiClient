namespace Discogs.ApiClient.ApiModel.Dto.Responses.Database.Search
{
    public interface ISearchResultEntity
    {
        int Id { get; }
        string Uri { get; }
        string Title { get; }
        string CoverImage { get; }
    }
}