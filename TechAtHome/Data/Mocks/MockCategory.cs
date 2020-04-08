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
        public IEnumerable<Category> AllCategories
        {
            get
            {
                return new List<Category>
                {
                    new Category { CategoryName = "Стационарные ПК", Spec = "Универсальные полноценные компьютеры" },
                    new Category { CategoryName = "Ноутбуки", Spec = "Более компактные, удобные и дорогие компьютеры"},
                    new Category { CategoryName = "Смартфоны", Spec = "Многофункциональные умные телефоны"},
                    new Category { CategoryName = "Планшеты", Spec = "Сенсорный планшетный компьютер. Чуть больше смартфона"}
                };
            }
        }
    }
}
