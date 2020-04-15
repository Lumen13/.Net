using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore.Internal;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using TechAtHome.Data.Models;

namespace TechAtHome.Data
{
    public class DbObjects
    {
        public static void Initial(AppDBContent content)
        {
            if (!content.Db_Category.Any())
                content.Db_Category.AddRange(DbObj_Categories.Select(c => c.Value));
                
            if (!content.Db_Good.Any())
            {
                content.AddRange
                    (
                        new GoodModel
                        {
                            Name = "DEXP",
                            ShortSpec = "Классический ПК",
                            LongSpec = "Стационарный ПК базовой мощности за доступные средства",
                            Img = "/img/0_0.jpg",
                            Price = 30000,
                            IsFavour = true,
                            Available = true,
                            GoodCategory = DbObj_Categories["Стационарные ПК"]
                        },
                        new GoodModel
                        {
                            Name = "Acer Aspire A315",
                            ShortSpec = "Офисный ноутбук",
                            LongSpec = "Ноутбук идеально подойдет для офисных работ и работа с графикой",
                            Img = "/img/1_0.jpg",
                            Price = 21600,
                            IsFavour = true,
                            Available = true,
                            GoodCategory = DbObj_Categories["Ноутбуки"]
                        },
                        new GoodModel
                        {
                            Name = "Samsung s10",
                            ShortSpec = "Один из флагманов компании Samsung",
                            LongSpec = "Samsung s10 - новый телефон линейки S-класса с прекрасной камерой и дизайном",
                            Img = "/img/2_0.jpg",
                            Price = 70000,
                            IsFavour = false,
                            Available = true,
                            GoodCategory = DbObj_Categories["Смартфоны"]
                        },
                        new GoodModel
                        {
                            Name = "Samsung Galaxy Tab A10",
                            ShortSpec = "Прекрасный планшет компании Samsung",
                            LongSpec = "Galaxy Tab A10 - это высокопроизводительный, комфортный и стильный девайс для решения любых задач",
                            Img = "/img/3_0.jpg",
                            Price = 20000,
                            IsFavour = true,
                            Available = true,
                            GoodCategory = DbObj_Categories["Планшеты"]
                        },
                        new GoodModel
                        {
                            Name = "IPhone 11 Pro",
                            ShortSpec = "Не только лишь смартфон",
                            LongSpec = "Данный девайс - это новая веха в истории эволюции техники, если Вы сможете себе её позволить",
                            Img = "/img/4_0.jpg",
                            Price = 120000,
                            IsFavour = true,
                            Available = true,
                            GoodCategory = DbObj_Categories["Смартфоны"]
                        },
                        new GoodModel
                        {
                            Name = "IPad 11 Pro",
                            ShortSpec = "Планшет. Лучший из лучших",
                            LongSpec = "Мощность высокопроизводительного ПК в максимально стильной и удобной упаковке",
                            Img = "/img/5_0.jpg",
                            Price = 85000,
                            IsFavour = true,
                            Available = true,
                            GoodCategory = DbObj_Categories["Планшеты"]
                        }
                    );
            }
            content.SaveChanges();
        }

        private static Dictionary<string, CategoryModel> DbObj_Category;
        public static Dictionary<string, CategoryModel> DbObj_Categories
        {
            get
            {
                if (DbObj_Category == null)
                {
                    var list = new CategoryModel[]
                    {
                        new CategoryModel { CategoryName = "Стационарные ПК", Specification = "Универсальные полноценные компьютеры" },
                        new CategoryModel { CategoryName = "Ноутбуки", Specification = "Более компактные, удобные и дорогие компьютеры"},
                        new CategoryModel { CategoryName = "Смартфоны", Specification = "Многофункциональные умные телефоны"},
                        new CategoryModel { CategoryName = "Планшеты", Specification = "Сенсорный планшетный компьютер. Чуть больше смартфона"}
                    };

                    DbObj_Category = new Dictionary<string, CategoryModel>();
                    foreach (CategoryModel el in list)
                        DbObj_Category.Add(el.CategoryName, el);
                }

                return DbObj_Category;
            }
        }
    }
}
