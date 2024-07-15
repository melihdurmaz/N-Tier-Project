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
    public class OgrenciManager : BaseManager<Ogrenci>, IOgrenciManager
    {
        IOgrenciRepository _iOgrRep;
        public OgrenciManager(IOgrenciRepository iOgrRep) : base(iOgrRep)
        {
            _iOgrRep = iOgrRep;
        }

        public async Task<bool> CreatUser(Ogrenci item)
        {
            return await _iOgrRep.AddUser(item);
        }
    }
}
