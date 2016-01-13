using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ef6.Startup))]
namespace ef6
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
