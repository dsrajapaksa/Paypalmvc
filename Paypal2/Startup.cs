using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Paypal2.Startup))]
namespace Paypal2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
