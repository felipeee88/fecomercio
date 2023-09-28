using Fecomercio.Application.DTO;
using Fecomercio.Application.Interfaces;
using Fecomercio.Application.Services;
using Fecomercio.MVC.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Fecomercio.MVC.Controllers
{
    public class CobrancaController : Controller
    {
        private readonly ICobrancaApplicationService _appService;
        private readonly ILogger<CobrancaController> _logger;

        public CobrancaController(ILogger<CobrancaController> logger, ICobrancaApplicationService appService)
        {
            _logger = logger;
            _appService = appService;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult GerarCobranca(CobrancaDTO dto)
        {
            var resultado = _appService.GerarCobranca(dto);

            return RedirectToAction("FinalizarCobranca", resultado);
        }

        public IActionResult FinalizarCobranca(ResultService<CobrancaDTO> dto)
        {
            return View(dto);
        }
    }
}
