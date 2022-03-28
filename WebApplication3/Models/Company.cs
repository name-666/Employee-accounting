using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication3.Models
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
