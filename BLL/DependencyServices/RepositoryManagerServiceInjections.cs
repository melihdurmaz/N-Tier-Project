using BLL.ManagerServices.Abstracts;
using BLL.ManagerServices.Concretes;
using DAL.Repositories.Abstracts;
using DAL.Repositories.Concretes;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DependencyServices
{
    public static class RepositoryManagerServiceInjections
    {
        public static IServiceCollection AddRepositoryManagerService(this IServiceCollection services)
        {
            services.AddScoped(typeof(Irepository<>), typeof(BaseRepository<>));
            services.AddScoped(typeof(IManager<>), typeof(BaseManager<>));
            
            services.AddScoped<IOgrenciRepository, OgrenciRepository>();
            services.AddScoped<IDersRepository, DersRepository>();
            services.AddScoped<IOgretmenRepository, OgretmenRepository>();
            services.AddScoped<IBolumRepository, BolumRepository>();
            services.AddScoped<IOgrenciDersRepository, OgrenciDersRepository>();
            services.AddScoped<IOgretmenDersRepository, OgretmenDersRepository>();
            services.AddScoped<IOgrenciManager,OgrenciManager>();
            services.AddScoped<IDersManager, DersManager>();
            services.AddScoped<IOgrenciDersManager, OgrenciDersManager>();
            services.AddScoped<IBolumManager,BolumManager>();
            services.AddScoped<IOgretmenManager, OgretmenManager>();
            services.AddScoped<IOgretmenDersManager, OgretmenDersManager>();
            return services;
        }
    }
}
