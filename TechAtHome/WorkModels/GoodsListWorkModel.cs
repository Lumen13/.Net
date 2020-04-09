using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TechAtHome.Data.Models;

namespace TechAtHome.WorkModels
{
    public class GoodsListWorkModel
    {
        public IEnumerable<GoodModel> GetAllGoods { get; set; }
        public string CurrCategory { get; set; }
    }
}
