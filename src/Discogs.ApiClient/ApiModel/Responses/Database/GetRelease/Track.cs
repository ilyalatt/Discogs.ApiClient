using Newtonsoft.Json;

namespace Discogs.ApiClient.ApiModel.Responses.Database.GetRelease
{
    public sealed class Track
    {
        public string Duration { get; set; }
        public string Position { get; set; }
        [JsonProperty("type_")]
        public string Type { get; set; }
        public string Title { get; set; }
    }
}