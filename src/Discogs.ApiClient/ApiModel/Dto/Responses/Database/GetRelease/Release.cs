using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Discogs.ApiClient.ApiModel.Dto.Responses.Database.GetRelease
{
    // https://www.discogs.com/developers/#page:database,header:database-release
    public sealed class Release
    {
        public IReadOnlyList<string> Styles { get; }
        public IReadOnlyList<Series> Series { get; }
        public IReadOnlyList<Label> Labels { get; }
        public int Year { get; }
        public Community Community { get; }
        public IReadOnlyList<Artist> Artists { get; }
        public IReadOnlyList<Image> Images { get; }
        public int FormatQuantity { get; }
        public int Id { get; }
        public string ArtistsSort { get; }
        public IReadOnlyList<string> Genres { get; }
        public string Thumb { get; }
        public int NumForSale { get; }
        public string Title { get; }
        public DateTime? DateChanged { get; }
        public double? LowestPrice { get; }
        public string Status { get; }
        public string ReleasedFormatted { get; }
        public int EstimatedWeight { get; }
        public string Released { get; }
        public DateTime? DateAdded { get; }
        public IReadOnlyList<Track> Tracklist { get; }
        [JsonProperty("extraartists")]
        public IReadOnlyList<Artist> ExtraArtists { get; }
        public string Country { get; }
        public IReadOnlyList<Identifier> Identifiers { get; }
        public IReadOnlyList<Company> Companies { get; }
        public string Uri { get; }
        public IReadOnlyList<Format> Formats { get; }
        public string ResourceUrl { get; }
        public string DataQuality { get; }

        public Release(IReadOnlyList<string> styles, IReadOnlyList<Series> series, IReadOnlyList<Label> labels, int year, Community community, IReadOnlyList<Artist> artists, IReadOnlyList<Image> images, int formatQuantity, int id, string artistsSort, IReadOnlyList<string> genres, string thumb, int numForSale, string title, DateTime? dateChanged, double? lowestPrice, string status, string releasedFormatted, int estimatedWeight, string released, DateTime? dateAdded, IReadOnlyList<Track> tracklist, IReadOnlyList<Artist> extraArtists, string country, IReadOnlyList<Identifier> identifiers, IReadOnlyList<Company> companies, string uri, IReadOnlyList<Format> formats, string resourceUrl, string dataQuality)
        {
            Styles = styles;
            Series = series;
            Labels = labels;
            Year = year;
            Community = community;
            Artists = artists;
            Images = images;
            FormatQuantity = formatQuantity;
            Id = id;
            ArtistsSort = artistsSort;
            Genres = genres;
            Thumb = thumb;
            NumForSale = numForSale;
            Title = title;
            DateChanged = dateChanged;
            LowestPrice = lowestPrice;
            Status = status;
            ReleasedFormatted = releasedFormatted;
            EstimatedWeight = estimatedWeight;
            Released = released;
            DateAdded = dateAdded;
            Tracklist = tracklist;
            ExtraArtists = extraArtists;
            Country = country;
            Identifiers = identifiers;
            Companies = companies;
            Uri = uri;
            Formats = formats;
            ResourceUrl = resourceUrl;
            DataQuality = dataQuality;
        }
    }
}