using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ClimaTempoSimples.Controllers
{
    public class SobreController : Controller
    {
        // GET: Sobre
        [Route("Sobre/Index")]
        public ActionResult Index()
        {
            return View();
        }
    }
}