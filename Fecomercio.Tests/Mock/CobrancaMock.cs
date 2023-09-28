using Fecomercio.Application.DTO;

namespace Fecomercio.Tests.Mock
{
    public static class CobrancaMock
    {
        public static CobrancaDTO Padrao()
        {
            return new CobrancaDTO()
            {
                DataDeEmissao = DateTime.Now,
                DataDeVencimento = DateTime.Now.AddDays(10),
                Valor = 3000,
                Emitente = "Teste Emitente",
                Pagador = "Teste Pagador"
            };
        }

        public static CobrancaDTO DataDeVencimentoInvalida()
        {
            var dto = Padrao();
            dto.DataDeVencimento = DateTime.Now.AddDays(-1);
            return dto;
        }

        public static CobrancaDTO EmitenteInvalida()
        {
            var dto = Padrao();
            dto.Emitente = string.Empty;
            return dto;
        }

        public static CobrancaDTO PagadorInvalida()
        {
            var dto = Padrao();
            dto.Pagador = string.Empty;
            return dto;
        }
    }
}

