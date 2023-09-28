using Fecomercio.Application.DTO;

namespace Fecomercio.Tests.Mock
{
    public static class BoletoMock
    {
        public static BoletoDTO Padrao()
        {
            return new BoletoDTO()
            {
                Numero = "12346789",
                Vencimento = DateTime.Now,
                Valor = 5000,
                Cedente = "Teste Cedente",
                Documento = "11546847847",
                Sacado = "Teste Sacado",
                NossoNumero = "123456789987654321",
                Agencia = "0077",
                Conta = "114658",
                CodigoDeBarras = "2316546987564163513214654987625416879876216857987",
                LinhaDigitavel = "2316546987564163513214654987625416879876216857987"
            };
        }

        public static BoletoDTO CedenteInvalido()
        {
            var dto = Padrao();
            dto.Cedente = string.Empty;
            return dto;
        }

        public static BoletoDTO VencimentoInvalido()
        {
            var dto = Padrao();
            dto.Vencimento = DateTime.Now.AddDays(-1);
            return dto;
        }

        public static BoletoDTO ValorInvalido()
        {
            var dto = Padrao();
            dto.Valor = 0;
            return dto;
        }

        public static BoletoDTO DocumentoInvalido()
        {
            var dto = Padrao();
            dto.Documento = string.Empty;
            return dto;
        }

        public static BoletoDTO AgenciaInvalida()
        {
            var dto = Padrao();
            dto.Agencia = string.Empty;
            return dto;
        }

        public static BoletoDTO ContaInvalida()
        {
            var dto = Padrao();
            dto.Conta = string.Empty;
            return dto;
        }
    }
}
