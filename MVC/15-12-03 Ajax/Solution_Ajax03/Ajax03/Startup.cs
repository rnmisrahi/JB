using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Ajax03.Startup))]
namespace Ajax03
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
