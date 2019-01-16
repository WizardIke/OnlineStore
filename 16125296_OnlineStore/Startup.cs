using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(_16125296_OnlineStore.Startup))]
namespace _16125296_OnlineStore
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
