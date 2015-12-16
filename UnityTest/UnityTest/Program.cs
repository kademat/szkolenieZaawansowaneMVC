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

            //UserTests();
            SettingsTest();
        }

        private static void SettingsTest()
        {
            var window = _container.Resolve<SettingsWIndow>();

            window.Show();
        }

        private static void UserTests()
        {
            var userLogic = _container.Resolve<IUserLogic>();

            userLogic.Test();
            //nowa instancja!
            //_container.Resolve<IUserLogic>().Test2();

            //_container.Resolve<IUserLogic>().Test2();
            
        }

        private static void InitializeContainer()
        {
            //_container.RegisterType<IUserRepository, UserRepository>();
            //_container.RegisterType<IUserRepository, UserRepository>(new ContainerControlledLifetimeManager());
            //_container.RegisterInstance<IUserRepository>(_container.Resolve<UserRepository>());

            _container.RegisterType<IUserRepository>(new InjectionFactory(
                c =>
                {
                    var repository = c.Resolve<UserRepository>();
                    repository.UserName = "Mateusz";
                    return repository;
                }));

            _container.RegisterType<IUserLogic, UserLogic>();

            _container.RegisterType<IGeneralSettingView, GeneralSettingView>();
            //unikalne
            _container.RegisterType<ISettingView, GeneralSettingView>(typeof(GeneralSettingView).FullName);
            
            _container.RegisterType<IPasswordSetting, PasswordSettingView>();

            _container.RegisterType<ISettingView, PasswordSettingView>(typeof(PasswordSettingView).FullName);

            _container.RegisterType<IEnumerable<ISettingView>, ISettingView[]>();
        }
    }
}
