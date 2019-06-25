using biblio.Entities;
using Service;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using wpfNeadAJob.ViewModels.Common;

namespace wpfNeadAJob.ViewModels
{
    public class ListOffreViewModel : BaseViewModel
    {
        #region Variables
        private ObservableCollection<DetailOffreViewModel> _offres = null;
        private DetailOffreViewModel _selectedOffre;
        private string filter;
        IService service;
        #endregion

        #region Constructeurs

        /// <summary>
        /// Constructeur par défaut
        /// </summary>
        public ListOffreViewModel()
        {
            service = new Service.Service();
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
        public String Filter
        {
            get { return this.filter; }
            set
            {
                this.filter = value;
                //if (this.filter.Length > 3)
                //{
                    this.FilterOffre(this.filter);
                OnPropertyChanged("Filter");
            }
        }
        #endregion

        #region Recherche methode
        private void FilterOffre(string filter)
        {
            List<DetailOffreViewModel> filteredOffre = this._offres.Where(offre => offre.IntituleOffre.Contains(filter)).ToList();
            if(filteredOffre.Count > 0 && filter != "")
            {
               this.Offres = new ObservableCollection<DetailOffreViewModel>(filteredOffre);
            } else
            {
                filteredOffre.Clear();
                foreach (Offre o in service.GetAllOffre())
                {
                    filteredOffre.Add(new DetailOffreViewModel(o));
                }
                this.Offres = new ObservableCollection<DetailOffreViewModel>(filteredOffre);
            }
        }
        #endregion
    }
}
