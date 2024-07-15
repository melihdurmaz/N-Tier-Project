using ENTITIES.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.MAP
{
    public class OgretmenMap : BaseMap<Ogretmen>
    {
        public void Configure(EntityTypeBuilder<Ogretmen> builder)
        {
            
        }
    }
}
