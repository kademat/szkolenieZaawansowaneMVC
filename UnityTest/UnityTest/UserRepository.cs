using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace UnityTest
{
    class UserRepository : IUserRepository
    {
        public UserRepository()
        {
            Console.WriteLine("UserRepository.Ctor");

            Thread.Sleep(5000);
        }


        public void Test()
        {
            Console.WriteLine("UserRepository.Test, {0}", UserName);
        }

        public string UserName { get; set; }
    }
}
