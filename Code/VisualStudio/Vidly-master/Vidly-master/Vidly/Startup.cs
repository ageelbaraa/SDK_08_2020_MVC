using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebAppltiction8.Startup))]
namespace WebAppltiction8
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
