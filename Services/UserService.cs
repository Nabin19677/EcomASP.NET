


using ecom_web_api.Models;
using ecom_web_api.Repository;
using ecom_web_api.Entities;

namespace ecom_web_api.Services;


public class UserService : IUserService
{

    private readonly IUserRepository _userRepository;

    public UserService(IUserRepository userRepository)
    {
        _userRepository = userRepository;
    }


    public async Task<ServiceResult<SignupUserResponsePayload>> CreateUser(SignupUserRequestPayload payload)
    {
        try
        {
            var userEntity = new User
            {
                Name = payload.Name,
                Email = payload.Email,
                Password = payload.Password
            };

            await _userRepository.AddAsync(userEntity);

            return new ServiceResult<SignupUserResponsePayload>(
                     true,
                     new SignupUserResponsePayload { Message = "User created successfully" }
                 );
        }
        catch (Exception ex)
        {
            return new ServiceResult<SignupUserResponsePayload>(false, null, "Error creating user: " + ex.Message);
        }
    }
}
