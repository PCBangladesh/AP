using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AP.Backend.Startup))]
namespace AP.Backend
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
