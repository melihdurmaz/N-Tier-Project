using BLL.ManagerServices.Abstracts;
using DAL.Repositories.Abstracts;
using ENTITIES.Identity;
using ENTITIES.Models;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.ManagerServices.Concretes
{
    public class AppUserManager : BaseManager<AppUser>, IAppUserManager
    {

        private readonly UserManager<AppUser> _userManager;
        IAppUserRepository _userRepository;
        public AppUserManager(UserManager<AppUser> userManager,IAppUserRepository userRepository) : base(userRepository)
        {
            _userManager = userManager;
            _userRepository = userRepository;
        }

       

        public async Task<bool> CreateUserAsync(AppUser item)
        {
            return await _userRepository.AddUser(item);
        }
    }
}
