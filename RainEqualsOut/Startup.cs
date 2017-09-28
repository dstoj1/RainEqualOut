using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(RainEqualsOut.Startup))]
namespace RainEqualsOut
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
