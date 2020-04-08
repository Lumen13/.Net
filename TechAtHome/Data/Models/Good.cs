using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TechAtHome.Data.Models
{
    public class Good
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string ShortSpec { get; set; }
        public string LongSpec { get; set; }
        public string Img { get; set; }
        public decimal Price { get; set; }
        public bool IsFavour { get; set; }
        public bool Available { get; set; }
        public int CategoryID { get; set; }             // 1 or 2 (ElectroCar or PatrolCar)
        public Category Category { get; set; }
    }
}
