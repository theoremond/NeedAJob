using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Dto.Models
{
    [DataContract]
    public class PostulationDto
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
