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
        public UserValidator(IUserLogic userLogic)
        {
            RuleFor(u => u.Name)
                .NotEmpty()
                .WithLocalizedMessage(() => UserResources.NameRequiredError)
                .WithName("Nazwy");
            //.WithMessage("Nazwa jest wymagana");

            RuleFor(u => u.Email).NotEmpty();

            RuleFor(u => u.Email).EmailAddress();

            //RuleFor(u => u.Nip).NotEmpty();

            //RuleFor(u => u.Nip).Must(nip => IsNipValid(nip));

            When(u => u.CreateInvoide, () =>
            {
                RuleFor(u => u.Nip)
                    .Cascade(CascadeMode.StopOnFirstFailure)
                    .NotEmpty()
                    //.Must(nip => IsNipValid(nip));
                    .Nip();

            });

            RuleFor(u => u.Name)
                .Must(name => userLogic.Exist(name) == false)
                .WithMessage("Użytkownik już istnieje");
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
