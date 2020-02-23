using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SOF005_Tarea4.Models.Formulario
{
    public class Empleado
    {
        private string Nombre { get; set; }

        private string Apellido { get; set; }

        private string Cedula { get; set; }

        private int Edad { get; set; }

        private string Telefono { get; set; }

        private string Email { get; set; }

        private Genero Sexo { get; set; }

        private  Puesto Posicion { get; set; }

        private string Foto { get; set; }

        private string Curriculum { get; set; }



        public enum Genero {
            MASCULINO,FEMENINO
            }

        public enum Puesto
        {
            SECRETARIO,INGENIERO,ABOGADO,MEDICO
        }



    }
}