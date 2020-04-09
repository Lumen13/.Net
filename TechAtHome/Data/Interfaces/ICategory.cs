using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TechAtHome.Data.Models;

namespace TechAtHome.Data.Interfaces
{
    public interface ICategory
    {
        IEnumerable<CategoryModel> AllCategoriesInterface { get; }
    }
}
