using biblio.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using wpfNeadAJob.ViewModels.Common;

namespace wpfNeadAJob.ViewModels
{
    public class DetailOffreViewModel : BaseViewModel
    {
        #region Variable
        private string intituleOffre;
        private float salaireOffre;
        private string descriptionOffre;
        private string responsableOffre;
        private Offre offre;
        private Service.IService service = new Service.Service();
        #endregion

        #region Constructeurs
        public DetailOffreViewModel (Offre offre)
        {
            this.offre = offre;
            this.intituleOffre = offre.IntituleOffre;
            this.salaireOffre = offre.SalaireOffre;
            this.descriptionOffre = offre.DescriptionOffre;
            this.responsableOffre = offre.ResponsableOffre;

        }
        #endregion
        public Offre GetOffre()
        {
            return this.offre;
        }
        #region Data Bindings

        public string IntituleOffre
        {
            get { return this.offre.IntituleOffre; }
            set {
                this.offre.IntituleOffre = value;
                this.service.UpdateOffre(this.offre);
            }
        }

        public float SalaireOffre
        {
            get { return this.offre.SalaireOffre; }
            set {
                this.offre.SalaireOffre = value;
                this.service.UpdateOffre(this.offre);
            }
        }

        public string DescriptionOffre
        {
            get { return this.offre.DescriptionOffre; }
            set {
                this.offre.DescriptionOffre = value;
                this.service.UpdateOffre(this.offre);
            }
        }

        public string ResponsableOffre
        {
            get { return this.offre.ResponsableOffre; }
            set {
                this.offre.ResponsableOffre = value;
                this.service.UpdateOffre(this.offre);
            }
        }
        #endregion
    }
}
