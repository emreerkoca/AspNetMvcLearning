using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ProductProject.Startup))]
namespace ProductProject
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
