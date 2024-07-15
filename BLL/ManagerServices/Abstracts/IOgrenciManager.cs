using ENTITIES.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.ManagerServices.Abstracts
{
    public interface IOgrenciManager:IManager<Ogrenci>
    {
        Task<bool> CreatUser(Ogrenci item);
    }
}
