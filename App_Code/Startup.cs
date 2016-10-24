using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(_4003.Startup))]
namespace _4003
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
