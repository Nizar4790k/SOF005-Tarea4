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







        private double ConvertirLongitud(double cantiadadAconveritr,Longitud unidadOrigen, Longitud unidadDestino)
        {

            // En esta funcion se escogio el METRO como unidad base

            if (unidadOrigen == unidadDestino)
            {
                return cantidadAconvertir;
            }

            switch (unidadOrigen)
            {

                case Masa.GRAMO:
                    cantidadAconvertir = cantidadAconvertir / 1000;
                    break;

                case Masa.ONZA:
                    cantidadAconvertir = cantidadAconvertir / 35.274;
                    break;

                case Masa.LIBRA:
                    cantidadAconvertir = cantidadAconvertir / 2.205;
                    break;

            }



            switch (unidadOrigen)
            {

                case Masa.GRAMO:
                    cantidadAconvertir = cantidadAconvertir / 1000;
                    break;

                case Masa.ONZA:
                    cantidadAconvertir = cantidadAconvertir / 35.274;
                    break;

                case Masa.LIBRA:
                    cantidadAconvertir = cantidadAconvertir / 2.205;
                    break;

            }


            switch (unidadDestino)
            {

                case Masa.GRAMO:
                    return cantidadAconvertir = cantidadAconvertir * 1000;


                case Masa.ONZA:
                    return cantidadAconvertir = cantidadAconvertir * 35.274;
                    break;

                case Masa.LIBRA:
                    return cantidadAconvertir = cantidadAconvertir * 2.205;


            }


            return cantidadAconvertir;




        }





        private double ConvertirMasa(double cantidadAconvertir, Masa unidadOrigen, Masa unidadDestino)
        {

            // En esta funcion se escogio el KILOGRAMO como unidad base

            if (unidadOrigen == unidadDestino)
            {
                return cantidadAconvertir;
            }

            switch (unidadOrigen)
            {

                case Longitud.CENTIMETRO:
                    cantidadAconvertir = cantidadAconvertir/100;
                    break;

                case Longitud.KILOMETRO:
                    cantidadAconvertir = cantidadAconvertir * 1000;
                    break;

                case Longitud.MILLA:
                    cantidadAconvertir = cantidadAconvertir * 1609;
                    break;

                case Longitud.PULGADAS:
                    cantidadAconvertir = cantidadAconvertir / 39.37;
                    break;

                case Longitud.PIE:
                    cantidadAconvertir = cantidadAconvertir / 3.281;
                    break;


            }




            switch (unidadDestino)
            {

                case Longitud.CENTIMETRO:
                    cantidadAconvertir = cantidadAconvertir * 100;
                    break;

                case Longitud.KILOMETRO:
                    cantidadAconvertir = cantidadAconvertir / 1000;
                    break;

                case Longitud.MILLA:
                    cantidadAconvertir = cantidadAconvertir / 1609;
                    break;

                case Longitud.PULGADAS:
                    cantidadAconvertir = cantidadAconvertir * 39.37;
                    break;

                case Longitud.PIE:
                    cantidadAconvertir = cantidadAconvertir * 3.281;
                    break;


            }


            return cantidadAconvertir;

        }
        


        

        private double ConvertirTemperatura(double cantidadAConvertir,Temperatura unidadOrigen,Temperatura unidadDestino)
        {

            // En esta funcion se escogio Celcius como unidad base


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

    public enum Masa
    {
        GRAMO,KILOGRAMO,ONZA,LIBRA
    }

    public enum Longitud
    {
        CENTIMETRO,PIE,PULGADAS,METRO,KILOMETRO,MILLA    
    }

}