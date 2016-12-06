using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVC_ITE.Startup))]
namespace MVC_ITE
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
