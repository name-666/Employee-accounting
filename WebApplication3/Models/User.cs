using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication3.Models
{
    public partial class User
    {
        public int Id { get; set; }
        public string Position { get; set; }
        public string WorkingMode { get; set; }
        public string Surname { get; set; }
        public string Name { get; set; }
        public string Patronymic { get; set; }
        public int DepartmentId { get; set; }

        public virtual Department Department { get; set; }
    }
}
