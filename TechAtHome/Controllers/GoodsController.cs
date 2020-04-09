using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TechAtHome.Data.Interfaces;
using TechAtHome.WorkModels;

namespace TechAtHome.Controllers
{
    public class GoodsController : Controller
    {
        private readonly IGoods _AllGoodsField;
        private readonly ICategory _AllCategoriesField;

        public GoodsController (IGoods AllGoodsParameter, ICategory AllCategoriesParameter)
        {
            _AllGoodsField = AllGoodsParameter;
            _AllCategoriesField = AllCategoriesParameter;
        }
               
        public ViewResult ViewList()
        {
            ViewBag.Title = "Страница с товарами";
            GoodsListWorkModel obj = new GoodsListWorkModel();
            obj.GetAllGoods = _AllGoodsField.GoodsInterface;
            obj.CurrCategory = "Товары";

            return View(obj);
        }
    }    
}
