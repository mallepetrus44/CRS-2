using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CRS.Web.Startup))]
namespace CRS.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
