using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ENTITIES.Models;
using ENTITIES.Interfaces;
using Microsoft.AspNetCore.Identity;

namespace ENTITIES.Models
{
    public class Ogrenci :IEntity //IdentityUser<int>
                           
    {

        public int Id { get; set; }
        public string Ogr_Adi { get; set; }
        public string Ogr_Soyadi { get; set; }

      
        public int BolumId { get; set; }
        public Bolum Bolum { get; set; }

        public ICollection<OgrenciDers> OgrenciDersler { get; set; }


    }
        
}