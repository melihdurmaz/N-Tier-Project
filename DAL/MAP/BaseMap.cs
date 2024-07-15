using ENTITIES.Interfaces;
using ENTITIES.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.MAP
{
    public abstract class BaseMap<T> : IEntityTypeConfiguration<T> where T : class,IEntity
    {
        public void Configure(EntityTypeBuilder<T> builder)
        {
            throw new NotImplementedException();
        }
    }
}

