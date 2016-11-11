using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVCRAST.Startup))]
namespace MVCRAST
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
