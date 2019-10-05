namespace Discogs.ApiClient.ApiModel.Dto.Responses.Database.GetRelease
{
    public sealed class Identifier
    {
        public string Type { get; }
        public string Value { get; }

        public Identifier(string type, string value)
        {
            Type = type;
            Value = value;
        }
    }
}