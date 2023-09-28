using Fecomercio.Application.DTO;
using Fecomercio.Application.Services;
using Fecomercio.Domain.Entities;

namespace Fecomercio.Application.Interfaces
{
    public interface IBoletoApplicationService
    {
        ResultService<BoletoDTO> GerarBoleto(BoletoDTO dto);
    }
}
