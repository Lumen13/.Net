using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TechAtHome.Data.Interfaces;
using TechAtHome.Data.Models;
using TechAtHome.WorkModels;

namespace TechAtHome.Controllers
{
    public class ShopCartController : Controller
    {
        private readonly IGoods _goodRepField;
        private readonly ShopCart _shopCartField;

        public ShopCartController(IGoods goodRepositoryParam, ShopCart shopCartParam)
        {
            _goodRepField = goodRepositoryParam;
            _shopCartField = shopCartParam;
        }

        public ViewResult Index()
        {
            var items = _shopCartField.GetShopItems();
            _shopCartField.ListShopItems = items;

            var obj = new ShopCartWorkModel
            {
                ShopCart = _shopCartField
            };

            return View(obj);
        }

        public RedirectToActionResult AddToCart_ControllerFunc(int id)
        {
            var item = _goodRepField.GoodsInterface.FirstOrDefault(i => i.ID == id);
            if (item != null)
            {
                _shopCartField.AddToCart(item);
            }
            return RedirectToAction("Index");
        }
    }
}
