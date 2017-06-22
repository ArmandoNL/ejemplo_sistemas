using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ejemplo1.Startup))]
namespace ejemplo1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
