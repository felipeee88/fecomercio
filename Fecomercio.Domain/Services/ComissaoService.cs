using Fecomercio.Domain.Entities;
using Fecomercio.Domain.Interfaces.Repository;
using Fecomercio.Domain.Interfaces.Services;

namespace Fecomercio.Domain.Services
{
    public class ComissaoService : ServiceBase<Comissao>, IComissaoService
    {
        private readonly IComissaoRepository _repository;

        public ComissaoService(IComissaoRepository repository)
            : base(repository)
        {
            _repository = repository;
        }
    }
}
