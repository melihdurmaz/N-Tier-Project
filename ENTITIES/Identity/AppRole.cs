﻿using ENTITIES.Interfaces;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITIES.Identity
{
    public class AppRole:IdentityRole<int>,IEntity
    {
    }
}
