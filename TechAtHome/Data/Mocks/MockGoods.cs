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
        public IEnumerable<GoodModel> GoodsInterface
        {
            get
            {
                return new List<GoodModel>
                {
                    new GoodModel 
                    {
                        Name = "DEXP",
                        ShortSpec = "",
                        LongSpec = "",
                        Img = "/img/0_0.jpg",
                        Price = 30000,
                        IsFavour = true,
                        Available = true,
                        GoodCategory = _Category.AllCategoriesInterface.ElementAt(0)
                    },
                    new GoodModel
                    {
                        Name = "Acer AspireC20",
                        ShortSpec = "",
                        LongSpec = "",
                        Img = "/img/1_0.jpg",
                        Price = 25000,
                        IsFavour = true,
                        Available = true,
                        GoodCategory = _Category.AllCategoriesInterface.ElementAt(1)
                    },
                    new GoodModel
                    {
                        Name = "Samsung s10",
                        ShortSpec = "",
                        LongSpec = "",
                        Img = "/img/2_0.jpg",
                        Price = 70000,
                        IsFavour = false,
                        Available = true,
                        GoodCategory = _Category.AllCategoriesInterface.ElementAt(2)
                    },
                    new GoodModel
                    {
                        Name = "Samsung Galaxy Tab A10",
                        ShortSpec = "",
                        LongSpec = "",
                        Img = "/img/3_0.jpg",
                        Price = 20000,
                        IsFavour = true,
                        Available = true,
                        GoodCategory = _Category.AllCategoriesInterface.ElementAt(3)
                    }
                };
            }
        }
        public IEnumerable<GoodModel> GetFavPCsInterface { get; set; }

        public GoodModel GetObjectPC(int PC_ID)
        {
            throw new NotImplementedException();
        }
    }
}
