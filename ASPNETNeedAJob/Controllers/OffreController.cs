﻿using ASPNETNeedAJob.Models;
using biblio.Entities;
using Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ASPNETNeedAJob.Controllers
{
    public class OffreController : Controller
    {
        private IService service;

        public ActionResult ListeOffres()
        {
            return View(GetOffres());
        }

        public ActionResult RechercheOffre()
        {
            return View();
        }

        public ActionResult DetailsOffre(int id)
        {   
            return View(GetOffreById(id));
        }

        public ActionResult PostulerOffre(int idOffre, int idEmploye)
        {
            return Json(new { Postulation = idOffre, Employe = idEmploye }, JsonRequestBehavior.AllowGet);
        }

        public OffreViewModel GetOffreById(int idOffre)
        {
            service = new Service.Service();
            OffreViewModel offre = new OffreViewModel();
            try
            {
                offre = ConvertirOffre(service.GetOffreById(idOffre));
            }
            catch (Exception e)
            {
                throw e;
            }
            return offre;
        }

        public List<OffreViewModel> GetOffres()
        {
            service = new Service.Service();
            List<OffreViewModel> offres = new List<OffreViewModel>();
            try
            {
                List<Offre> offresBdd = service.GetAllOffre();
                foreach (Offre offre in offresBdd)
                {
                    offres.Add(ConvertirOffre(offre));
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            return offres;
        }

        public OffreViewModel ConvertirOffre(Offre offre)
        {
            OffreViewModel offreModel = new OffreViewModel();
            offreModel.idOffre = offre.IdOffre;
            offreModel.idStatutOffre = offre.IdStatutOffre;
            offreModel.intituleOffre = offre.IntituleOffre;
            offreModel.responsableOffre = offre.ResponsableOffre;
            offreModel.salaireOffre = offre.SalaireOffre;
            return offreModel;
        }
    }
}