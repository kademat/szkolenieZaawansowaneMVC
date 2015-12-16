using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FluentValidationTest
{
    public static class IRuleBuilderOptionsExtensions
    {
        public static IRuleBuilderOptions<T, TProperty> Nip<T, TProperty>(this IRuleBuilderOptions<T, TProperty> ruleBuilder)
        {
            return ruleBuilder.SetValidator(new NipValidator());
        }
    }
}
