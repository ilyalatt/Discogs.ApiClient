namespace Discogs.ApiClient.ApiModel.Dto.Responses.Database.GetRelease
{
    public sealed class Company
    {
        public string Name { get; }
        public string EntityType { get; }
        public string Catno { get; }
        public string ResourceUrl { get; }
        public int Id { get; }
        public string EntityTypeName { get; }

        public Company(string name, string entityType, string catno, string resourceUrl, int id, string entityTypeName)
        {
            Name = name;
            EntityType = entityType;
            Catno = catno;
            ResourceUrl = resourceUrl;
            Id = id;
            EntityTypeName = entityTypeName;
        }
    }
}