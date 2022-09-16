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
        private IEnumerable<Estado> estados;
        private IEnumerable<Cidade> cidades;

        //public HomeController() { }

        public HomeController(IEstadoService estadoService, ICidadeService cidadeService, IPrevisaoClimaService previsaoClimaService, IEnumerable<Estado> estados)
        {
            this.estadoService = estadoService;
            this.cidadeService = cidadeService;
            this.previsaoClimaService = previsaoClimaService;
        }

        public ActionResult Index()
        {
            List<Estado> estados = new List<Estado>();
            estados.Add(new Estado() { Id = 50, Nome = "Espírito Santo" });
            //_estados = estados;
            this.estados = this.estadoService.Get();
            this.cidades = this.cidadeService.Get();
            ViewBag.Title = "Home Page";

            return View(this.cidades);
        }
    }
}
