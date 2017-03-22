using JobApplication.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace JobApplication.Controllers
{
    public class HomeController : Controller
    {
        JobModel model;
        public HomeController()
        {
            model = new JobModel();
        }
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public void GetJobs()
        {
            var list = model.Jobs.ToList();
        }

        public JsonResult GetStatus()
        {
            //List<JobStatu> statusList = new List<JobStatu>();
            //statusList.Add(new JobStatu { Name = "Applied" });
            //statusList.Add(new JobStatu { Name = "Accepted" });
            //statusList.Add(new JobStatu { Name = "Rejected" });
            //statusList.Add(new JobStatu { Name = "NoResponse" });
            //statusList.Add(new JobStatu { Name = "InProgress" });
            //model.JobStatus.AddRange(statusList);
            //int result = model.SaveChanges();
            var status = model.JobStatus.ToList();
            return Json(status, JsonRequestBehavior.AllowGet);
        }
    }
}