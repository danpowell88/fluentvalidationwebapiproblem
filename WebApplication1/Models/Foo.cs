using FluentValidation;

namespace WebApplication1.Models
{
    public class Foo
    {
        public Foo(Bar bar)
        {
            Bar = bar;
        }

        public string Test { get; set; }
        public string Test2 { get; set; }
        public string Test3 { get; set; }

        public Bar Bar { get; set; }
    }

    public class FooValidator : AbstractValidator<Foo>
    {
        public FooValidator()
        {
            RuleFor(x => x.Test).NotEmpty();
            RuleFor(x => x.Test2).NotEmpty();
        }
    }
}