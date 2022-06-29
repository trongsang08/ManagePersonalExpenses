using System;
using System.Collections.Generic;

#nullable disable

namespace BusinessObject.Models
{
    public partial class SubCategory
    {
        public SubCategory()
        {
            Records = new HashSet<Record>();
        }

        public int SubCategoryId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int CategoryId { get; set; }

        public virtual Category Category { get; set; }
        public virtual ICollection<Record> Records { get; set; }
    }
}
