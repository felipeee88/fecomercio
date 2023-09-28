using Fecomercio.Application.DTO.Validations;
using Fecomercio.Tests.Mock;
using Xunit;

namespace Fecomercio.Tests.ApplicationService
{
    public class ComissaoApplicationServiceTest
    {
        [Fact]
        public void ComissaoPreenchido()
        {
            var Comissao = ComissaoMock.Padrao();

            var validations = new ComissaoValidations().Validate(Comissao);

            Assert.True(validations.IsValid);
        }

        [Fact]
        public void DataDaVendaInvalida()
        {
            var Comissao = ComissaoMock.DataDaVendaInvalida();

            var validations = new ComissaoValidations().Validate(Comissao);

            Assert.False(validations.IsValid);
        }

        [Fact]
        public void NomeVendedorInvalido()
        {
            var Comissao = ComissaoMock.NomeVendedorInvalido();

            var validations = new ComissaoValidations().Validate(Comissao);

            Assert.False(validations.IsValid);
        }

        [Fact]
        public void ValorDaVendaInvalida()
        {
            var Comissao = ComissaoMock.ValorDaVendaInvalida();

            var validations = new ComissaoValidations().Validate(Comissao);

            Assert.False(validations.IsValid);
        }
    }
}
