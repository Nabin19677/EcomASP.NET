using System.ComponentModel.DataAnnotations;

namespace ecom_web_api.models;



public class SignupUserRequestPayload : ISignupUserRequestPayload
{
  [Required(ErrorMessage = "Name is required.")]
  public required string Name { get; set; }

  [Required(ErrorMessage = "Email is required.")]
  public required string Email { get; set; }



  [Required(ErrorMessage = "Password is required.")]
  [MinLength(6, ErrorMessage = "Password must be at least 6 characters long.")]
  public required string Password { get; set; }
}

public class SignupUserResponsePayload : ISignupUserResponsePayload
{
  public required string Message { get; set; }
}
