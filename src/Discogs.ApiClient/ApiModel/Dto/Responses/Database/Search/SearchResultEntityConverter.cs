using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Discogs.ApiClient.ApiModel.Dto.Responses.Database.Search
{
    sealed class SearchResultEntityConverter : JsonConverter
    {
        public override bool CanConvert(Type objectType) =>
            objectType == typeof(ISearchResultEntity);
        
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer) =>
            throw new NotImplementedException();

        public override object ReadJson(
            JsonReader reader, 
            Type objectType,
            object existingValue, 
            JsonSerializer serializer
        )
        {
            if (reader.TokenType == JsonToken.Null) return null;

            var obj = JObject.Load(reader);
            var typeStr = obj["type"].Value<string>();
            if (!Enum.TryParse(typeStr, ignoreCase: true, result: out DiscogsSearchEntityType type))
            {
                throw new JsonSerializationException(
                    $"Discogs search entity type `{typeStr}` is not supported."
                );
            }

            switch (type)
            {
                case DiscogsSearchEntityType.Artist: return obj.ToObject<ArtistBrief>(serializer);
                case DiscogsSearchEntityType.Label: return obj.ToObject<LabelBrief>(serializer);
                case DiscogsSearchEntityType.Master: return obj.ToObject<MasterReleaseBrief>(serializer);
                case DiscogsSearchEntityType.Release: return obj.ToObject<ReleaseBrief>(serializer);
                default: throw new Exception("WTF");
            }
        }
    }
}