using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TechAtHome.Data.Models
{
    public class CategoryModel
    {
        public int ID { set; get; }
        public string CategoryName { get; set; }
        public string Specification { get; set; }
        public List<GoodModel> CategoryModel_List { get; set; }        
    }
}
