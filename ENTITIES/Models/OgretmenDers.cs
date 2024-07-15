using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITIES.Models
{
    public class OgretmenDers:BaseEntity
    {

        [Key] public int OgrentmenDersId { get; set; }
        public int OgretmenId { get; set; }
        public int DersId { get; set; }
        public Ogretmen Ogretmen{ get; set; }
        public Ders Ders { get; set; } = new Ders();
    }
}
