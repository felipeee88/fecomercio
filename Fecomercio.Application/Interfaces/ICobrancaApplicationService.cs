using Fecomercio.Application.DTO;
using Fecomercio.Application.Services;

namespace Fecomercio.Application.Interfaces
{
    public interface ICobrancaApplicationService
    {
        ResultService<CobrancaDTO> GerarCobranca(CobrancaDTO dto);
    }
}
