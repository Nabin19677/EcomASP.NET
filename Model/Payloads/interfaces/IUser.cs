namespace ecom_web_api.Models;

public interface ISignupUserRequestPayload
{
    string Name { get; set; }

    string Email { get; set; }

    string Password { get; set; }
}

public interface ISignupUserResponsePayload
{
    string Message { get; set; }
}
