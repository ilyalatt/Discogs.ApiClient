namespace Discogs.ApiClient.ApiModel.Dto.Responses.Database.GetRelease
{
    public sealed class Video
    {
        public string Description { get; }
        public int Duration { get; }
        public bool Embed { get; }
        public string Title { get; }
        public string Uri { get; }

        public Video(string description, int duration, bool embed, string title, string uri)
        {
            Description = description;
            Duration = duration;
            Embed = embed;
            Title = title;
            Uri = uri;
        }
    }
}