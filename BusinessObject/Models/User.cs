using System;
using System.Collections.Generic;

#nullable disable

namespace BusinessObject.Models
{
    public partial class User
    {
        public User()
        {
            Records = new HashSet<Record>();
        }

        public int UserId { get; set; }
        public string Fullname { get; set; }
        public string Account { get; set; }
        public string Password { get; set; }
        public bool Gender { get; set; }

        public virtual ICollection<Record> Records { get; set; }
    }
}
