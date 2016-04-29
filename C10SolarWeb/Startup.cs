using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(C10SolarWeb.Startup))]
namespace C10SolarWeb
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
