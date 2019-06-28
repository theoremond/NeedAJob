using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ASPNETNeedAJob.Models
{
    public class PostulationViewModel
    {
        [Display(Name = "idOffrePostulation")]
        public int idOffrePostulation { get; set; }
        [Display(Name = "idEmployePostulation")]
        public int idEmployePostulation { get; set; }
        [Display(Name = "datePostulation")]
        public DateTime datePostulation { get; set; }
        [Display(Name = "statutPostulation")]
        public string statutPostulation { get; set; }
    }
}