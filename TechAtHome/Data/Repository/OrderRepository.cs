using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TechAtHome.Data.Interfaces;
using TechAtHome.Data.Models;

namespace TechAtHome.Data.Repository
{
    public class OrderRepository : IAllOrders
    {
        private readonly AppDBContent appDBContent;
        private readonly ShopCart shopCart;

        public OrderRepository(AppDBContent _appDBContent, ShopCart _shopCart)
        {
            appDBContent = _appDBContent;
            shopCart = _shopCart;
        }

        public void CreateOrder(Order Order)
        {
            Order.OrderDetails = new List<OrderDetail>();

            Order.OrderTime = DateTime.Now;

            //appDBContent.Order.Add(Order);

            var items = shopCart.ListShopItems;

            foreach (var el in items)
            {
                var orderDetail = new OrderDetail()
                {
                    GoodId = el.GoodModelCart.ID,
                    OrderId = Order.Id,                 
                    Price = el.GoodModelCart.Price
                };

                Order.OrderDetails.Add(orderDetail);

                //appDBContent.OrderDetail.Add(orderDetail);
            }

            appDBContent.Order.Add(Order);

            appDBContent.SaveChanges(); 
        }
    }
}
