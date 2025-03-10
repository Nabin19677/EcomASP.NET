using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace ecom_web_api.Models;
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

    public static ApiResponse<Dictionary<string, string[]>> FromModelState(ModelStateDictionary modelState)
    {
        var errors = modelState.Where(x => x.Value.Errors.Count > 0).ToDictionary(kvp => kvp.Key, kvp => kvp.Value.Errors.Select(e => e.ErrorMessage).ToArray());

        return new ApiResponse<Dictionary<string, string[]>>(false, errors, "Validation failed.");
    }

    // Factory method for internal server errors
    public static ApiResponse<string> FromException(Exception ex)
    {
        return new ApiResponse<string>(false, null, "An unexpected error occurred. Please try again later.");
    }
}

