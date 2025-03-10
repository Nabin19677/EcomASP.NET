


using ecom_web_api.models;
using ecom_web_api.repository;
using ecom_web_api.entities;

namespace ecom_web_api.services;


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
