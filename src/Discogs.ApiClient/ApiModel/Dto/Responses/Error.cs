namespace Discogs.ApiClient.ApiModel.Dto.Responses
{
    public sealed class Error
    {
        public string Message { get; }

        public Error(string message)
        {
            Message = message;
        }
    }
}