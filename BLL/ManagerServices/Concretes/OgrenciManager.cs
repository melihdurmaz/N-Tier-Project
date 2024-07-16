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
        IOgrenciRepository _OgrRep;
        public OgrenciManager(IOgrenciRepository OgrRep) : base(OgrRep)
        {
            _OgrRep = OgrRep;
        }

        public Task<bool> CreatUserAsync(Ogrenci item)
        {
            throw new NotImplementedException();
        }
    }
}
