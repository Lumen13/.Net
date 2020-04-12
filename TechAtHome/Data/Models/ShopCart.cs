using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TechAtHome.Data.Models
{
    public class ShopCart
    {
        private readonly AppDBContent appDBContentVariable;
        public ShopCart(AppDBContent appDBContentField)
        {
            appDBContentVariable = appDBContentField;
        }
        public string ShopCartID { get; set; }
        public List<ShopCartItem> ListShopItems { get; set; }

        public static ShopCart GetCart(IServiceProvider services)
        {
            ISession session = services.GetRequiredService<IHttpContextAccessor>()?.HttpContext.Session;
            var Context = services.GetService<AppDBContent>();
            string GetCartId = session.GetString("CartID") ?? Guid.NewGuid().ToString();

            session.SetString("CartID", GetCartId);

            return new ShopCart(Context) { ShopCartID = GetCartId };
        }

        public void AddToCart (GoodModel good)
        {
            appDBContentVariable.Db_ShopCartItem.Add(new ShopCartItem
            {
                ShopCartModelId = ShopCartID,
                GoodModelCart = good,
                PriceCart = good.Price
            });

            appDBContentVariable.SaveChanges();
        }

        public List<ShopCartItem> GetShopItems ()
        {
            return appDBContentVariable.Db_ShopCartItem.Where(c => c.ShopCartModelId == ShopCartID).Include(s => s.GoodModelCart).ToList();
        }
    }
}
