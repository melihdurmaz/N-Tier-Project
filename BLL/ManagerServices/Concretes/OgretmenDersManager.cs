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
    public class OgretmenDersManager:BaseManager<OgretmenDers>,IOgretmenDersManager
    {
        IOgretmenDersRepository _iOgrDersRep;

        public OgretmenDersManager (IOgretmenDersRepository iOgrDersRep) : base(iOgrDersRep)
        {
            _iOgrDersRep = iOgrDersRep;
        }
    }
}
