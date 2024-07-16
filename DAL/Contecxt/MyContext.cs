using DAL.MAP;
using ENTITIES.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
namespace DAL.Contecxt
{
    

    public class MyContext :IdentityDbContext<Ogrenci,IdentityRole<int>,int>
    {
        public MyContext(DbContextOptions<MyContext> opt):base(opt)
        {
            
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.ApplyConfiguration(new DersMap());
            builder.ApplyConfiguration(new BolumMap());
            builder.ApplyConfiguration(new OgrenciDersMap());
            builder.ApplyConfiguration(new OgrenciMap());
            builder.ApplyConfiguration(new OgretmenDersMap());
            builder.ApplyConfiguration(new OgretmenMap());
        }
        public DbSet<Ders> Dersler{ get; set; }
        public DbSet<Ogrenci> Ogrenciler { get; set; }
        public DbSet<Ogretmen> Ogretmenler{ get; set; }
        public DbSet<Bolum> Bolumler{ get; set; }
        public DbSet<OgrenciDers> OgrenciDersler { get; set; }
        public DbSet<OgretmenDers> OgretmenDersler { get; set; }

    }

}
