﻿using BLL.ManagerServices.Abstracts;
using DAL.Repositories.Abstracts;
using ENTITIES.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.ManagerServices.Concretes
{
    public class OgrenciDersManager:BaseManager<OgrenciDers>,IOgrenciDersManager
    {
        IOgrenciDersRepository _OgrDersRep;

        public OgrenciDersManager(IOgrenciDersRepository OgrDersRep) : base(OgrDersRep)
        {
            _OgrDersRep = OgrDersRep;
        }
    }
}
