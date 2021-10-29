namespace Orderio.Application.Services
{
    public class Result<T> : IResult<T>
    {
        public Result(T data, bool isSuccessed, string error)
        {
            Data = data;
            IsSuccessed = isSuccessed;
            Error = error;
        }

        public Result(string error) : this(default, false, error)
        {

        }

        public Result(T data) : this(data, true, null)
        {

        }

        public Result() : this(default, true, null)
        {

        }


        public T Data { get; }
        public bool IsSuccessed { get; }
        public string Error { get; }
    }
}
