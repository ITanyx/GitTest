using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TestFirstMVC.Startup))]
namespace TestFirstMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
