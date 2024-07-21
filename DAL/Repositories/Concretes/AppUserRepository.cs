using DAL.Context;
using DAL.Repositories.Abstracts;
using ENTITIES.Identity;
using ENTITIES.Models;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories.Concretes
{
    public class AppUserRepository : BaseRepository<AppUser>, IAppUserRepository
    {
        private readonly UserManager<AppUser> _userManager;

        public AppUserRepository(UserManager<AppUser> userManager,MyContext db):base(db) 
        {
            _userManager = userManager;
        }

        public async Task<bool> AddUser(AppUser user)
        {
            IdentityResult result = await _userManager.CreateAsync(user,user.PasswordHash);

            if (result.Succeeded)
                return true;

            // Eğer hata varsa, hataları işleyebilir veya loglayabilirsiniz.
            foreach (IdentityError error in result.Errors)
            {
                // Hata işleme
                // Örneğin: loglama veya kullanıcıya geri bildirim
            }

            return false;

        }

       
    }
}
