using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace biblio.Entities
{
    class Employe
    {
        private int idEmploye;
        private string nomEmploye;
        private string prenomEmploye;
        private DateTime dateDeNaissanceEmploye;
        private int ancienneteEmploye;
        private string biographieEmploye;

        public int IdEmploye { get => idEmploye; set => idEmploye = value; }
        public string NomEmploye { get => nomEmploye; set => nomEmploye = value; }
        public string PrenomEmploye { get => prenomEmploye; set => prenomEmploye = value; }
        public DateTime DateDeNaissanceEmploye { get => dateDeNaissanceEmploye; set => dateDeNaissanceEmploye = value; }
        public int AncienneteEmploye { get => ancienneteEmploye; set => ancienneteEmploye = value; }
        public string BiographieEmploye { get => biographieEmploye; set => biographieEmploye = value; }
    }
}
