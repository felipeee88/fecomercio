using Fecomercio.Data.Context;
using Fecomercio.Domain.Entities;
using Fecomercio.Domain.Interfaces.Repository;

namespace Fecomercio.Data.Repository
{
    public class CobrancaRepository : RepositoryBase<Cobranca>, ICobrancaRepository
    {
        public CobrancaRepository(FecomercioContext context) : base(context)
        {
        }
    }
}
