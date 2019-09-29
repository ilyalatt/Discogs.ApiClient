using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Discogs.ApiClient.ApiModel.Responses.Database.GetRelease
{
    // https://www.discogs.com/developers/#page:database,header:database-release
    public sealed class Release
    {
        public List<string> Styles { get; set; }
        public List<Series> Series { get; set; }
        public List<Label> Labels { get; set; }
        public int Year { get; set; }
        public Community Community { get; set; }
        public List<Artist> Artists { get; set; }
        public List<Image> Images { get; set; }
        public int FormatQuantity { get; set; }
        public int Id { get; set; }
        public string ArtistsSort { get; set; }
        public List<string> Genres { get; set; }
        public string Thumb { get; set; }
        public int NumForSale { get; set; }
        public string Title { get; set; }
        public DateTime? DateChanged { get; set; }
        public double? LowestPrice { get; set; }
        public string Status { get; set; }
        public string ReleasedFormatted { get; set; }
        public int EstimatedWeight { get; set; }
        public string Released { get; set; }
        public DateTime? DateAdded { get; set; }
        public List<Track> Tracklist { get; set; }
        [JsonProperty("extraartists")]
        public List<Artist> ExtraArtists { get; set; }
        public string Country { get; set; }
        public List<Identifier> Identifiers { get; set; }
        public List<Company> Companies { get; set; }
        public string Uri { get; set; }
        public List<Format> Formats { get; set; }
        public string ResourceUrl { get; set; }
        public string DataQuality { get; set; }
    }
}