using Fecomercio.Domain.Entities;

namespace Fecomercio.Domain.Interfaces.Services
{
    public interface IBoletoService : IServiceBase<Boleto>
    {
        Boleto RecuperarUltimoPagamentoPorSacado(string sacado);
    }
}
