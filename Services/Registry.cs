


namespace ecom_web_api.Services;

public static class Registry
{
    public static void AddServices(this IServiceCollection services)
    {
        services.AddScoped<IUserService, UserService>();
    }
}
