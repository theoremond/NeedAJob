using biblio.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public interface IService
    {
        /**
         * Employe 
         */
        void AddEmploye(Employe employe);
        void DeleteEmploye(Employe employe);
        void UpdateEmploye(Employe employe);
        List<Employe> GetAllEmploye();
        Employe GetEmploye(Employe employe);
        List<Employe> GetPostulationEmployeesByOffre(Offre offre);
        /**
         * Experience 
         */
        void AddExperience(Experience experience);
        void DeleteExperience(Experience experience);
        void UpdateExperience(Experience experience);
        List<Experience> GetAllExperience();

        /**
         * Formation 
         */
        void AddFormation(Formation formation);
        void DeleteFormation(Formation formation);
        void UpdateFormation(Formation formation);
        List<Formation> GetAllFormation();

        /**
         * Offre 
         */
        void AddOffre(Offre offre);
        void DeleteOffre(Offre offre);
        void UpdateOffre(Offre offre);
        List<Offre> GetAllOffre();

        /**
         * Postulation 
         */
        void AddPostulation(Postulation postulation);
        void DeletePostulation(Postulation postulation);
        void UpdatePostulation(Postulation postulation);
        List<Postulation> GetAllPostulation();
        
        /**
         * Statut 
         */
        void AddStatut(Statut statut);
        void DeleteStatut(Statut statut);
        void UpdateStatut(Statut statut);
        List<Statut> GetAllStatut();
    }
}
