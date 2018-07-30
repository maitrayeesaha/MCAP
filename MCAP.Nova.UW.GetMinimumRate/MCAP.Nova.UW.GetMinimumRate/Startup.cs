using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MCAP.Nova.UW.GetMinimumRate.Startup))]
namespace MCAP.Nova.UW.GetMinimumRate
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
