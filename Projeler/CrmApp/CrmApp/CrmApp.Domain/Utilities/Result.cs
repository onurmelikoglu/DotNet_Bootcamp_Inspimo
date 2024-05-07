using System.Text.Json.Serialization;

namespace CrmApp.Domain.Utilities;

public class Result<T>
{
    public T? Data { get; set; } = default(T);
    public HashSet<string>? ErrorMessages { get; set; }
    public bool IsSuccess { get; set; }
    [JsonIgnore]
    public int StatusCode { get; set; }

    public static Result<T> Succeed(T data)
    {
        return new Result<T>()
        {
            Data = data,
            IsSuccess = true,
            StatusCode = 200
        };
    }
}