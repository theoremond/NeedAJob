using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using biblio.Entities;
using Service;
using System.Collections.Generic;
using System.Linq;

namespace ServiceTest
{
    [TestClass]
    public class ServiceTest
    {
        Service.Service service = new Service.Service();
        Employe employe = new Employe {
            IdEmploye = 14,
            NomEmploye = "nomTest",
            PrenomEmploye = "Test",
            DateDeNaissanceEmploye = new DateTime(1998, 09, 22, 00, 00, 00),
            AncienneteEmploye = 20,
            BiographieEmploye = "Je suis un testeur"
        };

        #region Employee
        [TestMethod]
        public void TestGetEmployes()
        {
            List<Employe> lesEmployees = this.service.GetAllEmploye();
            Assert.IsNotNull(lesEmployees);
        }
        [TestMethod]
        public void TestGetEmploye()
        {
            Employe empl = this.service.GetEmploye(this.employe);
            Assert.IsNotNull(empl);
        }
     
        [TestMethod]
        public void TestAddEmploye()
        {
            Employe employe = new Employe
            {
                NomEmploye = "Parker",
            };

            List<Employe> lesEmployees = this.service.GetAllEmploye();

            int nEmployees = lesEmployees.Count;

            service.AddEmploye(employe);

            Assert.AreEqual(nEmployees, this.service.GetAllEmploye().Count - 1);
        }

        [TestMethod]
        public void TestUpdateEmploye()
        {
            // Tout d'abord on l'ajoute dans la bdd :
            Employe employe = new Employe{NomEmploye = "Parker"};
            this.service.AddEmploye(employe);

            // on va le chercher :
            String oldName = service.GetEmploye(employe).NomEmploye;

            // on le modifie :
            employe.NomEmploye = "Test";
            this.service.UpdateEmploye(employe);

            // on clean la bdd : 
            this.service.DeleteEmploye(employe);

            Assert.AreNotEqual(oldName, employe.NomEmploye);
        }

        [TestMethod]
        public void TestDeleteEmploye()
        {
            Employe employe = new Employe
            {
                NomEmploye = "Parker",
            };

            List<Employe> lesEmployees = this.service.GetAllEmploye();

            int nEmployees = lesEmployees.Count;

            this.service.DeleteEmploye(lesEmployees.Where(e => e.NomEmploye == employe.NomEmploye).First());

            int nNewEmploye = this.service.GetAllEmploye().Count;
            Assert.AreEqual(nEmployees, nNewEmploye + 1);
        }
        #endregion

        #region Offre
        [TestMethod]
        public void TestGetOffre()
        {
            Offre offre = new Offre
            {
                IdOffre = 1,
                IntituleOffre = "Whisperies",
                DateOffre = new DateTime(2018, 02, 21, 00, 00, 00),
                SalaireOffre = 3000,
                DescriptionOffre = "Une bête de poste",
                IdStatutOffre = 1,
                ResponsableOffre = "Maxime",
            };
            Offre empl = this.service.GetOffre(offre);
            Assert.IsNotNull(empl);
        }
        #endregion

    }
}
