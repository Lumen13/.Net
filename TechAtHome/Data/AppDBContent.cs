using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TechAtHome.Data.Models;

namespace TechAtHome.Data
{
    public class AppDBContent : DbContext
    {
        public AppDBContent(DbContextOptions<AppDBContent> options) : base(options)
        {}

        public DbSet<GoodModel> Db_Good { get; set; }
        public DbSet<CategoryModel> Db_Category { get; set; }
        public DbSet<ShopCartItem> Db_ShopCartItem { get; set; }
        public DbSet<Order> Order { get; set; }
        public DbSet<OrderDetail> OrderDetail { get; set; }
    }
}
