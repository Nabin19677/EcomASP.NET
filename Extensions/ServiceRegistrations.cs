using ecom_web_api.repository;
using ecom_web_api.services;


namespace ecom_web_api.extensions
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
