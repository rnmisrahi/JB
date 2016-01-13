using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Auth2.Startup))]
namespace Auth2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
