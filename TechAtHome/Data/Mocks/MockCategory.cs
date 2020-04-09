using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TechAtHome.Data.Interfaces;
using TechAtHome.Data.Models;

namespace TechAtHome.Data.Mocks
{
    public class MockCategory : ICategory
    {
        public IEnumerable<CategoryModel> AllCategoriesInterface
        {
            get
            {
                return new List<CategoryModel>
                {
                    new CategoryModel { CategoryName = "Стационарные ПК", Specification = "Универсальные полноценные компьютеры" },
                    new CategoryModel { CategoryName = "Ноутбуки", Specification = "Более компактные, удобные и дорогие компьютеры"},
                    new CategoryModel { CategoryName = "Смартфоны", Specification = "Многофункциональные умные телефоны"},
                    new CategoryModel { CategoryName = "Планшеты", Specification = "Сенсорный планшетный компьютер. Чуть больше смартфона"}
                };
            }
        }
    }
}
