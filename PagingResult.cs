namespace Results
{
    public class PagingResult<T> : Result, IPagingResult<T>, IResult
    {
        public List<T> Data { get; }

        public int TotalItemCount { get; }

        public PagingResult(List<T> data, int totalItemCount, bool success, string message)
            : base(success, message)
        {
            Data = data;
            TotalItemCount = totalItemCount;
        }
    }
}
