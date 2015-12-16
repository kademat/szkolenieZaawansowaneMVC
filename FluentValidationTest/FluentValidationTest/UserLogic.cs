using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FluentValidationTest
{
    public class UserLogic : IUserLogic
    {
        public bool Exist(string name)
        {
            if (name == "Mateusz")
            {
                return true;
            }

            return false;
        }
    }
}
