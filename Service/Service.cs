using biblio;
using biblio.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Service
{
    /// <summary>
    /// TODO : Faire les UPDATES
    /// </summary>
    public class Service : IService
    {
        /**
         * ICI C'EST LE CRUD
         * 
         */
        private ContextFluent DbContext;
        public Service()
        {
            DbContext = new ContextFluent();
        }

        public void AddEmploye(Employe employe)
        {
            try
            {
                Employe entity = DbContext.Employes.Where(e => e.IdEmploye == employe.IdEmploye).FirstOrDefault();

                if ( entity != null)
                {
                    Console.WriteLine("Entity déja présente !");
                } else
                {
                    DbContext.Employes.Add(employe);
                    DbContext.SaveChanges();
                }
            }
            catch (Exception e )
            { 
                throw e;
            }
        }

        public void AddExperience(Experience experience)
        {
            try
            {
                Experience entity = DbContext.Experiences.Where(e => e.IdExperience == experience.IdExperience).FirstOrDefault();

                if (entity != null)
                {
                    Console.WriteLine("Entity déja présente !");
                }
                else
                {
                    DbContext.Experiences.Add(experience);
                    DbContext.SaveChanges();
                }

            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public void AddFormation(Formation formation)
        {
            try
            {
                Formation entity = DbContext.Formations.Where(e => e.IdFormation == formation.IdFormation).FirstOrDefault();

                if (entity != null)
                {
                    Console.WriteLine("Entity déja présente !");
                }
                else
                {
                    DbContext.Formations.Add(formation);
                    DbContext.SaveChanges();
                }
            }
            catch (Exception e)
            {
                throw e;
            }
        }
             
        public void AddOffre(Offre offre)
        {
            try
            {
                Offre entity = DbContext.Offres.Where(e => e.IdOffre == offre.IdOffre).FirstOrDefault();

                if (entity != null)
                {
                    Console.WriteLine("Entity déja présente !");
                }
                else
                {
                    DbContext.Offres.Add(offre);
                    DbContext.SaveChanges();
                }
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public void AddPostulation(Postulation postulation)
        {
            try
            {
                Postulation entity = DbContext.Postulations
                    .Where(postule => postule.IdEmployePostulation == postulation.IdEmployePostulation &&
                                      postule.IdOffrePostulation == postulation.IdOffrePostulation)
                    .FirstOrDefault();

                if (entity != null)
                {
                    Console.WriteLine("Entity déja présente !");
                }
                else
                {
                    DbContext.Postulations.Add(postulation);
                    DbContext.SaveChanges();
                }
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public void AddStatut(Statut statut)
        {
            try
            {
                Statut entity = DbContext.Statuts.Where(e => e.IdStatut == statut.IdStatut).FirstOrDefault();

                if (entity != null)
                {
                    Console.WriteLine("Entity déja présente !");
                }
                else
                {
                    DbContext.Statuts.Add(statut);
                    DbContext.SaveChanges();
                }
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public void DeleteEmploye(Employe employe)
        {
            try
            {
                Employe entity = DbContext.Employes.Where(e => e.IdEmploye == employe.IdEmploye).FirstOrDefault();

                if (entity == null)
                {
                    Console.WriteLine("Entity n'existe pas !");
                }
                else
                {
                    DbContext.Employes.Remove(employe);
                    DbContext.SaveChanges();
                }

            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public void DeleteExperience(Experience experience)
        {
            try
            {
                Experience entity = DbContext.Experiences.Where(e => e.IdExperience == experience.IdExperience).FirstOrDefault();

                if (entity == null)
                {
                    Console.WriteLine("Entity n'existe pas !");
                }
                else
                {
                    DbContext.Experiences.Remove(experience);
                    DbContext.SaveChanges();
                }

            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public void DeleteFormation(Formation formation)
        {
            try
            {
                Formation entity = DbContext.Formations.Where(e => e.IdFormation == formation.IdFormation).FirstOrDefault();

                if (entity == null)
                {
                    Console.WriteLine("Entity n'existe pas !");
                }
                else
                {
                    DbContext.Formations.Remove(formation);
                    DbContext.SaveChanges();
                }

            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public void DeleteOffre(Offre offre)
        {
            try
            {
                Offre entity = DbContext.Offres.Where(e => e.IdOffre == offre.IdOffre).FirstOrDefault();

                if (entity == null)
                {
                    Console.WriteLine("Entity n'existe pas !");
                }
                else
                {
                    DbContext.Offres.Remove(offre);
                    DbContext.SaveChanges();
                }

            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public void DeletePostulation(Postulation postulation)
        {
            try
            {
                Postulation entity = DbContext.Postulations
                    .Where(postule => postule.IdEmployePostulation == postulation.IdEmployePostulation &&
                                      postule.IdOffrePostulation == postulation.IdOffrePostulation)
                    .FirstOrDefault();

                if (entity == null)
                {
                    Console.WriteLine("Entity n'existe pas !");
                }
                else
                {
                    DbContext.Postulations.Remove(postulation);
                    DbContext.SaveChanges();
                }

            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public void DeleteStatut(Statut statut)
        {
            try
            {
                Statut entity = DbContext.Statuts.Where(e => e.IdStatut == statut.IdStatut).FirstOrDefault();

                if (entity == null)
                {
                    Console.WriteLine("Entity n'existe pas !");
                }
                else
                {
                    DbContext.Statuts.Remove(statut);
                    DbContext.SaveChanges();
                }

            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public List<Employe> GetAllEmploye()
        {
            try
            {
                return DbContext.Employes.ToList();
            }
            catch (Exception e)
            { 
                throw e;
            }
 
        }

        public List<Experience> GetAllExperience()
        {
            try
            {
                return DbContext.Experiences.ToList();
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public List<Formation> GetAllFormation()
        {
            try
            {
                return DbContext.Formations.ToList();
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public List<Offre> GetAllOffre()
        {
            try
            {
                return DbContext.Offres.ToList();
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public List<Postulation> GetAllPostulation()
        {
            try
            {
                return DbContext.Postulations.ToList();
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public List<Statut> GetAllStatut()
        {
            try
            {
                return DbContext.Statuts.ToList();
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public void UpdateEmploye(Employe employe)
        {
            throw new NotImplementedException();
        }

        public void UpdateExperience(Experience experience)
        {
            throw new NotImplementedException();
        }

        public void UpdateFormation(Formation formation)
        {
            throw new NotImplementedException();
        }

        public void UpdateOffre(Offre offre)
        {
            try {
                Offre oldOffre = DbContext.Offres.Where(o => o.IdOffre == offre.IdOffre).First();

                oldOffre.IntituleOffre = offre.IntituleOffre;
                oldOffre.DateOffre = offre.DateOffre;
                oldOffre.SalaireOffre = offre.SalaireOffre;
                oldOffre.DescriptionOffre = offre.DescriptionOffre;
                oldOffre.IdStatutOffre = offre.IdStatutOffre;
                oldOffre.ResponsableOffre = offre.ResponsableOffre;

                DbContext.SaveChanges();
            }
            catch(Exception e) {
                throw e;
            }
        }

        public void UpdatePostulation(Postulation postulation)
        {
            throw new NotImplementedException();
        }

        public void UpdateStatut(Statut statut)
        {
            throw new NotImplementedException();
        }

        public Employe GetEmploye(Employe employe)
        {
            try
            {
                return DbContext.Employes.Where(e => e.NomEmploye == employe.NomEmploye).First();
            }
            catch (Exception e)
            {
                throw e;
            }

        }

        public List<Employe> GetPostulationEmployeesByOffre(Offre offre)
        {
            try
            {
                List<Postulation> postulations = DbContext.Postulations.Where(p => p.IdOffrePostulation == offre.IdOffre).ToList();
                List<Employe> employeesWichPostulate = new List<Employe>();
                
                foreach(Postulation post in postulations)
                {
                    employeesWichPostulate.Add(DbContext.Employes.Where(e => e.IdEmploye == post.IdEmployePostulation).First());                    
                }

                return employeesWichPostulate;
            }
            catch (Exception e)
            {
                throw e;
            }
        }


    }
}
