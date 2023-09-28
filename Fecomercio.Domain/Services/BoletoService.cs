using Fecomercio.Domain.Entities;
using Fecomercio.Domain.Interfaces.Repository;
using Fecomercio.Domain.Interfaces.Services;

namespace Fecomercio.Domain.Services
{
    public class BoletoService : ServiceBase<Boleto>, IBoletoService
    {
        private readonly IBoletoRepository _repository;

        public BoletoService(IBoletoRepository repository)
            : base(repository)
        {
            _repository = repository;
        }

        public Boleto RecuperarUltimoPagamentoPorSacado(string sacado)
        {
            return _repository.RecuperarUltimoPagamentoPorSacado(sacado);
        }
    }
}
