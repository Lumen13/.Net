using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TechAtHome.Data.Models
{
    public class Category
    {
        public int ID { set; get; }
        public string CategoryName { get; set; }
        public string Spec { get; set; }
        public List<Good> PCs { get; set; }        
    }
}
