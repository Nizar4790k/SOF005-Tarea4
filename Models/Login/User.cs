using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace SOF005_Tarea4.Models.Login
{
    public class User
    {

       
        [Required (ErrorMessage="El nombre de usuario no es valido")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "La contrasena  no es valida")]
        public string Password { get; set; }





    


        

    }
}