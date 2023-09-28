using Fecomercio.Application.DTO;
using Fecomercio.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Fecomercio.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ComissaoController : ControllerBase
    {
        private readonly IComissaoApplicationService _appService;
        private readonly ILogger<ComissaoController> _logger;

        public ComissaoController(ILogger<ComissaoController> logger, IComissaoApplicationService appService)
        {
            _logger = logger;
            _appService = appService;
        }

        [HttpPost(Name = "GerarComissao")]
        public IActionResult GerarComissao([FromBody] ComissaoDTO dto)
        {
            var resultado = _appService.GerarComissao(dto);
            return Ok(resultado);
        }
    }
}
