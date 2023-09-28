using AutoMapper;
using Fecomercio.Application.DTO;
using Fecomercio.Application.DTO.Validations;
using Fecomercio.Application.Interfaces;
using Fecomercio.Application.Services;
using Fecomercio.Domain.Entities;
using Fecomercio.Domain.Interfaces.Services;

namespace Fecomercio.Application.Implementations
{
    public class BoletoApplicationService : IBoletoApplicationService
    {
        private readonly IBoletoService _service;
        private readonly IMapper _mapper;


        public BoletoApplicationService(IBoletoService service, IMapper _mapper)
        {
            _service = service;
            _mapper = _mapper;
        }

        public ResultService<BoletoDTO> GerarBoleto(BoletoDTO dto)
        {
            if (dto == null)
                return ResultService.Fail<BoletoDTO>("Ocorreu um erro com a requisição.");

            var result = new BoletoValidations().Validate(dto);

            if (!result.IsValid)
                return ResultService.RequestError<BoletoDTO>("Problemas de validação.", result);


            var ultimoPagamento = this.RecuperarUltimoPagamentoPorSacado(dto.Sacado);

            var domain = _mapper.Map<Boleto>(dto);

            domain.DiferencaValor(ultimoPagamento.Valor);

            _service.Add(domain);

            return ResultService.Ok<BoletoDTO>(_mapper.Map<BoletoDTO>(domain));
        }

        private BoletoDTO RecuperarUltimoPagamentoPorSacado(string sacado)
        {
            var retorno = _service.RecuperarUltimoPagamentoPorSacado(sacado);
            return _mapper.Map<BoletoDTO>(retorno);
        }
    }
}
