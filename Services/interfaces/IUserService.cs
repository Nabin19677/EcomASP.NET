

using ecom_web_api.Models;

namespace ecom_web_api.Services;

public interface IUserService
{
    Task<ServiceResult<SignupUserResponsePayload>> CreateUser(SignupUserRequestPayload payload);

}
