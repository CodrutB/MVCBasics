using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVCBasics.Startup))]
namespace MVCBasics
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
