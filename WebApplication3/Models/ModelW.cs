

using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace WebApplication3.Models
{
    public class ModelW
    {
        [Required]
        public string[] Surname { get; set; }
        [Required]
        public string[] Name { get; set; }
        [Required]
        public string[] Patronymic { get; set; }
        [Required]
        public string[] Position { get; set; }
        [Required]
        public string[] WorkingMode { get; set; }
        [Required]
        public string DepartmentName { get; set; }


        public int Count()
        {
            int I=0;
            for (int i = 0; i < Surname.Count(); i++)
            {
                I++;
            }
            return I;
        }
    }
}
