using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVCCustomLogin.Startup))]
namespace MVCCustomLogin
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
