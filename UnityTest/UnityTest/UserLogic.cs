using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnityTest
{
    class UserLogic : IUserLogic
    {
        private IUserRepository _userRepository;

        public UserLogic(IUserRepository userRepository)
        {
            _userRepository = userRepository;

            Console.WriteLine("UserLogic.Ctor");
        }

        public void Test()
        {
            _userRepository.Test();
            Console.WriteLine("UserLogic.Test");
        }

        public void Test2()
        {
            Console.WriteLine("UserLogic.Test2");
        }
    }
}
