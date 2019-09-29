using System.Collections.Generic;

namespace Discogs.ApiClient.ApiModel.Responses.Database
{
    public sealed class Format
    {
        public List<string> Descriptions { get; set; }
        public string Name { get; set; }
        public string Qty { get; set; }
    }
}