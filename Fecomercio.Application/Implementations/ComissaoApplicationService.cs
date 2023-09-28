using AutoMapper;
using Fecomercio.Application.DTO;
using Fecomercio.Application.DTO.Validations;
using Fecomercio.Application.Interfaces;
using Fecomercio.Application.Services;
using Fecomercio.Domain.Entities;
using Fecomercio.Domain.Interfaces.Services;

namespace Fecomercio.Application.Implementations
{
    public class ComissaoApplicationService : IComissaoApplicationService
    {
        private readonly IComissaoService _service;
        private readonly IMapper _mapper;

        public ComissaoApplicationService(IComissaoService service, IMapper _mapper)
        {
            _service = service;
            _mapper = _mapper;
        }

        public ResultService<ComissaoDTO> GerarComissao(ComissaoDTO dto)
        {
            if (dto == null)
                return ResultService.Fail<ComissaoDTO>("Ocorreu um erro com a requisição.");

            var result = new ComissaoValidations().Validate(dto);

            if (!result.IsValid)
                return ResultService.RequestError<ComissaoDTO>("Problemas de validação.", result);
            //Regras do documento;

            var data = _mapper.Map<Comissao>(dto);
            _service.Add(data);
            return ResultService.Ok<ComissaoDTO>(_mapper.Map<ComissaoDTO>(data));
        }
    }
}
