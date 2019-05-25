using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace biblio.Entities
{
    public class Formation
    {
        private int idFormation;
        private int idEmployeFormation;
        private string intituleFormation;
        private DateTime dateFormation;

        public int IdFormation { get => idFormation; set => idFormation = value; }
        public int IdEmployeFormation { get => idEmployeFormation; set => idEmployeFormation = value; }
        public string IntituleFormation { get => intituleFormation; set => intituleFormation = value; }
        public DateTime DateFormation { get => dateFormation; set => dateFormation = value; }
    }
}
