using DAL.Contecxt;
using DAL.Repositories.Abstracts;
using ENTITIES.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories.Concretes
{
    public class OgrenciRepository : BaseRepository<Ogrenci>,IOgrenciRepository
    {
        public OgrenciRepository(MyContext db) : base(db)
        {
        }
    }
}
