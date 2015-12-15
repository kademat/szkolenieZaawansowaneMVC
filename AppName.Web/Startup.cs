using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AppName.Web.Startup))]
namespace AppName.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
