using DAL.Context;
using ENTITIES.Identity;
using ENTITIES.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DependencyServices
{
    public static class IdentityExtensionService
    {
        public static IServiceCollection AddIdentityService(this IServiceCollection services)
        {
            services.AddIdentity<AppUser, AppRole>(x =>

            {
                
                x.Password.RequiredUniqueChars = 0;
                x.Password.RequiredLength = 3;
                x.Password.RequireNonAlphanumeric = false;
                x.Password.RequireDigit = false;
                x.Password.RequireLowercase = false;
                x.Password.RequireUppercase = false;

            }
                )
            .AddEntityFrameworkStores<MyContext>();
           
    
            return services;
        }
    }
}
