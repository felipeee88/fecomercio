using AutoMapper;
using Fecomercio.Application.DTO;
using Fecomercio.Application.DTO.Validations;
using Fecomercio.Application.Interfaces;
using Fecomercio.Application.Services;
using Fecomercio.Domain.Entities;
using Fecomercio.Domain.Interfaces.Services;

namespace Fecomercio.Application.Implementations
{
    public class CobrancaApplicationService : ICobrancaApplicationService
    {
        private readonly ICobrancaService _service;
        private readonly IMapper _mapper;

        public CobrancaApplicationService(ICobrancaService service, IMapper _mapper)
        {
            _service = service;
            _mapper = _mapper;
        }

        public ResultService<CobrancaDTO> GerarCobranca(CobrancaDTO dto)
        {
            if (dto == null)
                return ResultService.Fail<CobrancaDTO>("Ocorreu um erro com a requisição.");

            var result = new CobrancaValidations().Validate(dto);

            if (!result.IsValid)
                return ResultService.RequestError<CobrancaDTO>("Problemas de validação.", result);

            var domain = _mapper.Map<Cobranca>(dto);

            if (dto.ClienteEspecial)
                domain.Valor -= domain.Valor * (dto.ValorDesconto / 100);

            _service.Add(domain);
            return ResultService.Ok<CobrancaDTO>(_mapper.Map<CobrancaDTO>(domain));
        }
    }
}
