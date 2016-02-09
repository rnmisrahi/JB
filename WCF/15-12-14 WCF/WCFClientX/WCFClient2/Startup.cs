using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WCFClient2.Startup))]
namespace WCFClient2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
