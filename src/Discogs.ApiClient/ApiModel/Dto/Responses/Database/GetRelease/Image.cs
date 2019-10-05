namespace Discogs.ApiClient.ApiModel.Dto.Responses.Database.GetRelease
{
    public sealed class Image
    {
        public string Uri { get; }
        public int Height { get; }
        public int Width { get; }
        public string ResourceUrl { get; }
        public string Type { get; }
        public string Uri150 { get; }

        public Image(string uri, int height, int width, string resourceUrl, string type, string uri150)
        {
            Uri = uri;
            Height = height;
            Width = width;
            ResourceUrl = resourceUrl;
            Type = type;
            Uri150 = uri150;
        }
    }
}