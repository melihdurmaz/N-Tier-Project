﻿using ENTITIES.Identity;
using ENTITIES.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.ManagerServices.Abstracts
{
    public interface IAppUserManager:IManager<AppUser>
    {
        Task<bool> CreateUserAsync(AppUser item);
    }
}
