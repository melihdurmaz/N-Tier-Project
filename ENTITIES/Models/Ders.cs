
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ENTITIES.Models;

namespace ENTITIES.Models
{
    public class Ders : BaseEntity
    {


        
        public string DersAdi { get; set; }
        public int Kredi { get; set; }
        //
        public int BolumId { get; set; }
        public Bolum Bolum { get; set; }
        //
        public ICollection<OgrenciDers> OgrenciDersler { get; set; } 
        public ICollection<OgretmenDers> OgretmenDersler { get; set; }
    }


}
