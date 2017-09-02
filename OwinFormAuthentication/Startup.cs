using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(OwinFormAuthentication.Startup))]
namespace OwinFormAuthentication
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
