using System.Net;

namespace Results
{
    public class ErrorResult : Result
    {
        public ErrorResult(string messageTranslateKey, HttpStatusCode statusCode)
            : base(success: false, messageTranslateKey, statusCode)
        {
        }

        public ErrorResult(string message)
            : base(success: false, message)
        {
        }

        public ErrorResult()
            : base(success: false)
        {
        }
    }
}
