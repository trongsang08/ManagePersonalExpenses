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

        public void InsertSubCategory(SubCategory subcategory)
        {
            ManagePersonalExpensesContext.Instance.Add(subcategory);
            ManagePersonalExpensesContext.Instance.SaveChanges();
        }

        public void Update(SubCategory subcategory)
        {
            ManagePersonalExpensesContext.Instance.Update(subcategory);
            ManagePersonalExpensesContext.Instance.SaveChanges();
        }
        public SubCategory GetSubCategoryById(int id) => ManagePersonalExpensesContext.Instance.SubCategories.SingleOrDefault(x => x.SubCategoryId == id);

        
    }
}
