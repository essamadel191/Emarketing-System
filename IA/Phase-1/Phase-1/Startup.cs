using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Phase_1.Startup))]
namespace Phase_1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
