using Fecomercio.Application.DTO.Validations;
using Fecomercio.Tests.Mock;
using Xunit;

namespace Fecomercio.Tests.ApplicationService
{
    public class CobrancaApplicationServiceTest
    {
        [Fact]
        public void CobrancaPreenchido()
        {
            var Cobranca = CobrancaMock.Padrao();

            var validations = new CobrancaValidations().Validate(Cobranca);

            Assert.True(validations.IsValid);
        }

        [Fact]
        public void DataDeVencimentoInvalida()
        {
            var Cobranca = CobrancaMock.DataDeVencimentoInvalida();

            var validations = new CobrancaValidations().Validate(Cobranca);

            Assert.False(validations.IsValid);
        }

        [Fact]
        public void EmitenteInvalida()
        {
            var Cobranca = CobrancaMock.EmitenteInvalida();

            var validations = new CobrancaValidations().Validate(Cobranca);

            Assert.False(validations.IsValid);
        }

        [Fact]
        public void PagadorInvalida()
        {
            var Cobranca = CobrancaMock.PagadorInvalida();

            var validations = new CobrancaValidations().Validate(Cobranca);

            Assert.False(validations.IsValid);
        }
    }
}
