using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObject.Models;

namespace DataAccess.Repository
{
    public class CategoryRepository : ICategoryRepository
    {
        public void DeleteCategory(Category category)
        {
            ManagePersonalExpensesContext.Instance.Remove(category);
            ManagePersonalExpensesContext.Instance.SaveChanges();
        }

        public IEnumerable<Category> GetAll() => ManagePersonalExpensesContext.Instance.Categories.ToList();

        public Category GetCategoryById(int id) => ManagePersonalExpensesContext.Instance.Categories.SingleOrDefault(x => x.CategoryId == id);


        public void InsertCategory(Category category)
        {
            ManagePersonalExpensesContext.Instance.Add(category);
            ManagePersonalExpensesContext.Instance.SaveChanges();
        }

        public void Update(Category category)
        {
            ManagePersonalExpensesContext.Instance.Update(category);
            ManagePersonalExpensesContext.Instance.SaveChanges();
        }
    }
}
