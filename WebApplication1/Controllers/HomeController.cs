using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Empresa()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult Cursos()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult Instructor()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult Datos()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        } public ActionResult Calendario()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}