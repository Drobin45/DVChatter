using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DVChatterAttempts.Startup))]
namespace DVChatterAttempts
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
