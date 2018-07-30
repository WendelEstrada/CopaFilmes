using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Wes.CopaMundoFilmes.Application.Services.Interfaces;
using Wes.CopaMundoFilmes.Application.ViewModel;

namespace Wes.CopaMundoFilmes.Presentation.Site.Controllers
{
    public class FilmeController : Controller
    {
        private readonly IFilmeAppService filmeAppService;
        private readonly ICampeonatoAppService campeonatoAppService;

        public FilmeController(IFilmeAppService filmeAppService, ICampeonatoAppService campeonatoAppService)
        {
            this.filmeAppService = filmeAppService;
            this.campeonatoAppService = campeonatoAppService;
        }

        [HttpGet]
        public ActionResult Index()
        {
            return View(filmeAppService.ObterTodosFilmes());
        }

        [HttpPost]
        public ActionResult Index(List<FilmeViewModel> filmesViewModel)
        {
            campeonatoAppService.Iniciar(filmesViewModel);
            return View("Resultado", campeonatoAppService.CampeonatoViewModel);
        }
    }
}
