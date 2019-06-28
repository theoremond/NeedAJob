using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace ASPNETNeedAJob.Models
{
    public class OffreViewModel
    {
        [Display(Name = "idOffre")]
        public int idOffre { get; set; }
        [Display(Name = "intituleOffre")]
        public string intituleOffre { get; set; }
        [Display(Name = "dateOffre")]
        public DateTime dateOffre { get; set; }
        [Display(Name = "salaireOffre")]
        public float salaireOffre { get; set; }
        [Display(Name = "descriptionOffre")]
        public string descriptionOffre { get; set; }
        [Display(Name = "idStatutOffre")]
        public int idStatutOffre { get; set; }
        [Display(Name = "responsableOffre")]
        public string responsableOffre { get; set; }
    }
}