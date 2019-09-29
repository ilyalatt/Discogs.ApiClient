namespace Discogs.ApiClient.ApiModel.Responses.Database.GetRelease
{
    public sealed class Company
    {
        public string Name { get; set; }
        public string EntityType { get; set; }
        public string Catno { get; set; }
        public string ResourceUrl { get; set; }
        public int Id { get; set; }
        public string EntityTypeName { get; set; }
    }
}