using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SOF005_Tarea4.Controllers
{
    public class UnityController : Controller
    {
        // GET: Unity
        public ActionResult Home()
        {
            return View();
        }


        private double ConvertirTemperatura(double cantidadAConvertir,Temperatura unidadOrigen,Temperatura unidadDestino)
        {

            if (unidadOrigen == unidadDestino)
            {
                return cantidadAConvertir;
            }


            switch (unidadOrigen)
            {
                case Temperatura.KELVIN:
                     cantidadAConvertir -= 273.15;
                break;

                case Temperatura.FARENHEIT:
                    cantidadAConvertir = (cantidadAConvertir - 32) * (5 / 9);
                break;



            }


            switch (unidadDestino)
            {

                case Temperatura.FARENHEIT:

                 return   cantidadAConvertir = (cantidadAConvertir * (9 / 5)) + 32;

                case Temperatura.KELVIN:

                    return cantidadAConvertir += 273.15;

                default:
                    return cantidadAConvertir;

            }


    
        }

    }

    public enum Temperatura
    {
        CELCIUS,KELVIN,FARENHEIT
    }

}