using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace WCFServiceNeedAJobREST.Models
{
    public class OffreDTO
    {
        public int idOffre { get; set; }
        public string intituleOffre { get; set; }
        public DateTime dateOffre { get; set; }
        public float salaireOffre { get; set; }
        public string descriptionOffre { get; set; }
        public int idStatutOffre { get; set; }
        public string responsableOffre { get; set; }
    }
}