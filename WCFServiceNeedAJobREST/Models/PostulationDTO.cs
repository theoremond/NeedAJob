using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace WCFServiceNeedAJobREST.Models
{
    public class PostulationDTO
    {
        private int idOffrePostulation;
        private int idEmployePostulation;
        private DateTime datePostulation;
        private string statutPostulation;

        [DataMember]
        public int IdOffrePostulation { get => idOffrePostulation; set => idOffrePostulation = value; }
        [DataMember]
        public int IdEmployePostulation { get => idEmployePostulation; set => idEmployePostulation = value; }
        [DataMember]
        public DateTime DatePostulation { get => datePostulation; set => datePostulation = value; }
        [DataMember]
        public string StatutPostulation { get => statutPostulation; set => statutPostulation = value; }
    }
}