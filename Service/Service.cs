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

        #region Employe
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

        public Employe GetEmploye(Employe employe)
        {
            try
            {
                return DbContext.Employes.Where(emp => emp.IdEmploye == employe.IdEmploye).Single();
            }
            catch (Exception e)
            {
                throw e;
            }

        }

        public void UpdateEmploye(Employe employe)
        {
            try
            {
                Employe oldEmploye = DbContext.Employes.Where(empl => empl.IdEmploye == employe.IdEmploye).First();

                oldEmploye.NomEmploye = employe.NomEmploye;
                oldEmploye.PrenomEmploye = employe.PrenomEmploye;
                oldEmploye.DateDeNaissanceEmploye = employe.DateDeNaissanceEmploye;
                oldEmploye.AncienneteEmploye = employe.AncienneteEmploye;
                oldEmploye.BiographieEmploye = employe.BiographieEmploye;

                DbContext.SaveChanges();
            }
            catch (Exception e)
            {

                throw e;
            }
        }

        #endregion

        #region Experience
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

        public void UpdateExperience(Experience experience)
        {
            try
            {
                Experience oldExperience = DbContext.Experiences.Where(exp => exp.IdExperience == experience.IdExperience).First();

                oldExperience.IdExperience = experience.IdExperience;
                oldExperience.IdEmployeExperience = experience.IdEmployeExperience;
                oldExperience.IntituleExperience = experience.IntituleExperience;
                oldExperience.DateExperience = experience.DateExperience;

                DbContext.SaveChanges();
            }
            catch (Exception e)
            {

                throw e;
            }
        }
        
        #endregion

        #region Formation
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

        public void UpdateFormation(Formation formation)
        {
            try
            {
                Formation oldFormation = DbContext.Formations.Where(form => form.IdFormation == formation.IdFormation).First();

                oldFormation.IdFormation = formation.IdFormation;
                oldFormation.IdEmployeFormation = formation.IdEmployeFormation;
                oldFormation.IntituleFormation = formation.IntituleFormation;
                oldFormation.DateFormation = formation.DateFormation;

                DbContext.SaveChanges();
            }
            catch (Exception e)
            {

                throw e;
            }
        }
    

        #endregion

        #region Offre
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

        public void UpdateOffre(Offre offre)
        {
            try
            {
                Offre oldOffre = DbContext.Offres.Where(o => o.IdOffre == offre.IdOffre).First();

                oldOffre.IntituleOffre = offre.IntituleOffre;
                oldOffre.DateOffre = offre.DateOffre;
                oldOffre.SalaireOffre = offre.SalaireOffre;
                oldOffre.DescriptionOffre = offre.DescriptionOffre;
                oldOffre.IdStatutOffre = offre.IdStatutOffre;
                oldOffre.ResponsableOffre = offre.ResponsableOffre;

                DbContext.SaveChanges();
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public Offre GetOffre(Offre offre)
        {
            try
            {
                return DbContext.Offres.Where(emp => emp.IdOffre == offre.IdOffre).First();
            }
            catch (Exception e)
            {
                throw e;
            }

        }

        #endregion

        #region Postulation
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

        public void UpdatePostulation(Postulation postulation)
        {
            try
            {
                Postulation oldPostulation = DbContext.Postulations.Where(postu => postu.IdOffrePostulation == postulation.IdOffrePostulation).First();

                oldPostulation.IdOffrePostulation = postulation.IdOffrePostulation;
                oldPostulation.IdEmployePostulation = postulation.IdEmployePostulation;
                oldPostulation.DatePostulation = postulation.DatePostulation;
                oldPostulation.StatutPostulation = postulation.StatutPostulation;

                DbContext.SaveChanges();
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

                foreach (Postulation post in postulations)
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
    
        #endregion

<<<<<<< jalon3
        #region Statut
        public void AddStatut(Statut statut)
=======
        public Employe GetEmploye(Employe employe)
>>>>>>> fix
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

<<<<<<< jalon3
        public List<Statut> GetAllStatut()
=======


        public Offre GetOffreById(int idOffre)
>>>>>>> fix
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

        public List<Offre> GetOffresRecherche(string recherche)
        {
            try
            {
                return DbContext.Offres.Where(o =>
                    o.IntituleOffre.Contains(recherche) ||
                    o.ResponsableOffre.Contains(recherche)
                ).ToList();
            } catch (Exception e)
            {
                throw e;
            }
        }
<<<<<<< jalon3

        public void UpdateStatut(Statut statut)
        {
            try
            {
                Statut oldStatut = DbContext.Statuts.Where(stat => stat.IdStatut == statut.IdStatut).First();

                oldStatut.IdStatut = statut.IdStatut;
                oldStatut.Libelle = statut.Libelle;

                DbContext.SaveChanges();
            }
            catch (Exception e)
            {

                throw e;
            }
        }

        #endregion
=======
>>>>>>> fix
    }
}
