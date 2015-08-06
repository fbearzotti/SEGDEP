using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Servicio.Startup))]
namespace Servicio
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
