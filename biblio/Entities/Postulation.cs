using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace biblio.Entities
{
    class Postulation
    {
        private int idOffrePostulation;
        private int idEmployePostulation;
        private DateTime datePostulation;
        private string statutPostulation;

        public int IdOffrePostulation { get => idOffrePostulation; set => idOffrePostulation = value; }
        public int IdEmployePostulation { get => idEmployePostulation; set => idEmployePostulation = value; }
        public DateTime DatePostulation { get => datePostulation; set => datePostulation = value; }
        public string StatutPostulation { get => statutPostulation; set => statutPostulation = value; }
    }
}
