using System.Net;

namespace Results
{
    public class Result : IResult
    {
        public Result(bool success, string messageTranslateKey, HttpStatusCode statusCode)
       : this(success, messageTranslateKey)
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
        public bool Success { get; }

        public string Message { get; }

        public string MessageTranslateKey { get; set; }

        public HttpStatusCode? StatusCode { get; set; }
    }
}
