using biblio.Entities;
using Service;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using wpfNeadAJob.ViewModels.Common;

namespace wpfNeadAJob.ViewModels
{
    public class ListEmployeeViewModel : BaseViewModel
    {
        #region Variables
        private int idEmploye;
        private string nomEmploye;
        private string prenomEmploye;
        private DateTime dateDeNaissanceEmploye;
        private int ancienneteEmploye;
        private string biographieEmploye;

        #endregion

        #region Constructeurs
        public ListEmployeeViewModel(Employe employe)
        {
            IService service = new Service.Service();
            idEmploye = employe.IdEmploye;
            nomEmploye = employe.NomEmploye; ;
            prenomEmploye = employe.PrenomEmploye; ;
            dateDeNaissanceEmploye = employe.DateDeNaissanceEmploye;
            ancienneteEmploye = employe.AncienneteEmploye;
            biographieEmploye = employe.BiographieEmploye;
        }   

        #endregion

        #region  Data Bindings
        public int IdEmploye
        {
            get { return this.idEmploye; }
            set
            {
                this.idEmploye = value;
                OnPropertyChanged("IdEmploye");
            }
        }
        public string NomEmploye
        {
            get { return this.nomEmploye; }
            set
            {
                this.nomEmploye = value;
                OnPropertyChanged("NomEmploye");
            }
        }
        public string PrenomEmploye
        {
            get { return this.prenomEmploye; }
            set
            {
                this.prenomEmploye = value;
                OnPropertyChanged("PrenomEmploye");
            }
        }
        public DateTime DateDeNaissanceEmploye
        {
            get { return this.dateDeNaissanceEmploye; }
            set
            {
                this.dateDeNaissanceEmploye = value;
                OnPropertyChanged("DateDeNaissanceEmploye");
            }
        }
        public int AncienneteEmploye
        {
            get { return this.ancienneteEmploye; }
            set
            {
                this.ancienneteEmploye = value;
                OnPropertyChanged("AncienneteEmploye");
            }
        }
        public string BiographieEmploye
        {
            get { return this.biographieEmploye; }
            set
            {
                this.biographieEmploye = value;
                OnPropertyChanged("BiographieEmploye");
            }
        }
        #endregion
    }
}
