namespace ecom_web_api.models;
public class ApiResponse<T>
{
    public bool Success { get; set; }
    public string Message { get; set; }
    public T? Data { get; set; }

    public ApiResponse(bool success, T data, string message = "")
    {
        Success = success;
        Message = message;
        Data = data;
    }

    public ApiResponse(bool success, string message = "")
    {
        Success = success;
        Message = message;
    }
}

