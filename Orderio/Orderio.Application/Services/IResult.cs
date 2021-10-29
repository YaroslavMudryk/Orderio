namespace Orderio.Application.Services
{
    public interface IResult
    {
        bool IsSuccessed { get; }
        string Error { get; }
    }

    public interface IResult<TResult> : IResult
    {
        TResult Data { get; }
    }
}
