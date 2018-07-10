using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(stackbuilders.Startup))]
namespace stackbuilders
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
