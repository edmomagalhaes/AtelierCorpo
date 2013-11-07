using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AtelierCorpo.Startup))]
namespace AtelierCorpo
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
