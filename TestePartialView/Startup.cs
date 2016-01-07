using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TestePartialView.Startup))]
namespace TestePartialView
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
