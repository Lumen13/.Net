using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TechAtHome.Data.Interfaces;
using TechAtHome.WorkModels;

namespace TechAtHome.Controllers
{
    public class HomePageController : Controller
    {
        private readonly IGoods _goodRepField;

        public HomePageController(IGoods goodRepositoryParam)
        {
            _goodRepField = goodRepositoryParam;
        }

        public ViewResult Index()
        {
            var HomeGoods = new HomePageWorkModel
            {
                FavGoods = _goodRepField.GetFavPCsInterface
            };
            return View(HomeGoods);
        }
    }
}
