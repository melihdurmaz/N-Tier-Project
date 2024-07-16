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
    public class BolumManager:BaseManager<Bolum>,IBolumManager
    {
        IBolumRepository _bolumRep;

        public BolumManager(IBolumRepository bolumRep) : base(bolumRep)
        {
            _bolumRep = bolumRep;
        }
    }
}
