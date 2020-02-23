using SOF005_Tarea4.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SOF005_Tarea4.Controllers
{
    public class ConversorController : Controller
    {


        private static  Conversion sConversion = new Conversion();

        // GET: Unity
        public ActionResult Home()
        {
            return View();
        }

        public ActionResult Calculator(Conversion conversion)
        {
            sConversion.Tipo = conversion.Tipo;

            return View(conversion);
        }

        public ActionResult Result(Conversion conversion)
        {
            string unidadFinal = conversion.UnidadFinal;


            string unidadInicial = conversion.UnidadInicial;
         

            double cantidadInicial = conversion.CantidadInicial;

            conversion.Tipo = sConversion.Tipo;

            switch (conversion.Tipo)
            {

                case "TEMPERATURA":
                    Temperatura temperaturaInicial = (Temperatura)Enum.Parse(typeof(Temperatura),unidadInicial);
                    Temperatura temperaturaFinal = (Temperatura) Enum.Parse(typeof(Temperatura), unidadFinal);
                    conversion.CantidadFinal = ConvertirTemperatura(cantidadInicial, temperaturaInicial, temperaturaFinal);
                    break;

                case "MASA":

                    Masa masaInicial = (Masa) Enum.Parse(typeof(Masa),unidadInicial);
                    Masa masaFinal = (Masa) Enum.Parse(typeof(Masa),unidadFinal);

                    conversion.CantidadFinal = ConvertirMasa(cantidadInicial, masaInicial, masaFinal);

                    break;

                case "LONGITUD":

                    Longitud longitudInicial = (Longitud)Enum.Parse(typeof(Longitud),unidadInicial);
                    Longitud longitudFinal = (Longitud) Enum.Parse(typeof(Longitud), unidadFinal);

                    conversion.CantidadFinal = ConvertirLongitud(cantidadInicial, longitudInicial, longitudFinal);

                    break;

                case "DATOS":

                    Dato datoInicial = (Dato)Enum.Parse(typeof(Dato), unidadInicial);
                    Dato datoFinal = (Dato) Enum.Parse(typeof(Dato), unidadFinal);

                    conversion.CantidadFinal = ConvertirData(cantidadInicial, datoInicial, datoFinal) ;

                    break;



            }


            return View(conversion);
        }

        


        private double ConvertirData(double cantidadAconvertir, Dato unidadOrigen, Dato unidadDestino)
        {

            // En esta funcion se escogio el BYTE como unidad base

            if (unidadOrigen == unidadDestino)
            {
               
                return cantidadAconvertir;
            }

            switch (unidadOrigen)
            {
              

                case Dato.BIT:
                    cantidadAconvertir = cantidadAconvertir / 8.0;
                    break;

                case Dato.KILOBYTE:
                    cantidadAconvertir = cantidadAconvertir * 1000.0;
                    break;


                case Dato.MEGABYTE:
                    cantidadAconvertir = cantidadAconvertir * Math.Pow(10, 6);
                    break;

                case Dato.GIGABYTE:
                    cantidadAconvertir = cantidadAconvertir * Math.Pow(10, 9);
                    break;



                case Dato.TERABYTE:
                    cantidadAconvertir= cantidadAconvertir * Math.Pow(10, 12);
                    break;

            }


            switch (unidadDestino)
            {

                case Dato.BIT:
                    return cantidadAconvertir = cantidadAconvertir * 8.0;
                 

                case Dato.KILOBYTE:
                   return cantidadAconvertir = cantidadAconvertir / 1000.0;
                   

                case Dato.GIGABYTE:
                   return cantidadAconvertir = cantidadAconvertir * Math.Pow(10, -6);


                case Dato.MEGABYTE:
                   return cantidadAconvertir = cantidadAconvertir * Math.Pow(10, -9);


                case Dato.TERABYTE:
                    return cantidadAconvertir= cantidadAconvertir * Math.Pow(10, -12);
                    

            }


            return cantidadAconvertir;





        }


        private double ConvertirLongitud(double cantidadAconvertir, Longitud unidadOrigen, Longitud unidadDestino)
        {

            // En esta funcion se escogio el KILOGRAMO como unidad base

            if (unidadOrigen == unidadDestino)
            {
                return cantidadAconvertir;
            }

            switch (unidadOrigen)
            {

                case Longitud.CENTIMETRO:
                    cantidadAconvertir = cantidadAconvertir / 100.0;
                    break;

                case Longitud.KILOMETRO:
                    cantidadAconvertir = cantidadAconvertir * 1000.0;
                    break;

                case Longitud.MILLA:
                    cantidadAconvertir = cantidadAconvertir * 1609.34;
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
                    cantidadAconvertir = cantidadAconvertir * 100.0;
                    break;

                case Longitud.KILOMETRO:
                    cantidadAconvertir = cantidadAconvertir / 1000.0;
                    break;

                case Longitud.MILLA:
                    cantidadAconvertir = cantidadAconvertir / 1609.0;
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




        private double ConvertirMasa(double cantidadAconvertir,Masa unidadOrigen, Masa unidadDestino)
        {

            // En esta funcion se escogio el METRO como unidad base

            if (unidadOrigen == unidadDestino)
            {
                return cantidadAconvertir;
            }

            switch (unidadOrigen)
            {

                case Masa.GRAMO:
                    cantidadAconvertir = cantidadAconvertir / 1000.0;
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
                    return cantidadAconvertir = cantidadAconvertir * 1000.0;


                case Masa.ONZA:
                    return cantidadAconvertir = cantidadAconvertir * 35.274;
                    

                case Masa.LIBRA:
                    return cantidadAconvertir = cantidadAconvertir * 2.205;


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
                    cantidadAConvertir = (cantidadAConvertir - 32.0) * (5.0 / 9.0);
                break;



            }


            switch (unidadDestino)
            {

                case Temperatura.FARENHEIT:

                 return   cantidadAConvertir = (cantidadAConvertir * (9 / 5)) + 32.0;

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

    public enum Dato
    {
        BIT,BYTE,KILOBYTE,MEGABYTE,GIGABYTE,TERABYTE
    }



}