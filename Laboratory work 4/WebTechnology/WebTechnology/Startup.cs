using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebTechnology.Startup))]
namespace WebTechnology
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
