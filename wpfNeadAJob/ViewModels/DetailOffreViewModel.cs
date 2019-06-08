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
        private RelayCommand _addOperation;
        #endregion

        #region Constructeurs
        public DetailOffreViewModel (Offre offre)
        {
            this.intituleOffre = offre.IntituleOffre;
            this.salaireOffre = offre.SalaireOffre;
            this.descriptionOffre = offre.DescriptionOffre;
            this.responsableOffre = offre.ResponsableOffre;

        }
        #endregion

        #region Data Bindings

        public string IntituleOffre
        {
            get { return intituleOffre; }
            set { intituleOffre = value; }
        }

        public float SalaireOffre
        {
            get { return salaireOffre; }
            set { salaireOffre = value; }
        }

        public string DescriptionOffre
        {
            get { return descriptionOffre; }
            set { descriptionOffre = value; }
        }

        public string ResponsableOffre
        {
            get { return responsableOffre; }
            set { responsableOffre = value; }
        }
        #endregion

        #region Commandes

        /// <summary>
        /// Commande pour ouvrir la fenêtre pour ajouter une opération
        /// </summary>
        public ICommand AddOperation
        {
            get
            {
                if (_addOperation == null)
                    _addOperation = new RelayCommand(() => this.ShowWindowOperation());
                return _addOperation;
            }
        }

        /// <summary>
        /// Permet l'ouverture de la fenêtre
        /// </summary>
        private void ShowWindowOperation()
        {
            Views.Operation operationWindow = new Views.Operation();
            operationWindow.DataContext = this;
            operationWindow.ShowDialog();
        }

        #endregion
    }
}
