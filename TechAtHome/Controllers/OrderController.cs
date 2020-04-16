using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TechAtHome.Data.Interfaces;
using TechAtHome.Data.Models;

namespace TechAtHome.Controllers
{
    public class OrderController : Controller
    {
        private readonly IAllOrders allOrders;
        private readonly ShopCart shopCart;

        public OrderController(IAllOrders _IAllOrders, ShopCart _shopCart)
        {
            allOrders = _IAllOrders;
            shopCart = _shopCart;
        }

        public IActionResult CheckOut ()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CheckOut(Order order)
        {
            shopCart.ListShopItems = shopCart.GetShopItems();

            if(shopCart.ListShopItems.Count == 0)
            {
                ModelState.AddModelError("", "У Вас должны быть товары");
            }

            if(ModelState.IsValid)
            {
                allOrders.CreateOrder(order);
                return RedirectToAction(nameof(Complete));
            }

            return View();
        }

        public IActionResult Complete()
        {
            ViewBag.Message = "Заказ успешно обработан";
            return View();
        }
    }
}
