using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TechAtHome.Data.Models
{
    public class CategoryModel
    {
        [Key]
        public int ID { set; get; }

        [MaxLength(150)]
        public string CategoryName { get; set; }

        [MaxLength(100)]
        public string Specification { get; set; }

        public List<GoodModel> CategoryModel_List { get; set; }        
    }
}
