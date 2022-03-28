

using System.Linq;

namespace WebApplication3.Models
{
    public class ModelW
    {
        public string[] Surname { get; set; }
        public string[] Name { get; set; }
        public string[] Patronymic { get; set; }
        public string[] Position { get; set; }
        public string[] WorkingMode { get; set; }
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
