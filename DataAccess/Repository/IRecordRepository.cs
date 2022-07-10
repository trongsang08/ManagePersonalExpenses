using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObject.Models;

namespace DataAccess.Repository
{
    public interface IRecordRepository
    {
        IEnumerable<Record> GetAll();

        void Insert(Record record);
        void Delete(Record record);

        Record GetRecordById(int id);

        void Update(Record record);
    }
}
