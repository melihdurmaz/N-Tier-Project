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
    public class DersManager:BaseManager<Ders>,IDersManager
    {
        IDersRepository _dersRep;

        public DersManager(IDersRepository dersRep) : base(dersRep)
        {
            _dersRep = dersRep;
        }
    }
}
