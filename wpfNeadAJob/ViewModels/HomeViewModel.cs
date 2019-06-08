using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using wpfNeadAJob.ViewModels.Common;

namespace wpfNeadAJob.ViewModels
{
    public class HomeViewModel : BaseViewModel
    {
        #region Variables

        private ListOffreViewModel _listOffreViewModel = null;

        #endregion

        #region Constructeurs

        /// <summary>
        /// Constructeur par défaut
        /// </summary>
        public HomeViewModel()
        {
            _listOffreViewModel = new ListOffreViewModel();
        }

        #endregion

        #region Data Bindings

        /// <summary>
        /// Obtient ou définit le ListeProduitViewModel
        /// </summary>
        public ListOffreViewModel ListeProduitViewModel
        {
            get { return _listOffreViewModel; }
            set { _listOffreViewModel = value; }
        }

        #endregion
    }
}
