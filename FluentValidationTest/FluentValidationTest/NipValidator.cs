using FluentValidation.Validators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FluentValidationTest
{
    public class NipValidator : PropertyValidator
    {

        public NipValidator() : base("{PropertyName} ma niepoprawny format NIPu.")
        {

        }

        protected override bool IsValid(PropertyValidatorContext context)
        {
            var nip = context.PropertyValue as string;

            if (nip == null)
                return false;

            if (nip.Length != 10)
                return false;
            return true;
        }
    }
}
