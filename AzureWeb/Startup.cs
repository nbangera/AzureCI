using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AzureWeb.Startup))]
namespace AzureWeb
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
