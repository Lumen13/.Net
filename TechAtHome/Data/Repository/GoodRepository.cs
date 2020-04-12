using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TechAtHome.Data.Interfaces;
using TechAtHome.Data.Models;

namespace TechAtHome.Data.Repository
{
    public class GoodRepository : IGoods
    {
        private readonly AppDBContent appDBContentVariable;
        public GoodRepository(AppDBContent appDBContentField)
        {
            appDBContentVariable = appDBContentField;
        }
        public IEnumerable<GoodModel> GoodsInterface => appDBContentVariable.Db_Good.Include(c => c.GoodModel_List);

        public IEnumerable<GoodModel> GetFavPCsInterface => appDBContentVariable.Db_Good.Where(p => p.IsFavour).Include(c => c.GoodModel_List);

        public GoodModel GetObjectPC(int Good_ID) => appDBContentVariable.Db_Good.FirstOrDefault(p => p.ID == Good_ID); 
    }
}
