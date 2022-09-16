using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Application.Services;
using Dominio.Model;
using Dominio.Services;

namespace ClimaTempoSimples.Controllers
{
    public class HomeController : Controller
    {
        private IEstadoService estadoService;
        private ICidadeService cidadeService;
        private IPrevisaoClimaService previsaoClimaService;

        public HomeController(IEstadoService estadoService, ICidadeService cidadeService, IPrevisaoClimaService previsaoClimaService, IEnumerable<Estado> estados)
        {
            this.estadoService = estadoService;
            this.cidadeService = cidadeService;
            this.previsaoClimaService = previsaoClimaService;
        }

        public ActionResult Index()
        {
            ViewBag.HjMax = this.previsaoClimaService.GetHjMax();
            ViewBag.HjMin = this.previsaoClimaService.GetHjMin();
            ViewBag.Cidades = this.cidadeService.Get();
            ViewBag.Title = "Home Page";

            return View();
        }
    }
}
