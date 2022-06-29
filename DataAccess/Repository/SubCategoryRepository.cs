using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObject.Models;

namespace DataAccess.Repository
{
    public class SubCategoryRepository : ISubCategoryRepository
    {
        public IEnumerable<SubCategory> GetAllByCategoryId(int id) => ManagePersonalExpensesContext.Instance.SubCategories.Where(x => x.CategoryId == id);
       
    }
}
