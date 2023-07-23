using System.Net;

namespace Results
{
    public class DataResult<T> : Result, IDataResult<T>
    {
        // override yerine this kullanılıyoruz. Base ise miras aldığı yerdeki metodu çağırmak için
        public T Data { get; }

        public DataResult(T data, bool success, HttpStatusCode statusCode, string messageTranslateKey)
            : base(success, messageTranslateKey, statusCode)
        {
            Data = data;
        }

        public DataResult(T data, bool success, HttpStatusCode statusCode, string message, string messageTranslateKey)
            : base(success, message, statusCode)
        {
            Data = data;
            base.MessageTranslateKey = messageTranslateKey;
        }

        public DataResult(T data, bool success, string message)
            : base(success, message)
        {
            Data = data;
        }

        public DataResult(T data, bool success)
            : base(success)
        {
            Data = data;
        }
    }
}
