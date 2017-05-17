using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(Beez.Web.Startup))]

namespace Beez.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
