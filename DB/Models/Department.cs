
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace DB.Models
{
    public partial class Department
    {
        public Department()
        {
            Users = new HashSet<User>();
        }
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public int CompanyId { get; set; }
        public virtual Company Company { get; set; }
        public virtual ICollection<User> Users { get; set; }
    }
}
