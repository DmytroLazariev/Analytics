using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AnalyticsTS.Startup))]
namespace AnalyticsTS
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
