using DAL.Contecxt;
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
            services.AddIdentity<Ogrenci, IdentityRole>(x =>
            {
                x.Password.RequiredUniqueChars = 0;
                x.Password.RequiredLength = 8;

            }).AddEntityFrameworkStores<MyContext>();

            return services;

        }
    }
}
