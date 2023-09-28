using Fecomercio.Application.DTO;
using Fecomercio.Application.Interfaces;
using Fecomercio.Application.Services;
using Fecomercio.MVC.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Fecomercio.MVC.Controllers
{
    public class BoletoController : Controller
    {
        private readonly IBoletoApplicationService _appService;
        private readonly ILogger<HomeController> _logger;

        public BoletoController(ILogger<HomeController> logger, IBoletoApplicationService appService)
        {
            _logger = logger;
            _appService = appService;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult GerarBoleto(BoletoDTO dto)
        {
            var resultado = _appService.GerarBoleto(dto);

            return RedirectToAction("FinalizarBoleto", resultado);
        }

        public IActionResult FinalizarBoleto(ResultService<BoletoDTO> dto)
        {
            return View(dto);
        }
    }
}
