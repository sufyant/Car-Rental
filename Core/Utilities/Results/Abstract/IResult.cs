namespace Core.Utilities.Results.Abstract
{
    // Temel voidler icin
    public interface IResult
    {
        bool Success { get; }
        string Message { get; }
    }
}