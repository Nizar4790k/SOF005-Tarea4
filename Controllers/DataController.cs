using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SOF005_Tarea4.Controllers
{
    public class DataController : Controller
    {
        // GET: Data
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Contenido()
        {
            @ViewBag.sitio = Request.Form["contenido"];

            if (@ViewBag.sitio == "noticias")
            {
                return View("Noticias");
            }
            if (@ViewBag.sitio == "musica")
            {
                return View("Musica");
            }
            if (@ViewBag.sitio == "peliculas")
            {
                return View("Peliculas");
            }
            else
            {
                return View();
            }

        }

        public ActionResult Noticias()
        {
            return View();
        }

        public ActionResult Musica()
        {
            return View();
        }

        public ActionResult Peliculas()
        {
            return View();
        }
    }
}