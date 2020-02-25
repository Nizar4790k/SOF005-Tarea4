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
        public ActionResult Home(Empleado empleado,HttpPostedFileBase[] archivos)
        {
            if (ModelState.IsValid)


            {
                
               
                foreach(HttpPostedFileBase archivo in archivos)
                {

                    string nombre = archivo.FileName;


                    bool esPdf = nombre.Substring(nombre.Length-4)==".pdf";

                    if (esPdf){

                        archivo.SaveAs(Server.MapPath("/CV/" + nombre));
                        empleado.Curriculum = nombre;
                    }
                    else
                    {
                        
                 
                        archivo.SaveAs(Server.MapPath(("/Fotos/" + nombre)));
                        empleado.Foto = nombre;
              
                    }


                }


              
           


                return RedirectToAction("Result",empleado);
            }
            else
            {
                return View();
            }

         
        }


    
    
    
    }


 

}