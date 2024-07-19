using ENTITIES.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace DAL.MAP
{
    public class OgrenciDersMap : BaseMap<OgrenciDers>
    {

        public void Configure(EntityTypeBuilder<OgrenciDers> builder)
        {
            builder
           .HasOne(od => od.Ders)
           .WithMany(d => d.OgrenciDersler)
           .HasForeignKey(od => od.Id)
           .OnDelete(DeleteBehavior.Cascade);

            builder
                .HasOne(od => od.Ogrenci)
                .WithMany(o => o.OgrenciDersler)
                .HasForeignKey(od => od.OgrenciId)
                .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
