using System.Net;

namespace Results
{
    public class Result : IResult
    {
        public bool Success { get; }

        public string Message { get; set; }

        public string MessageTranslateKey { get; set; }

        public HttpStatusCode? StatusCode { get; set; }
        public Result(bool success, string messageTranslateKey, HttpStatusCode statusCode) : this(success, messageTranslateKey)
        {
            StatusCode = statusCode;
            MessageTranslateKey = messageTranslateKey;
        }

        public Result(bool success, string message)
            : this(success)
        {
            Message = message;
        }

        public Result(bool success)
        {
            Success = success;
        }
    }
}
