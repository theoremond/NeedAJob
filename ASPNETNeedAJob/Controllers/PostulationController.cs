using ASPNETNeedAJob.Models;
using biblio.Entities;
using Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ASPNETNeedAJob.Controllers
{
    public class PostulationController : Controller
    {
        IService service;
        public ActionResult ListePostulations()
        {
            return View(GetPostulations());
        }

        public List<PostulationViewModel> GetPostulations()
        {
            service = new Service.Service();
            List<PostulationViewModel> postulations = new List<PostulationViewModel>();
            try
            {
                List<Postulation> postulationsBdd = service.GetAllPostulation();
                foreach(Postulation postulation in postulationsBdd)
                {
                    postulations.Add(ConvertirPostulation(postulation));
                }
            } catch (Exception e)
            {
                throw e;
            }
            return postulations;
        }

        public PostulationViewModel ConvertirPostulation(Postulation postulation)
        {
            PostulationViewModel postulationVM = new PostulationViewModel();
            postulationVM.idOffrePostulation = postulation.IdOffrePostulation;
            postulationVM.idEmployePostulation = postulation.IdEmployePostulation;
            postulationVM.datePostulation = postulation.DatePostulation;
            postulationVM.statutPostulation = postulation.StatutPostulation;
            return postulationVM;
        }
    }
}