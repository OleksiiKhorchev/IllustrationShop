using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(IllustrationShop.Web.Startup))]
namespace IllustrationShop.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
