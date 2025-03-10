

using ecom_web_api.models;

namespace ecom_web_api.services;

public interface IUserService
{
    Task<ServiceResult<SignupUserResponsePayload>> CreateUser(SignupUserRequestPayload payload);

}
