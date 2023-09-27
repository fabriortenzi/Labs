using FluentValidation;
using Web.Models;

namespace Unidad._5.Lab._1.MVC.Models
{
    public class MateriaValidator : AbstractValidator<Materia>
    {
        public MateriaValidator()
        {
            RuleFor(m => m.Descripcion).NotEmpty().Length(min: 3, max: 20);
            RuleFor(m => m.HsSemanales).NotEmpty().InclusiveBetween(from: 2, to: 6);
            RuleFor(m => m.HsTotales).NotEmpty().InclusiveBetween(from: 90, to: 150);
            RuleFor(m => m.PlanId).NotEmpty();
        }
    }
}
