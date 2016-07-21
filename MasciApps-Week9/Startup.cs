using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MasciApps_Week9.Startup))]
namespace MasciApps_Week9
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
