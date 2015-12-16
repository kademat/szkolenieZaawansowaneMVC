using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnityTest
{
    class UserLogic : IUserLogic
    {
        private Lazy<IUserRepository> _lazyUserRepository;


        private IUserRepository _userRepository
        {
            get
            {
                return _lazyUserRepository.Value;
            }
        }

        public UserLogic(Lazy<IUserRepository> userRepository)
        {
            _lazyUserRepository = userRepository;

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
