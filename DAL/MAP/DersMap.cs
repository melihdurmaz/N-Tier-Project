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
    public class DersMap : BaseMap<Ders>
    {
        public void Configure(EntityTypeBuilder<Ders> builder)
        {
        }
    }
}

