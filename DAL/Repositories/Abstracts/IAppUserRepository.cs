using ENTITIES.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories.Abstracts
{
    public interface IAppUserRepository :Irepository<AppUser>
    {
        Task<bool> AddUser(AppUser user);
    }
}
