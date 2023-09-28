using Fecomercio.Application.DTO;
using Fecomercio.Application.Services;

namespace Fecomercio.Application.Interfaces
{
    public interface IComissaoApplicationService
    {
        ResultService<ComissaoDTO> GerarComissao(ComissaoDTO dto);
    }
}
