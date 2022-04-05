using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace DB.Models
{
    public partial class User
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Position { get; set; }
        [Required]
        public string WorkingMode { get; set; }
        [Required]
        public string Surname { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Patronymic { get; set; }
        [Required]
        public int DepartmentId { get; set; }

        public virtual Department Department { get; set; }
    }
}
