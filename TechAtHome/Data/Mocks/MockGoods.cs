using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TechAtHome.Data.Interfaces;
using TechAtHome.Data.Models;

namespace TechAtHome.Data.Mocks
{
    public class MockGoods : IGoods
    {
        private readonly ICategory _Category = new MockCategory();
        public IEnumerable<Good> Goods
        {
            get
            {
                return new List<Good>
                {
                    new Good 
                    {
                        Name = "DEXP",
                        ShortSpec = "",
                        LongSpec = "",
                        Img = "",
                        Price = 30000,
                        IsFavour = true,
                        Available = true,
                        Category = _Category.AllCategories.ElementAt(0)
                    },
                    new Good
                    {
                        Name = "Acer AspireC20",
                        ShortSpec = "",
                        LongSpec = "",
                        Img = "",
                        Price = 25000,
                        IsFavour = true,
                        Available = true,
                        Category = _Category.AllCategories.ElementAt(1)
                    },
                    new Good
                    {
                        Name = "Samsung s10",
                        ShortSpec = "",
                        LongSpec = "",
                        Img = "",
                        Price = 70000,
                        IsFavour = false,
                        Available = true,
                        Category = _Category.AllCategories.ElementAt(2)
                    },
                    new Good
                    {
                        Name = "Samsung Galaxy Tab A10",
                        ShortSpec = "",
                        LongSpec = "",
                        Img = "",
                        Price = 20000,
                        IsFavour = true,
                        Available = true,
                        Category = _Category.AllCategories.ElementAt(3)
                    }
                };
            }
        }
        public IEnumerable<Good> GetFavPCs { get; set; }

        public Good GetObjectPC(int PC_ID)
        {
            throw new NotImplementedException();
        }
    }
}
