using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(COMP4976_Lab02.Startup))]
namespace COMP4976_Lab02
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
