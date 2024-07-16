﻿using DAL.Contecxt;
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
        public static IServiceCollection AddDbContextService(this IServiceCollection services)
        {
            ServiceProvider provider = services.BuildServiceProvider();
            IConfiguration configuration = provider.GetService<IConfiguration>();
            services.AddDbContextPool<MyContext>(options => options.UseSqlServer(configuration.GetConnectionString
                ("MyConnecion")).UseLazyLoadingProxies());
            return services;
        }
    }
}
