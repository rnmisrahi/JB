using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebForms5.Startup))]
namespace WebForms5
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
