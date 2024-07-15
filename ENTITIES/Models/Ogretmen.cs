using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITIES.Models
{
    public class Ogretmen:BaseEntity
    {
        
        public string Name { get; set; }
        public ICollection<OgretmenDers> OgretmenDersler { get; set; }
    }
}
