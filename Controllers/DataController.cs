using ExcelDataReader;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SOF005_Tarea4.Controllers
{
    public class DataController : Controller
    {
        // GET: Data
        public ActionResult excelFile()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult excelFile(HttpPostedFileBase upload)
        {
            if (ModelState.IsValid)
            {

                if (upload != null && upload.ContentLength > 0)
                {
                    // ExcelDataReader works with the binary Excel file, so it needs a FileStream
                    // to get started. This is how we avoid dependencies on ACE or Interop:
                    Stream stream = upload.InputStream;

                    // We return the interface, so that
                    IExcelDataReader reader = null;


                    if (upload.FileName.EndsWith(".xls"))
                    {
                        reader = ExcelReaderFactory.CreateBinaryReader(stream);
                    }
                    else if (upload.FileName.EndsWith(".xlsx"))
                    {
                        reader = ExcelReaderFactory.CreateOpenXmlReader(stream);
                    }
                    else
                    {
                        ModelState.AddModelError("File", "Formato de archivo no soportado");
                        return View();
                    }

                    DataSet result = reader.AsDataSet();
                    reader.Close();

                    return View(result.Tables[0]);
                }
                else
                {
                    ModelState.AddModelError("File", "Porfavor seleccione un archivo");
                }
            }
            return View();
        }



        public ActionResult Contenido()
        {
            @ViewBag.sitio = Request.Form["contenido"];

            if (@ViewBag.sitio == "noticias")
            {
                return View("Noticias");
            }
            if (@ViewBag.sitio == "musica")
            {
                return View("Musica");
            }
            if (@ViewBag.sitio == "peliculas")
            {
                return View("Peliculas");
            }
            else
            {
                return View();
            }

        }

        public ActionResult Noticias()
        {
            return View();
        }

        public ActionResult Musica()
        {
            return View();
        }

        public ActionResult Peliculas()
        {
            return View();
        }
    }
}