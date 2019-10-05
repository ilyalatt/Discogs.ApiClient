namespace Discogs.ApiClient.ApiModel.Dto.Responses.Database.GetRelease
{
    public sealed class Rating
    {
        public int Count { get; }
        public double Average { get; }

        public Rating(int count, double average)
        {
            Count = count;
            Average = average;
        }
    }
}