using Fecomercio.Domain.Entities;

namespace Fecomercio.Domain.Interfaces.Repository
{
    public interface IBoletoRepository : IRepositoryBase<Boleto>
    {
        Boleto RecuperarUltimoPagamentoPorSacado(string sacado);
    }
}
