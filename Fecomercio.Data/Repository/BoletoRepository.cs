using Fecomercio.Data.Context;
using Fecomercio.Domain.Entities;
using Fecomercio.Domain.Interfaces.Repository;

namespace Fecomercio.Data.Repository
{
    public class BoletoRepository : RepositoryBase<Boleto>, IBoletoRepository
    {
        protected FecomercioContext _context;

        public BoletoRepository(FecomercioContext context) : base(context)
        {
            _context = context;
        }

        public Boleto RecuperarUltimoPagamentoPorSacado(string sacado)
        {
            return _context.Set<Boleto>().Where(x => x.Sacado.Equals(sacado)).OrderByDescending(x => x.Vencimento).First();
        }
    }
}
