using Castle.MicroKernel.Registration;
using Castle.Windsor;
using Castle.Windsor.Installer;
using Project.Installer;
using Project.Logic.Installer;
using Project.Respository.Installer;

namespace Project.API.Installer
{
    public static class WindsorBootstrapper
    {
        private static IWindsorContainer _container;

        public static void Initialize()
        {
            _container = new WindsorContainer();
            _container.Install(FromAssembly.This(),
                FromAssembly.Containing<LogicInstaller>(),
                FromAssembly.Containing<RepositoryInstaller>(),
                FromAssembly.Containing<CommonInstaller>());

            _container.Register(Component.For<IWindsorContainer>().Instance(_container).LifestyleSingleton());

        }

        public static IWindsorContainer Container
        {
            get
            {
                return _container;
            }
        }
    }
}