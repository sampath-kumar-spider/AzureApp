using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AzureAutoDeployment.Startup))]
namespace AzureAutoDeployment
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
