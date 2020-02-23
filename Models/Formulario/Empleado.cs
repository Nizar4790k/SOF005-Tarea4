using SOF005_Tarea4.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace SOF005_Tarea4.Models.Formulario
{
    public class Empleado
    {
        [Required(ErrorMessage ="El nombre es obligatorio")]
        public string Nombre { get; set; }

        [Required(ErrorMessage="El apellido es obligatorio")]
        public string Apellido { get; set; }

        [Required(ErrorMessage ="La cedula es obligatoria")]
        public string Cedula { get; set; }

        [Range(18, 2147483647,ErrorMessage ="Edad no valida")]
        public int Edad { get; set; }

        public string Telefono { get; set; }

        [EmailAddress]
        public string Email { get; set; }

        public Genero Sexo { get; set; }

        public  Puesto Posicion { get; set; }

        public string Foto { get; set; }

        public string Curriculum { get; set; }



   



    }

    public enum Genero
    {
        MASCULINO, FEMENINO
    }

    public enum Puesto
    {
        SECRETARIO, INGENIERO, ABOGADO, MEDICO
    }


}