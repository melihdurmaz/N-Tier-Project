﻿using DAL.Context;
using DAL.Repositories.Abstracts;
using ENTITIES.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories.Concretes
{
    public class OgrenciDersRepository : BaseRepository<OgrenciDers>, IOgrenciDersRepository
    {
        public OgrenciDersRepository(MyContext db) : base(db)
        {
        }
    }
}
