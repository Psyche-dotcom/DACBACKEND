using DipoleDacCustomerAgentBackend.Profiles;

namespace DipoleDacCustomerAgentBackend.Extension
{
    public static class RegisteredServices
    {
        public static void ConfigureServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddAutoMapper(typeof(ProjectProfile));
        }
    }
}
