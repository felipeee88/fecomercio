using Fecomercio.Application.DTO.Validations;
using Fecomercio.Tests.Mock;
using Xunit;

namespace Fecomercio.Tests.ApplicationService
{
    public class BoletoApplicationServiceTest
    {
        [Fact]
        public void BoletoPreenchido()
        {
            var boleto = BoletoMock.Padrao();
      
            var validations = new BoletoValidations().Validate(boleto);

            Assert.True(validations.IsValid);
        }

        [Fact]
        public void CedenteInvalido()
        {
            var boleto = BoletoMock.CedenteInvalido();

            var validations = new BoletoValidations().Validate(boleto);

            Assert.False(validations.IsValid);
        }

        [Fact]
        public void VencimentoInvalido()
        {
            var boleto = BoletoMock.VencimentoInvalido();

            var validations = new BoletoValidations().Validate(boleto);

            Assert.False(validations.IsValid);
        }

        [Fact]
        public void ValorInvalido()
        {
            var boleto = BoletoMock.ValorInvalido();

            var validations = new BoletoValidations().Validate(boleto);

            Assert.False(validations.IsValid);
        }

        [Fact]
        public void DocumentoInvalido()
        {
            var boleto = BoletoMock.DocumentoInvalido();

            var validations = new BoletoValidations().Validate(boleto);

            Assert.False(validations.IsValid);
        }

        [Fact]
        public void AgenciaInvalida()
        {
            var boleto = BoletoMock.AgenciaInvalida();

            var validations = new BoletoValidations().Validate(boleto);

            Assert.False(validations.IsValid);
        }

        [Fact]
        public void ContaInvalida()
        {
            var boleto = BoletoMock.ContaInvalida();

            var validations = new BoletoValidations().Validate(boleto);

            Assert.False(validations.IsValid);
        }
    }
}
