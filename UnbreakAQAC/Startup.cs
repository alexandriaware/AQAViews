using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(UnbreakAQAC.Startup))]
namespace UnbreakAQAC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
