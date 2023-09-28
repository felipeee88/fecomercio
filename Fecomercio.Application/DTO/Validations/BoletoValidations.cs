using FluentValidation;

namespace Fecomercio.Application.DTO.Validations
{
    public class BoletoValidations : AbstractValidator<BoletoDTO>
    {
        public BoletoValidations()
        {
            RuleFor(x => x.Cedente)
                .NotEmpty()
                .NotNull()
                .MaximumLength(100)
                .WithMessage("O Cedente deve ser informado. No máximo 14 caracteres.");

            RuleFor(x => x.Vencimento)
                .NotEmpty()
                .NotNull()
                .GreaterThanOrEqualTo(vencimento => DateTime.Now)
                .WithMessage("O Vencimento deve ser informada. E a data de vencimento deve ser maior ou igual a data de hoje.");


            RuleFor(x => x.Valor)
                .NotEmpty()
                .NotNull()
                .GreaterThan(0)
                .WithMessage("O Valor deve ser informado.");

            RuleFor(x => x.Documento)
                .NotEmpty()
                .NotNull()
                .MaximumLength(14)
                .WithMessage("O Documento deve ser informado. No máximo 14 caracteres.");

            RuleFor(x => x.Sacado)
                .NotEmpty()
                .NotNull()
                .MaximumLength(100)
                .WithMessage("O Sacado deve ser informado. No máximo 100 caracteres.");

            RuleFor(x => x.Agencia)
               .NotEmpty()
               .NotNull()
               .MaximumLength(10)
               .WithMessage("A Agência deve ser informado. No máximo 10 caracteres.");

            RuleFor(x => x.Conta)
               .NotEmpty()
               .NotNull()
               .MaximumLength(15)
               .WithMessage("A Conta deve ser informado. No máximo 15 caracteres.");
        }
    }
}
