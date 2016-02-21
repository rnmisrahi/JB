using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CarRental02.Startup))]
namespace CarRental02
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
