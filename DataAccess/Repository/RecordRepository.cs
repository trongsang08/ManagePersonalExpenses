using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObject.Models;

namespace DataAccess.Repository
{
    public class RecordRepository : IRecordRepository
    {
        public void Delete(Record record)
        {
            ManagePersonalExpensesContext.Instance.Remove(record);
            ManagePersonalExpensesContext.Instance.SaveChanges();
        }

        public IEnumerable<Record> GetAll() => ManagePersonalExpensesContext.Instance.Records.ToList();


        public Record GetRecordById(int id)
        => ManagePersonalExpensesContext.Instance.Records.SingleOrDefault(x => x.RecordId == id);

        public void Insert(Record record)
        {
            ManagePersonalExpensesContext.Instance.Records.Add(record);
            ManagePersonalExpensesContext.Instance.SaveChanges();
        }

        public void Update(Record record)
        {
            ManagePersonalExpensesContext.Instance.Records.Update(record);
            ManagePersonalExpensesContext.Instance.SaveChanges();
        }
    }
}
