using ecom_web_api.Repository;
using ecom_web_api.Services;


namespace ecom_web_api.Extensions
{
    public static class ServiceRegistrations
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services)
        {
            // Register Repositories
            services.AddRepositories();

            // Register Services
            services.AddServices();

            return services;
        }
    }
}
