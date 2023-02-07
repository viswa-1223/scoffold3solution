using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace scoffold3.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            TutorialsCS context = new TutorialsCS();

            var listofData = context.Employees.ToList();
            return View(listofData);
        }
  
    }
}