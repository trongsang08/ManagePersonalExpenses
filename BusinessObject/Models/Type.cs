using System;
using System.Collections.Generic;

#nullable disable

namespace BusinessObject.Models
{
    public partial class Type
    {
        public Type()
        {
            Records = new HashSet<Record>();
        }

        public int TypeId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public virtual ICollection<Record> Records { get; set; }
    }
}
