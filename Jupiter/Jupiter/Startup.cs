using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Jupiter.Startup))]
namespace Jupiter
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
