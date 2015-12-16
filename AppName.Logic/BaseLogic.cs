using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppName.Logic
{
    public class BaseLogic
    {
        protected T CreateFailureResult<T>(string propertyName, string error) where T : BaseResult
        {
            var result = Activator.CreateInstance<T>();

            result.Success = false;
            result.Errors = new List<ErrorMessage>()
            {
                new ErrorMessage()
                {
                    PropertyName = propertyName,
                    Error = error
                }
            };

            return result;
        }

        protected T CreateSuccesResult<T>(Action<T> action = null) where T : BaseResult
        {
            var result = Activator.CreateInstance<T>();

            result.Success = true;

            if (action != null)
            {
                action(result);
            }

            return result;
        }

        protected T CreateFailureResult<T>(IEnumerable<ValidationFailure> errors) where T : BaseResult
        {
            var result = Activator.CreateInstance<T>();

            result.Success = false;

            result.Errors = errors.Select(e => new ErrorMessage()
            {
                PropertyName = e.PropertyName,
                Error = e.ErrorMessage
            });

            return result;
        }
    }
}
