using DAL.MAP;
using ENTITIES.Identity;
using ENTITIES.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Context
{
    public class MyContext:IdentityDbContext<AppUser,AppRole,int>
    {
        public MyContext()
        {
            
        }
        public MyContext(DbContextOptions<MyContext> options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            //Map katmanında herhangi bir işlem yapmadım ancak migration oluştuğunda ogrenciders tablosunda ki 
            //deletebehaicır.----- olan özelliği deletebehavior.NOACTİON olarak değiştirdim
        }
        public DbSet<Ders> Dersler { get; set; }
        public DbSet<Ogrenci> Ogrenciler { get; set; }
        public DbSet<Ogretmen> Ogretmenler { get; set; }
        public DbSet<Bolum> Bolumler { get; set; }
        public DbSet<OgrenciDers> OgrenciDersler { get; set; }
        public DbSet<OgretmenDers> OgretmenDersler { get; set; }
        //public DbSet<Denemee> Denemes{ get; set; }

    }
}
