using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FluentValidationTest
{
    class Program
    {
        static void Main(string[] args)
        {
            User user = new User();

            var validator = new UserValidator();

            var validationResult = validator.Validate(user);

            if (validationResult.IsValid == false)
            {
                foreach (var item in validationResult.Errors)
                {
                    Console.WriteLine("{0} : {1}", item.PropertyName, item.ErrorMessage);
                }
            }
        }
    }
}
