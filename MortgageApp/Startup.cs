using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MortgageApp.Startup))]
namespace MortgageApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
