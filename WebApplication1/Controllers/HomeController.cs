using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers {
	public class HomeController : Controller
	{
		public ActionResult Login()
		{
			return View();
		}

		[HttpPost]
		[ValidateAntiForgeryToken]
		public ActionResult Login(UserProfile objUser)
		{
			if (ModelState.IsValid)
			{	
				using (Model1 db = new Model1())
				{
					var obj = db.UserProfiles.Where(a => a.UserName.Equals(objUser.UserName) && a.Password.Equals(objUser.Password)).FirstOrDefault();
					if (obj != null)
					{
						Session["UserID"] = obj.UserId.ToString();
						Session["UserName"] = obj.UserName.ToString();
						return RedirectToAction("Index");
					}
					
					var obj1 = db.UserProfiles.Where(a => a.UserName.Equals(objUser.UserName));
					if (obj1 != null)
					{

					}
					else {
						ViewBag.Message = "Usuario o Contraseña Incorrecto";
					}
				}

			}
			return View(objUser);
		}

		
		
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
		}
		public ActionResult Calendario()
		{
			ViewBag.Message = "Your contact page.";

			return View();
		}

		public ActionResult  About()
		{
			ViewBag.Message = "Your contact page.";

			return View();
		}
		public ActionResult Contact()
		{
			ViewBag.Message = "Your contact page.";

			return View();
		}
        public ActionResult Mision()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult Descuentos()
        {
            ViewBag.Message = " ";

            return View();
        }
    }

}

