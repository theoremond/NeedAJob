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
        private Employe employe;
        #endregion

        #region Constructeurs
        public ListEmployeeViewModel(Offre offre)
        {
            IService service = new Service.Service();
            // on appelle le mock pour initialiser une liste de produits
           
        }

        public ListEmployeeViewModel(Employe employe)
        {
            this.employe = employe;
        }
        #endregion

        #region  Data Bindings
        //public int IdEmploye
        //{
        //    get { return this.employe.IdEmploye; }
        //    set { this.employe.IdEmploye = value; }
        //}
        //public String NomEmploye
        //{
        //    get { return this.nomEmploye; }
        //    set { this.employe.NomEmploye = value; }
        //}
        //public String PrenomEmploye
        //{
        //    get { return this.employe.PrenomEmploye; }
        //    set { this.employe.PrenomEmploye = value; }
        //}
        //public DateTime DateDeNaissanceEmploye
        //{
        //    get { return this.employe.DateDeNaissanceEmploye; }
        //    set { this.employe.DateDeNaissanceEmploye = value; }
        //}
        //public int AncienneteEmploye
        //{
        //    get { return this.employe.AncienneteEmploye; }
        //    set { this.employe.AncienneteEmploye = value; }
        //}
        //public String BiographieEmploye
        //{
        //    get { return this.employe.BiographieEmploye; }
        //    set { this.employe.BiographieEmploye = value; }
        //}

        //public ObservableCollection<ListEmployeeViewModel> Employees
        //{
        //    get { return this._employees; }
        //    set
        //    {
        //        _employees = value;
        //        OnPropertyChanged("Employees");
        //    }
        //}
        #endregion
    }
}
