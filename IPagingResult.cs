namespace Results
{
    public interface IPagingResult<T> : IResult
    {
        List<T> Data { get; }

        int TotalItemCount { get; }
    }
}
