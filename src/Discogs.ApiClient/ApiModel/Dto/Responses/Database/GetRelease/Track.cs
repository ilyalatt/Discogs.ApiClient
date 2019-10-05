using Newtonsoft.Json;

namespace Discogs.ApiClient.ApiModel.Dto.Responses.Database.GetRelease
{
    public sealed class Track
    {
        public string Duration { get; }
        public string Position { get; }
        [JsonProperty("type_")]
        public string Type { get; }
        public string Title { get; }

        public Track(string duration, string position, string type, string title)
        {
            Duration = duration;
            Position = position;
            Type = type;
            Title = title;
        }
    }
}