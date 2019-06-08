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

        private ObservableCollection<DetailOffreViewModel> _offre = null;
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
           this._offre = new ObservableCollection<DetailOffreViewModel>();
            foreach (Offre o in service.GetAllOffre())
            {
                _offre.Add(new DetailOffreViewModel(o));
            }

            if (_offre != null && _offre.Count > 0)
                _selectedOffre = _offre.ElementAt(0);
        }

        #endregion

        #region Data Bindings

        /// <summary>
        /// Obtient ou définit une collection de DetailProduitViewModel (Observable)
        /// </summary>
        public ObservableCollection<DetailOffreViewModel> Offre
        {
            get { return _offre; }
            set
            {
                _offre = value;
                OnPropertyChanged("Offres");
            }
        }

        /// <summary>
        /// Obtient ou défini le produit en cours de sélection dans la liste de DetailProduitViewModel
        /// </summary>
        public DetailOffreViewModel SelectedProduit
        {
            get { return _selectedOffre; }
            set
            {
                _selectedOffre = value;
                OnPropertyChanged("SelectedProduit");
            }
        }


        #endregion
    }
}
