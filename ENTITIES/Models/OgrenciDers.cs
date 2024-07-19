using ENTITIES.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITIES.Models
{
    public class OgrenciDers : IEntity
    {


        public int Id { get; set; }
        
        public int OgrenciDersId { get; set; }
        
        public int OgrenciId { get; set; }
        
        

        public Ogrenci Ogrenci { get; set; }
        public Ders Ders { get; set; }
    }
}
