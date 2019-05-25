using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace biblio.Entities
{
    public class Statut
    {
        private int idStatut;
        private string libelle;

        public int IdStatut { get => idStatut; set => idStatut = value; }
        public string Libelle { get => libelle; set => libelle = value; }
    }
}
