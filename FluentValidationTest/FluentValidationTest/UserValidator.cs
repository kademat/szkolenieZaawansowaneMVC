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
                .WithLocalizedMessage(() => UserResources.NameRequiredError)
                .WithName("Nazwy");
            //.WithMessage("Nazwa jest wymagana");

            RuleFor(u => u.Email).NotEmpty();

            RuleFor(u => u.Email).EmailAddress();



        }
    }
}
