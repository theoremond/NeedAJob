using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace biblio.Entities
{
    public class Experience
    {
        private int idExperience;
        private int idEmployeExperience;
        private string intituleExperience;
        private DateTime dateExperience;

        public int IdExperience { get => idExperience; set => idExperience = value; }
        public int IdEmployeExperience { get => idEmployeExperience; set => idEmployeExperience = value; }
        public string IntituleExperience { get => intituleExperience; set => intituleExperience = value; }
        public DateTime DateExperience { get => dateExperience; set => dateExperience = value; }
    }
}
