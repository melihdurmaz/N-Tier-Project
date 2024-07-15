using BLL.ManagerServices.Abstracts;
using DAL.Repositories.Abstracts;
using ENTITIES.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.ManagerServices.Concretes
{
    public class OgretmenManager : BaseManager<Ogretmen>, IOgretmenManager
    {
        IOgretmenRepository _iOgretmenRep;
        public OgretmenManager(IOgretmenRepository iOgretmenRep) : base(iOgretmenRep)
        {
            _iOgretmenRep = iOgretmenRep;
        }
    }
}
