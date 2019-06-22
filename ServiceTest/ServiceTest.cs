using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using biblio.Entities;
using Service;
using System.Collections.Generic;
using System.Linq;

namespace ServiceTest
{
    /// <summary>
    /// Des test !!!
    /// TODO : Faire des test au minimum sur une entity sinon sur tout si le time !!!
    /// </summary>
    [TestClass]
    public class ServiceTest
    {
        Service.Service service = new Service.Service();
        Employe employe = new Employe { NomEmploye= "Parker" };

        [TestMethod]
        public void TestGetEmploye()
        {
            List<Employe> lesEmployees = this.service.GetAllEmploye();
            Assert.IsNotNull(lesEmployees);
        }

        [TestMethod]
        public void TestAddEmploye()
        {
           
            List<Employe> lesEmployees = this.service.GetAllEmploye();

            int nEmployees = lesEmployees.Count;

            service.AddEmploye(this.employe);

            Assert.AreEqual(nEmployees, this.service.GetAllEmploye().Count - 1);
        }

        [TestMethod]
        public void TestUpdateEmploye()
        {
            employe.NomEmploye = "Parker";
            Employe oldEmploye = service.GetEmploye(this.employe);
            this.employe.NomEmploye = "Peter";
           
            this.service.UpdateEmploye(this.employe);

            Assert.AreNotEqual(oldEmploye.NomEmploye, this.employe.NomEmploye);
        }

        [TestMethod]
        public void TestDeleteEmploye()
        {
            List<Employe> lesEmployees = this.service.GetAllEmploye();

            int nEmployees = lesEmployees.Count;

            this.service.DeleteEmploye(lesEmployees.Where(e => e.NomEmploye == this.employe.NomEmploye).First());

            int nNewEmploye = this.service.GetAllEmploye().Count;
            Assert.AreEqual(nEmployees, nNewEmploye + 1);
        }

        

    }
}
