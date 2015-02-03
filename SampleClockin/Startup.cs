using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SampleClockin.Startup))]
namespace SampleClockin
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
