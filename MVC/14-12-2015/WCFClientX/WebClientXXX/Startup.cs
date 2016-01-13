using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebClientXXX.Startup))]
namespace WebClientXXX
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
