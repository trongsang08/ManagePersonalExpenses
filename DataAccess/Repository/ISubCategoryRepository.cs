using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObject.Models;

namespace DataAccess.Repository
{
    public interface ISubCategoryRepository
    {
        IEnumerable<SubCategory> GetAllByCategoryId(int id);
        IEnumerable<SubCategory> GetAll();

        void InsertSubCategory(SubCategory subcategory);
        SubCategory GetSubCategoryById(int id);
        void Update(SubCategory subcategory);


        public SubCategory FindById(int id);
    }
}
