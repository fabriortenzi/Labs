using FluentValidation;
using System;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace Web.Models
{
    public record RegisterViewModel
    {
        public string Nombre { get; set; }
        public string Mail { get; init; }
        public string Clave { get; init; }
        [Display(Name = "Confirmar Clave")]
        public string ConfirmarClave { get; init; }
        public bool IsPersistent { get; init; }
    }

    public class RegisterValidator: AbstractValidator<RegisterViewModel>
    {
        public RegisterValidator()
        {
            RuleFor(rvm => rvm.Nombre).Length(3, 30);
            RuleFor(rvm => rvm.Mail).NotEmpty().EmailAddress();
            RuleFor(rvm => rvm.Clave).NotEmpty().MinimumLength(6)
                .Must(c => c.Any(Char.IsUpper)).WithMessage("La contraseña debe tener al menos un caracter en mayuscula")
                .Must(c => c.Any(Char.IsDigit)).WithMessage("La contraseña debe tener al menos un numero"); ;
            RuleFor(rvm => rvm.ConfirmarClave).Equal(rvm => rvm.Clave);
        }
    }
}
