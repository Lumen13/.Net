﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TechAtHome.Data.Models;

namespace TechAtHome.WorkModels
{
    public class HomePageWorkModel
    {
        public IEnumerable<GoodModel> FavGoods { get; set; }

    }
}
