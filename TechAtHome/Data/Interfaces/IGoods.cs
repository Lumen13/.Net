using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TechAtHome.Data.Models;

namespace TechAtHome.Data.Interfaces
{
    public interface IGoods
    {
        IEnumerable<Good> Goods { get; }
        IEnumerable<Good> GetFavPCs { get; set; }
        Good GetObjectPC(int PC_ID);
    }
}
