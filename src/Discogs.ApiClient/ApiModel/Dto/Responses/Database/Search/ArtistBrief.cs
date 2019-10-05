namespace Discogs.ApiClient.ApiModel.Dto.Responses.Database.Search
{
    public sealed class ArtistBrief : ISearchResultEntity
    {
        public string Thumb { get; }
        public string Title { get; }
        public UserData UserData { get; }
        public string Uri { get; }
        public string CoverImage { get; }
        public int Id { get; }

        public ArtistBrief(string thumb, string title, UserData userData, string uri, string coverImage, int id)
        {
            Thumb = thumb;
            Title = title;
            UserData = userData;
            Uri = uri;
            CoverImage = coverImage;
            Id = id;
        }
    }
}