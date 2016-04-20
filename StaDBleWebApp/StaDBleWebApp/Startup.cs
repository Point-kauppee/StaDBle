using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(StaDBleWebApp.Startup))]
namespace StaDBleWebApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
