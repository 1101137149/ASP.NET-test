using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FinalASP.Startup))]
namespace FinalASP
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
