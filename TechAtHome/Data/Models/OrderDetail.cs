using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TechAtHome.Data.Models
{
    public class OrderDetail
    {
        [Key]
        public int Id { get; set; }

        public int OrderId { get; set; }

        [ForeignKey(nameof(OrderId))]
        public int GoodId { get; set; }
        public decimal Price { get; set; }
        public virtual GoodModel Good { get; set; }
        public virtual Order Order { get; set; }
    }
}
