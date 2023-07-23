using System.Net;

namespace Results
{
    public class SuccessResult : Result
    {
        public SuccessResult(string message)
            : base(success: true, message)
        {
            base.StatusCode = HttpStatusCode.OK;
        }

        public SuccessResult(string messageTranslateKey, HttpStatusCode statusCode = HttpStatusCode.OK)
            : base(success: true, messageTranslateKey, statusCode)
        {
        }

        public SuccessResult()
            : base(success: true)
        {
            base.StatusCode = HttpStatusCode.OK;
        }
    }
}
