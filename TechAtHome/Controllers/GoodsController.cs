using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TechAtHome.Data.Interfaces;
using TechAtHome.Data.Models;
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
               
        [Route("Goods/ViewList")]
        [Route("Goods/ViewList/{PageType}")]
        public ViewResult ViewList(string PageType)
        {
            string _PageType = PageType;

            IEnumerable<GoodModel> goods = null;
            string CurrPageType = "";

            if(string.IsNullOrEmpty(PageType))
            {
                goods = _AllGoodsField.GoodsInterface.OrderBy(i => i.ID);
            }
            else
            {
                if(string.Equals("PC", PageType, StringComparison.OrdinalIgnoreCase))
                {
                    goods = _AllGoodsField.GoodsInterface.Where(i => i.CategoryNum.Equals("Стационарные ПК")).OrderBy(i => i.ID);
                    CurrPageType = "Стационарные ПК";
                }
                else if (string.Equals("Note", PageType, StringComparison.OrdinalIgnoreCase))
                {
                    goods = _AllGoodsField.GoodsInterface.Where(i => i.CategoryNum.Equals("Ноутбуки")).OrderBy(i => i.ID);
                    CurrPageType = "Ноутбуки";
                }
                else if (string.Equals("Phone", PageType, StringComparison.OrdinalIgnoreCase))
                {
                    goods = _AllGoodsField.GoodsInterface.Where(i => i.CategoryNum.Equals("Смартфоны")).OrderBy(i => i.ID);
                    CurrPageType = "Смартфоны";
                }
                else if (string.Equals("Tab", PageType, StringComparison.OrdinalIgnoreCase))
                {
                    goods = _AllGoodsField.GoodsInterface.Where(i => i.CategoryNum.Equals("Планшеты")).OrderBy(i => i.ID);
                    CurrPageType = "Планшеты";
                }
            }

            var GoodOjb = new GoodsListWorkModel
            {
                GetAllGoods = goods,
                CurrCategory = CurrPageType
            };

            ViewBag.Title = "Страница с товарами";
            
            return View(GoodOjb);
        }
    }    
}
