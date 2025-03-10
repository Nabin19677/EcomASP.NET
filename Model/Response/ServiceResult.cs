namespace ecom_web_api.Models;

public class ServiceResult<T>
{
    public bool Success { get; set; }
    public string Message { get; set; }
    public T Data { get; set; }

    public ServiceResult(bool success, T data, string message = "")
    {
        Success = success;
        Message = message;
        Data = data;
    }
}
