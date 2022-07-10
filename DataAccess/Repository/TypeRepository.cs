using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObject.Models;

namespace DataAccess.Repository
{
    public class TypeRepository : ITypeRepository
    {
        public IEnumerable<BusinessObject.Models.Type> GetAll()
        => ManagePersonalExpensesContext.Instance.Types.ToList();
    }
}
