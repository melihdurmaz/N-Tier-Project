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
    public class DersRepository : BaseRepository<Ders>, IDersRepository
    {
        public DersRepository(MyContext db) : base(db)
        {
        }
    }
}
