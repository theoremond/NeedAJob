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
    public class ListOffreViewModel : BaseViewModel
    {
        #region Variables
        private ObservableCollection<DetailOffreViewModel> _offres = null;
        private DetailOffreViewModel _selectedOffre;
        #endregion

        #region Constructeurs

        /// <summary>
        /// Constructeur par défaut
        /// </summary>
        public ListOffreViewModel()
        {
            IService service = new Service.Service();
            // on appelle le mock pour initialiser une liste de produits
            this._offres = new ObservableCollection<DetailOffreViewModel>();
            foreach (Offre o in service.GetAllOffre())
            {
                _offres.Add(new DetailOffreViewModel(o));
            }
            
            if (_offres != null && _offres.Count > 0)
            {
                _selectedOffre = _offres.ElementAt(0);
                ListEmployeeViewModel listEmp = new ListEmployeeViewModel(_selectedOffre.GetOffre());
            }


        }

        #endregion

        #region Data Bindings

        /// <summary>
        /// Obtient ou définit une collection de DetailProduitViewModel (Observable)
        /// </summary>
        public ObservableCollection<DetailOffreViewModel> Offres
        {
            get { return _offres; }
            set
            {
                _offres = value;
                OnPropertyChanged("Offres");
            }
        }

        /// <summary>
        /// Obtient ou défini le produit en cours de sélection dans la liste de DetailProduitViewModel
        /// </summary>
        public DetailOffreViewModel SelectedOffre
        {
            get { return _selectedOffre; }
            set
            {
                _selectedOffre = value;
                OnPropertyChanged("SelectedOffre");
            }
        }
        #endregion
    }
}
