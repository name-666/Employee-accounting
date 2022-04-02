using DB.Models;
using System;
using System.Collections.Generic;

#nullable disable

namespace DB.Models
{
    public partial class Department
    {
        public Department()
        {
            Users = new HashSet<User>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int CompanyId { get; set; }

        public virtual Company Company { get; set; }
        public virtual ICollection<User> Users { get; set; }
    }
}
