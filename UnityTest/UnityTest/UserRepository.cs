using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnityTest
{
    class UserRepository : IUserRepository
    {
        public UserRepository()
        {
            Console.WriteLine("UserRepository.Ctor");
        }


        public void Test()
        {
            Console.WriteLine("UserRepository.Test");
        }
    }
}
