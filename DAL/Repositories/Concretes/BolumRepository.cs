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
    public class BolumRepository : BaseRepository<Bolum>, IBolumRepository
    {
        public BolumRepository(MyContext db) : base(db)
        {
        }
    }
}
