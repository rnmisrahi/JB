using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Ex1.Startup))]
namespace Ex1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
