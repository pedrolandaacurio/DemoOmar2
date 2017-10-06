using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DemoOmar2.Startup))]
namespace DemoOmar2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
