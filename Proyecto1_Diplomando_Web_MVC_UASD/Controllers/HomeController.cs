using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Proyecto1_Diplomando_Web_MVC_UASD.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public string index()
        {
            return "<html><body>" +
                   "<h1>Universidad Autónoma de Santo Domingo (UASD) </h1>" +
                   "<p>Diplomando Desarrollo Web C#, MVC </p>" +
                   "</body></html>";
        }

        public string DiplomadoWeb()
        {
            return "<html><body>" +
                   "<h1>Estudiante:</h1>" +
                   "<p>Carlos R. Peña E.</p>" +
                   "</body></html>";

        }

    }
}