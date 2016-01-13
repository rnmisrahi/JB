using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WEbFormValidation.Startup))]
namespace WEbFormValidation
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
