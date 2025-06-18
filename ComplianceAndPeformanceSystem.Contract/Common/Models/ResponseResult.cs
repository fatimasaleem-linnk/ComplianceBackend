namespace ComplianceAndPeformanceSystem.Contract.Common.Models;

public class ResponseResult<T>
{
    internal ResponseResult(bool succeeded, IEnumerable<string> errors, T? model)
    {
        Succeeded = succeeded;
        Errors = errors.ToArray();
        Model = model;
    }

    public bool Succeeded { get; set; }

    public string[] Errors { get; set; }
    public T? Model { get; set; }

    public static ResponseResult<T> Success(T? model)
    {
        return new ResponseResult<T>(true, new string[] { },model);
    }

    public static ResponseResult<T> Failure(IEnumerable<string> errors, T? model)
    {
        return new ResponseResult<T>(false, errors, model);
    }
}
