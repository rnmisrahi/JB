using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Solution_Ajax02.Startup))]
namespace Solution_Ajax02
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
