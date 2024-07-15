using ENTITIES.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.MAP
{
    public class OgretmenDersMap : BaseMap<OgretmenDers>
    {
        public void Configure(EntityTypeBuilder<OgretmenDers> builder)
        {
           
        }
    }
}
