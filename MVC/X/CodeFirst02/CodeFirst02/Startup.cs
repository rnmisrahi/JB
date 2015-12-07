using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CodeFirst02.Startup))]
namespace CodeFirst02
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
