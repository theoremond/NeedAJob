using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace biblio.Entities
{
    public class Offre
    {
        private int idOffre;
        private string intituleOffre;
        private DateTime dateOffre;
        private float salaireOffre;
        private string descriptionOffre;
        private int idStatutOffre;
        private string responsableOffre;

        public int IdOffre { get => idOffre; set => idOffre = value; }
        public string IntituleOffre { get => intituleOffre; set => intituleOffre = value; }
        public DateTime DateOffre { get => dateOffre; set => dateOffre = value; }
        public float SalaireOffre { get => salaireOffre; set => salaireOffre = value; }
        public string DescriptionOffre { get => descriptionOffre; set => descriptionOffre = value; }
        public int IdStatutOffre { get => idStatutOffre; set => idStatutOffre = value; }
        public string ResponsableOffre { get => responsableOffre; set => responsableOffre = value; }
    }
}
