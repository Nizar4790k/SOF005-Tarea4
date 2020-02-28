using SOF005_Tarea4.Models.Login;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SOF005_Tarea4.Controllers
{

    public class LoginController : Controller
    {
        // GET: Login


        [HttpPost]
        public ActionResult Login(User user)
        {

            if (ModelState.IsValid)
            {
                return RedirectToAction("Home","Home2",user);
            }
            else
            {
                return View();
            }


        }

        public ActionResult Login()
        {
            return View();
        }



    }
}