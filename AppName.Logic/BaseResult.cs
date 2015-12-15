using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppName.Logic
{
    public class BaseResult
    {
        public bool Success { get; set; }

        public IEnumerable<ErrorMessage> Errors { get; set; }

    }

    public class ErrorMessage
    {
        public string PropertyName { get; set; }

        public string Error { get; set; }

    }
}
