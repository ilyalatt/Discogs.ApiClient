namespace Discogs.ApiClient.ApiModel.Dto.Responses.Database
{
    public sealed class CommunityBrief
    {
        public int Have { get; }
        public int Want { get; }

        public CommunityBrief(int have, int want)
        {
            Have = have;
            Want = want;
        }
    }
}