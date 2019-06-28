using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace WCFServiceNeedAJobREST.Models
{
    [DataContract]
    public class OffreDTO
    {
        [DataMember]
        public int IdOffre { get; set; }
        [DataMember]
        public string IntituleOffre { get; set; }
        [DataMember]
        public DateTime DateOffre { get; set; }
        [DataMember]
        public float SalaireOffre { get; set; }
        [DataMember]
        public string DescriptionOffre { get; set; }
        [DataMember]
        public int IdStatutOffre { get; set; }
        [DataMember]
        public string ResponsableOffre { get; set; }
    }
}