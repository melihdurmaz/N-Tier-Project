using DAL.Context;
using DAL.Repositories.Abstracts;
using ENTITIES.Models;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories.Concretes
{
    public class OgrenciRepository : BaseRepository<Ogrenci>,IOgrenciRepository
    {
        //UserManager<Ogrenci> _userManager;
        public OgrenciRepository(MyContext db) : base(db)
        {
           // _userManager = userManager;
        }
        //public async Task<bool> AddUser(Ogrenci item)
        //{
        //   // 

        //}
    }
}
