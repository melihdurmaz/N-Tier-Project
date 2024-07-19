using ENTITIES.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITIES.Models
{
    public class Denemee: IEntity
    {
        public int ID { get; set; }
        public string Name { get; set; }
    }
}
