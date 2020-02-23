using SOF005_Tarea4.Models.Formulario;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SOF005_Tarea4.Controllers
{
    public class FormController : Controller
    {
        // GET: Form
        public ActionResult Home()
        {
            return View();
        }
  
    
        public ActionResult Result(Empleado empleado)
        {

            return View(empleado);
        }

        [HttpPost]
        public ActionResult Home(Empleado empleado)
        {
            if (ModelState.IsValid)
            {
                return RedirectToAction("Result",empleado);
            }
            else
            {
                return View();
            }

         
        }


    
    
    
    }


 

}