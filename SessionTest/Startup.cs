using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SessionTest.Startup))]
namespace SessionTest
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
