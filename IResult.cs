using System.Net;

namespace Results
{
    public interface IResult
    {
        bool Success { get; }
        string Message { get; set; }
        string MessageTranslateKey { get; set; }
        HttpStatusCode? StatusCode { get; set; }
    }
}
