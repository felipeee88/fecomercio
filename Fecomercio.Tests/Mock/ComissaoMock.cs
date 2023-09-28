using Fecomercio.Application.DTO;

namespace Fecomercio.Tests.Mock
{
    public static class ComissaoMock
    {
        public static ComissaoDTO Padrao()
        {
            return new ComissaoDTO()
            {
                DataDaVenda = DateTime.Now,
                ValorDaVenda = 1000,
                PercentualDeComissao = 10,
                NomeVendedor = "Teste Vendedor",
            };
        }
        public static ComissaoDTO DataDaVendaInvalida()
        {
            var dto = Padrao();
            dto.DataDaVenda = DateTime.Now.AddDays(1);
            return dto;
        }

        public static ComissaoDTO NomeVendedorInvalido()
        {
            var dto = Padrao();
            dto.NomeVendedor = string.Empty;
            return dto;
        }

        public static ComissaoDTO ValorDaVendaInvalida()
        {
            var dto = Padrao();
            dto.ValorDaVenda = 0;
            return dto;
        }
    }
}
