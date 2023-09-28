using FluentValidation;

namespace Fecomercio.Application.DTO.Validations
{
    public class CobrancaValidations : AbstractValidator<CobrancaDTO>
    {
        public CobrancaValidations()
        {
            RuleFor(x => x.DataDeVencimento)
               .NotEmpty()
               .NotNull()
               .GreaterThanOrEqualTo(vencimento => DateTime.Now)
               .WithMessage("O Vencimento deve ser informada. E a data de vencimento deve ser maior ou igual a data de hoje.");

            RuleFor(x => x.Valor)
                .NotEmpty()
                .NotNull()
                .GreaterThan(0)
                .WithMessage("O Valor deve ser informado.");

            RuleFor(x => x.Emitente)
                .NotEmpty()
                .NotNull()
                .MaximumLength(100)
                .WithMessage("O Emitente deve ser informado. No máximo 100 caracteres.");

            RuleFor(x => x.Pagador)
                .NotEmpty()
                .NotNull()
                .MaximumLength(100)
                .WithMessage("O Pagador deve ser informado. No máximo 100 caracteres.");
        }
    }
}