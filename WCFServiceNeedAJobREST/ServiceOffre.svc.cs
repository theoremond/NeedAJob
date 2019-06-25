using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using biblio.Entities;
using Service;
using WCFServiceNeedAJobREST.Models;

namespace WCFServiceNeedAJobREST
{
    // REMARQUE : vous pouvez utiliser la commande Renommer du menu Refactoriser pour changer le nom de classe "Service1" dans le code, le fichier svc et le fichier de configuration.
    // REMARQUE : pour lancer le client test WCF afin de tester ce service, sélectionnez Service1.svc ou Service1.svc.cs dans l'Explorateur de solutions et démarrez le débogage.
    public class ServiceOffre : IServiceOffre
    {
        private IService service;
        public List<OffreDTO> GetOffre()
        {
            //service = new Service.Service();
            //List<Offre> offresBdd = service.GetAllOffre();
            //List<OffreDto> offres = new List<OffreDto>();
            //foreach(Offre offre in offresBdd)
            //{
            //    OffreDto offreDto = new OffreDto();
            //    offreDto.IdOffre = offre.IdOffre;
            //    offreDto.IdStatutOffre = offre.IdStatutOffre;
            //    offreDto.IntituleOffre = offre.IntituleOffre;
            //    offreDto.ResponsableOffre = offre.ResponsableOffre;
            //    offreDto.SalaireOffre = offre.SalaireOffre;
            //    offres.Add(offreDto);
            //}
            //return offres;
            List<OffreDTO> tests = new List<OffreDTO>();
            OffreDTO offre = new OffreDTO();
            offre.idOffre = 1;
            offre.idStatutOffre = 1;
            offre.intituleOffre = "test";
            offre.responsableOffre = "test";
            offre.salaireOffre = 1;
            tests.Add(offre);
            return tests;
        }

        // Todo : Faire le post : 
        public string PostPostulation(PostulationDTO postulation)
        {
            Offre offre = new Offre();
            offre.IntituleOffre = "test";
            return offre.IntituleOffre;
        }

        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }
    }
}
