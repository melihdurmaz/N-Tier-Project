using ENTITIES.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITIES.Models
{
    public class Bolum : BaseEntity
    {
        
        public string bolum_Adi { get; set; }
        public ICollection<Ders> Dersler { get; set; }=new List<Ders>();
        public ICollection<Ogrenci> Ogrenciler { get; set; } = new List<Ogrenci>();
        public ICollection<Ogretmen> Ogretmenler { get; set; } = new List<Ogretmen>();

       

    }
}
