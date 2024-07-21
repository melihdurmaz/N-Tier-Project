using Castle.Core.Configuration;
using DAL.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DependencyServices
{
    public static class DbContextServiceInjection
    {
        public static IServiceCollection AddDbContextService(this IServiceCollection services, Microsoft.Extensions.Configuration.IConfiguration configuration)
        {
            // Register the DbContext with the service collection
            services.AddDbContextPool<MyContext>(options =>
                options.UseSqlServer(configuration.GetConnectionString("DefaultConnection"))
                       .UseLazyLoadingProxies());

            return services;
        }
    }
}
