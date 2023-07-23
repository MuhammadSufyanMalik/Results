using System.Net;

namespace Results
{
    public class ErrorDataResult<T> : DataResult<T>
    {
        public ErrorDataResult(T data, string messageTranslateKey, HttpStatusCode statusCode)
                  : base(data, success: false, statusCode, messageTranslateKey)
        {
        }

        public ErrorDataResult(T data, string message)
            : base(data, success: false, message)
        {
        }

        public ErrorDataResult(T data, string message, string messageTranslateKey, HttpStatusCode statusCode)
            : base(data, success: false, statusCode, message, messageTranslateKey)
        {
        }

        public ErrorDataResult(T data)
            : base(data, success: false)
        {
        }

        public ErrorDataResult(string message)
            : base(default(T), success: false, message)
        {
        }

        public ErrorDataResult()
            : base(default(T), success: false)
        {
        }
    }
}
