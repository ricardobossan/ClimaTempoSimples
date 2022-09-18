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
            ViewBag.Title = "Home Page";
            ViewBag.HjMax = this.previsaoClimaService.GetHjMax();
            ViewBag.HjMin = this.previsaoClimaService.GetHjMin();

            IEnumerable<Cidade> cidades = this.cidadeService.Get();

            ViewBag.Cidades = new SelectList(cidades, "Id", "Nome");
            //ViewBag.CidadeSelecionada = "";
            ViewBag.PrevisaoCity = this.previsaoClimaService.GetChosenCity(1);
            ViewBag.CidadeSelecionada = cidades.Where(x => x.Id == 1).FirstOrDefault().Nome;
            return View();
        }


        // TODO: Mudança no dropdown não renderiza nenhuma diferença, e nem chama alertas do index.cshtml
        [Route("Home/Index/{id}")]
        public JsonResult CityChosen(int id)
        {
            IEnumerable<Cidade> cidades = this.cidadeService.Get();
            IEnumerable<PrevisaoClima> previsaoCity = this.previsaoClimaService.GetChosenCity(id);
            ViewBag.CidadeSelecionada = cidades.Where(x => x.Id == id).FirstOrDefault().Nome;
            ViewBag.PrevisaoCity = previsaoCity;
            return Json(previsaoCity,JsonRequestBehavior.AllowGet);
        }


    }
}
