using Microsoft.Practices.Unity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnityTest
{
    class Program
    {
        private static IUnityContainer _container = new UnityContainer();

        static void Main(string[] args)
        {
            InitializeContainer();

            Console.WriteLine("Po konfiguracji kontenera");

            UserTests();
        }

        private static void UserTests()
        {
            var userLogic = _container.Resolve<IUserLogic>();

            userLogic.Test();
            //nowa instancja!
            _container.Resolve<IUserLogic>().Test();

            _container.Resolve<IUserLogic>().Test();
        }

        private static void InitializeContainer()
        {
            _container.RegisterType<IUserRepository, UserRepository>();

            _container.RegisterType<IUserLogic, UserLogic>();
        }
    }
}
