namespace Discogs.ApiClient.ApiModel.Dto.Responses.Database.GetRelease
{
    public sealed class Artist
    {
        public string Join { get; }
        public string Name { get; }
        public string Anv { get; }
        public string Tracks { get; }
        public string Role { get; }
        public string ResourceUrl { get; }
        public int Id { get; }

        public Artist(string join, string name, string anv, string tracks, string role, string resourceUrl, int id)
        {
            Join = join;
            Name = name;
            Anv = anv;
            Tracks = tracks;
            Role = role;
            ResourceUrl = resourceUrl;
            Id = id;
        }
    }
}