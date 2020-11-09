using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(IS.Startup))]
namespace IS
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
