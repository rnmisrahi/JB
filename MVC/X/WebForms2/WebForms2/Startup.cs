using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebForms2.Startup))]
namespace WebForms2
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
