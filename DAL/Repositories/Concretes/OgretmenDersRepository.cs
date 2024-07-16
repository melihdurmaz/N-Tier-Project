using DAL.Contecxt;
using DAL.Repositories.Abstracts;
using ENTITIES.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories.Concretes
{
    public class OgretmenDersRepository : BaseRepository<OgretmenDers>,IOgretmenDersRepository
    {
        public OgretmenDersRepository(MyContext db) : base(db)
        {
        }
    }
}
