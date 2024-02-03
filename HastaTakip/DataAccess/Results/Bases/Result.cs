
namespace DataAccess.Results.Bases
{
    public abstract class Result
    {
        public bool IsSuccessful { get; private set; }
        public string Message { get; set; }

        protected Result(bool isSuccessful, string message)
        {
            IsSuccessful = isSuccessful;
            Message = message;
        }
    }
}
