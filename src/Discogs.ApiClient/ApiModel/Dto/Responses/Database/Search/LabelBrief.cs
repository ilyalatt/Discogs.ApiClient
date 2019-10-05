namespace Discogs.ApiClient.ApiModel.Dto.Responses.Database.Search
{
    public sealed class LabelBrief : ISearchResultEntity
    {
        public string Title { get; }
        public string Uri { get; }
        public string CoverImage { get; }
        public int Id { get; }

        public LabelBrief(string title, string uri, string coverImage, int id)
        {
            Title = title;
            Uri = uri;
            CoverImage = coverImage;
            Id = id;
        }
    }
}