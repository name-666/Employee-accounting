using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;


#nullable disable

namespace DB.Models
{
    public partial class Company
    {
        public Company()
        {
            Departments = new HashSet<Department>();
        }
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Department> Departments { get; set; }
    }
}
