using Fecomercio.Domain.Entities;
using Fecomercio.Domain.Interfaces.Repository;
using Fecomercio.Domain.Interfaces.Services;

namespace Fecomercio.Domain.Services
{
    public class CobrancaService : ServiceBase<Cobranca>, ICobrancaService
    {
        private readonly ICobrancaRepository _repository;

        public CobrancaService(ICobrancaRepository repository)
            : base(repository)
        {
            _repository = repository;
        }
    }
}
