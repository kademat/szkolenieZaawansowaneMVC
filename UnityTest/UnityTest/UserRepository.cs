using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnityTest
{
    class UserRepository : IUserRepository
    {
        public void Test()
        {
            Console.WriteLine("UserRepository.Test");
        }
    }
}
