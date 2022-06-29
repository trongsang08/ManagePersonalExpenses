using System;
using System.Collections.Generic;

#nullable disable

namespace BusinessObject.Models
{
    public partial class Record
    {
        public int RecordId { get; set; }
        public decimal Money { get; set; }
        public DateTime Date { get; set; }
        public string Description { get; set; }
        public int UserId { get; set; }
        public int TypeId { get; set; }
        public int SubCategoryId { get; set; }

        public virtual SubCategory SubCategory { get; set; }
        public virtual Type Type { get; set; }
        public virtual User User { get; set; }
    }
}
