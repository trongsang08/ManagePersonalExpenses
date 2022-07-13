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
        public IEnumerable<SubCategory> GetAll()
        => ManagePersonalExpensesContext.Instance.SubCategories.ToList();
        
        public IEnumerable<SubCategory> GetAllByCategoryId(int id) => ManagePersonalExpensesContext.Instance.SubCategories.Where(x => x.CategoryId == id);

        public SubCategory FindById(int id)
         => ManagePersonalExpensesContext.Instance.SubCategories.SingleOrDefault(x => x.SubCategoryId == id);
    }
}
