using FluentValidation;

namespace Fecomercio.Application.DTO.Validations
{
    public class ComissaoValidations : AbstractValidator<ComissaoDTO>
    {
        public ComissaoValidations()
        {
            RuleFor(x => x.DataDaVenda)
              .NotEmpty()
              .NotNull()
              .LessThanOrEqualTo(vencimento => DateTime.Now)
              .WithMessage("A Data da Venda deve ser informada. E a data deve ser menor ou igual a data de hoje.");

            RuleFor(x => x.PercentualDeComissao)
                .NotEmpty()
                .NotNull()
                .WithMessage("O Percentual deve ser informado.");

            RuleFor(x => x.ValorDaVenda)
               .NotEmpty()
               .NotNull()
               .GreaterThan(0)
               .WithMessage("O Valor deve ser informado.");

            RuleFor(x => x.NomeVendedor)
                .NotEmpty()
                .NotNull()
                .MaximumLength(100)
                .WithMessage("O Vendedor deve ser informado. No máximo 100 caracteres.");
        }
    }
}