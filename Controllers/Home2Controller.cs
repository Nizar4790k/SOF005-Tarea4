using SOF005_Tarea4.Models.Login;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SOF005_Tarea4.Controllers
{
    public class Home2Controller : Controller
    {
        // GET: Home2
        public ActionResult Home(User user)
        {


            return View(user);
        
        }


      

    }
}