using System;
using System.Collections.Generic;
using DB.Models;

#nullable disable

namespace DB.Models
{
    public partial class Company
    {
        public Company()
        {
            Departments = new HashSet<Department>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Department> Departments { get; set; }
    }
}
