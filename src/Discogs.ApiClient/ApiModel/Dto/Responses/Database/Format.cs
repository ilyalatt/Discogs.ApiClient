using System.Collections.Generic;

namespace Discogs.ApiClient.ApiModel.Dto.Responses.Database
{
    public sealed class Format
    {
        public IReadOnlyList<string> Descriptions { get; }
        public string Name { get; }
        public string Qty { get; }

        public Format(IReadOnlyList<string> descriptions, string name, string qty)
        {
            Descriptions = descriptions;
            Name = name;
            Qty = qty;
        }
    }
}