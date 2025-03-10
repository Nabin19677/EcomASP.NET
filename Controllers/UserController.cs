using ecom_web_api.entities;
using ecom_web_api.models;
using ecom_web_api.repository;
using ecom_web_api.services;
using Microsoft.AspNetCore.Mvc;

[Route("api/[controller]")]
[ApiController]
public class UserController : ControllerBase
{
    private readonly IUserService _userService;

    public UserController(IUserService userService)
    {
        _userService = userService;
    }

    [HttpPost("signup")]
    public async Task<IActionResult> Signup([FromBody] SignupUserRequestPayload payload)

    {
        var response = await _userService.CreateUser(payload);

        if (!response.Success)
        {
            return BadRequest(new ApiResponse<string>(false, response.Message));
        }

        return Ok(new ApiResponse<SignupUserResponsePayload>(true, response.Data, "User created successfully"));
    }

}
