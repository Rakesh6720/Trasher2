using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Trasher2.Startup))]
namespace Trasher2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
