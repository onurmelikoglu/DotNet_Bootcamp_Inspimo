using System.Net;

namespace IdentityApp.Domain.Utilities;

public sealed class Result<T>
{
    public T? Data { get; set; }
    public HashSet<string>? ErrorMessage { get; set; }
    public bool IsSucceed { get; set; }
    public int StatusCode { get; set; }
    
    public static Result<T> Succeed(T data)
    {
        return new Result<T>()
        {
            Data = data,
            IsSucceed = true,
            StatusCode = 200
        };
    }
    
    public static Result<T> Failure(HashSet<string> errorMessages)
    {
        return new Result<T>()
        {
            ErrorMessage = errorMessages,
            IsSucceed = false,
            StatusCode = 400
        };
    }
    
    public static Result<T> Failure(string errorMessage)
    {
        return new Result<T>()
        {
            ErrorMessage = new HashSet<string>(){errorMessage},
            IsSucceed = false,
            StatusCode = 400
        };
    }
}