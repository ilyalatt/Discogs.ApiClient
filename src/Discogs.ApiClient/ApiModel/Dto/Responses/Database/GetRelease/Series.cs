namespace Discogs.ApiClient.ApiModel.Dto.Responses.Database.GetRelease
{
    public sealed class Series
    {
        public string Name { get; }
        public string EntityType { get; }
        public string ThumbnailUrl { get; }
        public string Catno { get; }
        public string ResourceUrl { get; }
        public int Id { get; }
        public string EntityTypeName { get; }

        public Series(string name, string entityType, string thumbnailUrl, string catno, string resourceUrl, int id, string entityTypeName)
        {
            Name = name;
            EntityType = entityType;
            ThumbnailUrl = thumbnailUrl;
            Catno = catno;
            ResourceUrl = resourceUrl;
            Id = id;
            EntityTypeName = entityTypeName;
        }
    }
}