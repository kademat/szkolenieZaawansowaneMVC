using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FluentValidationTest
{
    class UserValidator : AbstractValidator<User>
    {
        public UserValidator()
        {
            RuleFor(u => u.Name)
                .NotEmpty()
                .WithLocalizedMessage(() => UserResources.NameRequiredError);
                //.WithMessage("Nazwa jest wymagana");




        }
    }
}
