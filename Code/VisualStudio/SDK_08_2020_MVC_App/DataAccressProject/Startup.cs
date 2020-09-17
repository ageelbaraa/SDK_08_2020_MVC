using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DataAccressProject.Startup))]
namespace DataAccressProject
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
