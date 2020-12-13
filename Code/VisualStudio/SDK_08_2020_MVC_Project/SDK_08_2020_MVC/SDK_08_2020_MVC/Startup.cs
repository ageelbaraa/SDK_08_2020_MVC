using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SDK_08_2020_MVC.Startup))]
namespace SDK_08_2020_MVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
