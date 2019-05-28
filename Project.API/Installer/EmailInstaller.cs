using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;

namespace Project.API.Installer
{
    public class EmailInstaller : IWindsorInstaller
    {
        public void Install(IWindsorContainer container, IConfigurationStore store)
        {

            container.Register(Component.For<IEmailService>().ImplementedBy<EmailService>().LifestylePerWebRequest());
        }
    }
}