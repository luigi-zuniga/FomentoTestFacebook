using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FL_App.Startup))]
namespace FL_App
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
