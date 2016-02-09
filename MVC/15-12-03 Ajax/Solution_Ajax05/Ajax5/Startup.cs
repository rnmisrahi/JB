using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Ajax5.Startup))]
namespace Ajax5
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
