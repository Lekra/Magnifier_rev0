using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Magnifier_rev0.Startup))]
namespace Magnifier_rev0
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
