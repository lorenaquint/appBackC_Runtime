using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(appBackCService.Startup))]

namespace appBackCService
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureMobileApp(app);
        }
    }
}