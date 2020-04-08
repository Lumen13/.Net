using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TechAtHome.Data.Interfaces;

namespace TechAtHome.Controllers
{
    public class GoodsController : Controller
    {
        private readonly IGoods _AllGoods;
        private readonly ICategory _AllCategories;

        public GoodsController (IGoods iAllGoods, ICategory iAllCategories)
        {
            _AllGoods = iAllGoods;
            _AllCategories = iAllCategories;
        }
    }
}
