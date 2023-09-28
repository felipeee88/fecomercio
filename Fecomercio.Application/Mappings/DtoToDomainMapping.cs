using AutoMapper;
using Fecomercio.Application.DTO;
using Fecomercio.Domain.Entities;

namespace Fecomercio.Application.Mappings
{
    public class DtoToDomainMapping : Profile
    {
        public DtoToDomainMapping()
        {
            CreateMap<BoletoDTO, Boleto>();
            CreateMap<CobrancaDTO, Cobranca>();
            CreateMap<ComissaoDTO, Comissao>();
        }
    }
}
