using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;
using Project.Data;
using Project.Respository.UnitOfWork;

namespace Project.Respository.Installer
{
    public class RepositoryInstaller : IWindsorInstaller
    {
        public void Install(IWindsorContainer container, IConfigurationStore store)
        {
            container.Register(Classes.FromAssemblyContaining<IDbContextProvider>()
                .Where(x => x.Name.EndsWith("Repository"))
                .WithService.DefaultInterfaces()
                .LifestylePerWebRequest());
            container.Register(Component.For<IDbContextProvider>().ImplementedBy<DbContextProvider>().LifestylePerWebRequest());
            container.Register(Component.For<ApplicationDbContext>().LifestylePerWebRequest());
            container.Register(Component.For<IUnitOfWorkFactory>().ImplementedBy<UnitOfWorkFactory>().LifestylePerWebRequest());
            container.Register(Component.For<IUnitOfWork>().ImplementedBy<EntityFrameworkUnitOfWork>().LifestylePerWebRequest());

        }
    }
}
