﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TechAtHome.Data.Models;

namespace TechAtHome.Data.Interfaces
{
    public interface IGoods
    {
        IEnumerable<GoodModel> GoodsInterface { get; }
        IEnumerable<GoodModel> GetFavPCsInterface { get;}
        GoodModel GetObjectPC(int Good_ID);
    }
}
