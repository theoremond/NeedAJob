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
        private IService service = new Service.Service();
        public List<OffreDTO> GetOffre()
        {
            try
            {
                List<Offre> offresBdd = service.GetAllOffre();
                List<OffreDTO> offres = new List<OffreDTO>();
                foreach (Offre offre in offresBdd)
                {
                    OffreDTO offreDto = new OffreDTO
                    {
                        IdOffre = offre.IdOffre,
                        IdStatutOffre = offre.IdStatutOffre,
                        IntituleOffre = offre.IntituleOffre,
                        ResponsableOffre = offre.ResponsableOffre,
                        SalaireOffre = offre.SalaireOffre,
                        DateOffre = offre.DateOffre,
                        DescriptionOffre = offre.DescriptionOffre
                    };
                    offres.Add(offreDto);
                }

                return offres;
            }
            catch (Exception e)
            {

                throw e;
            }
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
