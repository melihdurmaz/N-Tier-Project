using ENTITIES.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITIES.Models
{
    public abstract  class BaseEntity:IEntity
    {
        public int Id { get; set; }
        public DateTime CreatedDate{ get; set; }
    }
}
