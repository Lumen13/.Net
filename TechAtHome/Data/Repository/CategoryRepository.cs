using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TechAtHome.Data.Interfaces;
using TechAtHome.Data.Models;

namespace TechAtHome.Data.Repository
{
    public class CategoryRepository : ICategory
    {
        private readonly AppDBContent appDBContentVariable;
        public CategoryRepository(AppDBContent appDBContentField)
        {
            appDBContentVariable = appDBContentField;
        }
        public IEnumerable<CategoryModel> AllCategoriesInterface => appDBContentVariable.Db_Category;
    }
}
