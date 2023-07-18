using DacBackend.Data.Context;
using Microsoft.EntityFrameworkCore;

namespace DipoleDacCustomerAgentBackend.Extension
{
    public static class DbContextRegistered
    {
        public static void ConfigureDb(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<DipoleDacContext>(dbContextOptions => dbContextOptions.UseSqlite(configuration["ConnectionStrings:DipoleConnectionString"]));
        }
    }
}