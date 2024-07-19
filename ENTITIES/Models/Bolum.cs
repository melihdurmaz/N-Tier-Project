using ENTITIES.Interfaces;
using ENTITIES.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITIES.Models
{
    public class Bolum :IEntity
    {

        public int Id { get; set; }
        public string bolum_Adi { get; set; }
        public ICollection<Ders> Dersler { get; set; }
        public ICollection<Ogrenci> Ogrenciler { get; set; } 
        public ICollection<Ogretmen> Ogretmenler { get; set; }

       

    }
}
