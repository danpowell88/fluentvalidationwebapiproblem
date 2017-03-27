using FluentValidation;

namespace WebApplication1.Models
{
    public class Bar
    {
        public string Pepsi {get;}
        public string Coke { get; set; }

    }

    public class BarValidator : AbstractValidator<Bar>
    {
        public BarValidator()
        {
            RuleFor(x => x.Pepsi).Length(3);
        }
    }
}