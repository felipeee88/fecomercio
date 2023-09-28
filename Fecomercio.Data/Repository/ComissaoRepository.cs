using Fecomercio.Data.Context;
using Fecomercio.Domain.Entities;
using Fecomercio.Domain.Interfaces.Repository;

namespace Fecomercio.Data.Repository
{
    public class ComissaoRepository : RepositoryBase<Comissao>, IComissaoRepository
    {
        public ComissaoRepository(FecomercioContext context) : base(context)
        {
        }
    }
}
