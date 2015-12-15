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

            RuleFor(u => u.Nip).NotEmpty().When(u => u.CreateInvoide);

            RuleFor(u => u.Nip).Must(nip => IsNipValid(nip))
                .When(u => u.CreateInvoide);


        }

        private bool IsNipValid(string nip)
        {
            if(nip == null)
                return false;

            if (nip.Length != 10)
                return false;
            return true;
        }
    }
}
