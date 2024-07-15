using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITIES.Models
{
    public class OgrenciDers : BaseEntity
    {
        public int OgrenciDersId { get; set; }
        [ForeignKey("Ogrenci")]
        public int OgrenciId { get; set; }
        [ForeignKey("Ders")]
        public int DersId { get; set; }



        public Ogrenci Ogrenci { get; set; }
        public Ders Ders { get; set; }
    }
}
