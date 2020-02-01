using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Assignment_One.Startup))]
namespace Assignment_One
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
