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
        private ObservableCollection<Employe> _employees;
        #endregion

        #region Constructeurs
        public ListEmployeeViewModel(Offre offre)
        {
            IService service = new Service.Service();

            this._employees = new ObservableCollection<Employe>();

            // on appelle le mock pour initialiser une liste de produits
            foreach (Employe e in service.GetPostulationEmployeesByOffre(offre))
            {
                Employees.Add(e);
            }
            OnPropertyChanged("Employees");
        }

        #endregion

        #region  Data Bindings

        public ObservableCollection<Employe> Employees
        {
            get { return _employees; }
            set
            {
                _employees = value;
                OnPropertyChanged("Employees");
            }
        }
        #endregion
    }
}
