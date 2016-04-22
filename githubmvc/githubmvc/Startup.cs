using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(githubmvc.Startup))]
namespace githubmvc
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
