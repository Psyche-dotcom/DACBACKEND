using DipoleDacCustomerAgentBackend.Profiles;
using DipoleDacCustomerAgentBackend.Service.Implementation;
using DipoleDacCustomerAgentBackend.Service.Interface;

namespace DipoleDacCustomerAgentBackend.Extension
{
    public static class RegisteredServices
    {
        public static void ConfigureServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddAutoMapper(typeof(ProjectProfile));
            services.AddHttpClient<IAccountHttpService, AccountHttpService>(client => client.BaseAddress = new Uri("https://nodered.dipolediamond.com/"));
            //services.AddScoped<IAccountHttpService, AccountHttpService>();
        }
    }
}
