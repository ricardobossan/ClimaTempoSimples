using System.Collections.Generic;
using System.Web.Mvc;
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
            return View();
        }

        [Route("Home/Index/{id}")]
        public JsonResult CityChosen(int id)
        {
            IEnumerable<PrevisaoClima> previsaoCity = this.previsaoClimaService.GetChosenCity(id);
            return Json(previsaoCity, JsonRequestBehavior.AllowGet);
        }

    }
}
