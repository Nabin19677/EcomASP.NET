using System.ComponentModel.DataAnnotations;

namespace ecom_web_api.Models;

// Disable nullable checks for payload classes. Using `required` keyword causes issue with validation messages
#nullable disable

public class SignupUserRequestPayload : ISignupUserRequestPayload
{
  [Required(ErrorMessage = "Name is required.")]
  public string Name { get; set; }

  [Required(ErrorMessage = "Email is required.")]
  public string Email { get; set; }



  [Required(ErrorMessage = "Password is required.")]
  [MinLength(6, ErrorMessage = "Password must be at least 6 characters long.")]
  public string Password { get; set; }
}

public class SignupUserResponsePayload : ISignupUserResponsePayload
{
  public string Message { get; set; }
}
