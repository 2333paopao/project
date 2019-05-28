using Microsoft.Owin;
using Owin;
using Project.API;

[assembly: OwinStartup(typeof(Startup))]
namespace Project.API
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}