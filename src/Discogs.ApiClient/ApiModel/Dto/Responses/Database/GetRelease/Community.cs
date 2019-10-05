using System.Collections.Generic;

namespace Discogs.ApiClient.ApiModel.Dto.Responses.Database.GetRelease
{
    public sealed class Community
    {
        public string Status { get; }
        public Rating Rating { get; }
        public int Have { get; }
        public IReadOnlyList<Contributor> Contributors { get; }
        public int Want { get; }
        public Submitter Submitter { get; }
        public string DataQuality { get; }

        public Community(string status, Rating rating, int have, IReadOnlyList<Contributor> contributors, int want, Submitter submitter, string dataQuality)
        {
            Status = status;
            Rating = rating;
            Have = have;
            Contributors = contributors;
            Want = want;
            Submitter = submitter;
            DataQuality = dataQuality;
        }
    }
}