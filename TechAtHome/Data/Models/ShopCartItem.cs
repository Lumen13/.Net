using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TechAtHome.Data.Models
{
    public class ShopCartItem
    {
        [Key]
        public int Id { get; set; }
        public GoodModel GoodModelCart { get; set; }
        public decimal PriceCart { get; set; }
        public string ShopCartModelId { get; set; }
    }
}
