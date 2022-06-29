using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObject.Models;

namespace DataAccess.Repository
{
    public interface ICategoryRepository
    {
        IEnumerable<Category> GetAll();

        void InsertCategory(Category category);
        void DeleteCategory(Category category);

        Category GetCategoryById(int id);

        void Update(Category category);
    }
}
