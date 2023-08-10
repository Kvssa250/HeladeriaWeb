using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HeladeriaWeb.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Sucursal()
        {
            return View();
        }

        public ActionResult Venta()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Empleado()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult Inventario()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}