using AutoMapper;
using Fecomercio.Application.DTO;
using Fecomercio.Domain.Entities;

namespace Fecomercio.Application.Mappings
{
    public class DomainToDtoMapping: Profile
    {
        public DomainToDtoMapping() 
        {
            CreateMap<Boleto, BoletoDTO>();
            CreateMap<Cobranca, CobrancaDTO>();
            CreateMap<Comissao, ComissaoDTO>();
        }
    }
}
