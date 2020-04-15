using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TechAtHome.Data.Models
{
    public class GoodModel
    {
        [Key]
        public int ID { get; set; }

        [MaxLength(50)]
        public string Name { get; set; }

        [MaxLength(150)]
        public string ShortSpec { get; set; }

        [MaxLength(500)]
        public string LongSpec { get; set; }

        [MaxLength(50)]
        public string Img { get; set; }
        public decimal Price { get; set; }
        public bool IsFavour { get; set; }
        public bool Available { get; set; }
        public int ForeignKeyCategory { get; set; }             // 1 - 4

        [ForeignKey(nameof(ForeignKeyCategory))]
        public CategoryModel GoodCategory { get; set; }
    }
}
